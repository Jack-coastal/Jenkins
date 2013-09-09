using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backtest.Reporting.ViewModels;
using DevExpress.Xpf.Docking;
using FunctionLibrary;

namespace Backtest.Reporting
{
    class Report
    {
        object reportSource;
        static ObservableCollection<AccountViewModel> live = null;
        static ObservableCollection<BenchMarkViewModel> benchMark = null;
        bool signal = false;

        public void FetchLiveData(ObservableCollection<AccountViewModel> source)
        {
            live = source;
            if (live != null && benchMark != null)
            {
                reportSource = CreateDataSource();
                signal = true;
            }
            else
            {
                signal = false;
            }
        }
        public void FetchBenchmarkData(ObservableCollection<BenchMarkViewModel> source)
        {
            benchMark = source;
            if (live != null && benchMark != null)
            {
                reportSource = CreateDataSource();
                signal = true;
            }
            else
            {
                signal = false;
            }

        }

        protected object CreateDataSource()
        {
            var avgFunc = FunctionLib.Avg();
            var sumFunc = FunctionLib.Sum();
            string[] date = new string[2];
            //DateTime date = DateTime.Parse("0");

            ObservableCollection<ReportViewModel> res = new ObservableCollection<ReportViewModel>();

            var groupedBySymbolBenchMark = benchMark.GroupBy(s => s.Symbol);
            var groupedBySymbolLive = live.GroupBy(s => s.Symbol);

            decimal liveaEx = 0; decimal liveaEn = 0; string liveside = "Other"; int livesize = 0;
            decimal pnl = 0; decimal slippage = -100;

            string benchMarkSide = ""; string benchMarkAccount = ""; string liveAccount = "";// int liveNumSym = 0; int benchMarkNumSym = 0;

            #region get the number of live and benchmark trades symbols
            /*IEnumerable<AccountViewModel> noduplicates = live.Distinct(new SymbolComparer());
            foreach (var product in noduplicates)
                liveNumSym++;

            IEnumerable<BenchMarkViewModel> bnoduplicates = benchMark.Distinct(new BenchMarkSymbolComparer());
            foreach (var product in bnoduplicates)
                benchMarkNumSym++;*/
            #endregion

            #region combine all data in live data
            foreach (var group in groupedBySymbolLive)
            {
                var avgExit = FunctionLib.Delay(avgFunc, 1);
                var avgEntry = FunctionLib.Delay(avgFunc, 1);
                var sumSize = FunctionLib.Delay(sumFunc, 1);
                var bMsumSize = FunctionLib.Delay(sumFunc, 1);
                var bMavgEntry = FunctionLib.Delay(avgFunc, 1);
                var bMavgExit = FunctionLib.Delay(avgFunc, 1);
                int fisrtbmSide = 0;
                int fisrtSide = 0; decimal benchMarkaEn = 0; int benchMarksize = 0; decimal benchMarkaEx = 0;
                benchMarkSide = "";

                #region get the ave price and sum size in the group
                foreach (var liveData in group)
                {
                    liveAccount = liveData.Account;
                    //date = DateTime.ParseExact(liveData.Timestamp.ToString(), "yyyyMMdd-HH:mm:ss.fff",System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                    date = liveData.Timestamp.Split(new char[] { '-' });
                    if (fisrtSide == 0)
                    {
                        liveside = liveData.Side;
                        fisrtSide++;
                    }
                    if (liveside == "Short")
                    {
                        if (liveData.Side == "Long")
                        {
                            liveaEx = avgExit(liveData.Price);
                        }
                        else if (liveData.Side == "Short")
                        {
                            liveaEn = avgEntry(liveData.Price);
                            livesize = sumSize(liveData.Size);
                        }
                    }
                    if (liveside == "Long")
                    {
                        if (liveData.Side == "Short")
                        {
                            liveaEx = avgExit(liveData.Price);
                        }
                        else if (liveData.Side == "Long")
                        {
                            liveaEn = avgEntry(liveData.Price);
                            livesize = sumSize(liveData.Size);
                        }
                    }

                }
                #endregion

                #region get pnl data

                if (liveside == "Short")
                {
                    pnl = -(liveaEn + liveaEx) * livesize;
                }
                if (liveside == "Long")
                {
                    pnl = -(liveaEx + liveaEn) * livesize;
                }
                #endregion

                #region join the benchMark data
                // bool show = true;
                foreach (var brenMarkGroup in groupedBySymbolBenchMark)
                {
                    if (group.Key == brenMarkGroup.Key)
                    {
                        foreach (var brenchMarkData in brenMarkGroup)
                        {
                            benchMarkAccount = brenchMarkData.Account;
                            if (fisrtbmSide == 0)
                            {
                                benchMarkSide = brenchMarkData.Side;
                                fisrtbmSide++;
                            }

                            if (benchMarkSide == "Short")
                            {
                                if (brenchMarkData.Side == "Long")
                                {
                                    benchMarkaEx = bMavgExit(brenchMarkData.Price);
                                }
                                else if (brenchMarkData.Side == "Short")
                                {
                                    benchMarksize = bMsumSize(brenchMarkData.Size);
                                    benchMarkaEn = bMavgEntry(brenchMarkData.Price);
                                }
                            }
                            if (benchMarkSide == "Long")
                            {
                                if (brenchMarkData.Side == "Short")
                                {
                                    benchMarkaEx = bMavgExit(brenchMarkData.Price);
                                }
                                else if (brenchMarkData.Side == "Long")
                                {
                                    benchMarkaEn = bMavgEntry(brenchMarkData.Price);
                                    benchMarksize = bMsumSize(brenchMarkData.Size);
                                }
                            }
                        }
                    }
                }
                #endregion

                #region get slippage data
                if (benchMarkaEn != 0)
                {
                    slippage = liveaEn - benchMarkaEn;
                }
                else
                {
                    slippage = -100;
                }
                #endregion

                res.Add(new ReportViewModel()
                {
                   // LiveSymbolsTraded = liveNumSym,
                   // BenchMarkSymbolsTraded = benchMarkNumSym,
                    LiveAccount = liveAccount,
                    BenchMarkAccount = benchMarkAccount,
                    Symbol = group.Key,
                    LiveSide = liveside,
                    LiveAveEntry = Math.Round(liveaEn, 2),
                    LiveAveExit = Math.Round(liveaEx, 2),
                    LiveSize = livesize,
                    BenchMarkAveEntry = Math.Round(benchMarkaEn, 2),
                    BenchMarkSide = benchMarkSide,
                    BenchMarkSize = benchMarksize,
                    BenchMarkAveExit = Math.Round(benchMarkaEx, 2),
                    PnL = Math.Round(pnl, 2),
                    Slippage = Math.Round(slippage, 4),
                    Date=date[0],
                });
            }
            #endregion

            #region get data only in benchMark and no in live data
            foreach (var brenMarkGroup in groupedBySymbolBenchMark)
            {
                var bMsumSize = FunctionLib.Delay(sumFunc, 1);
                var bMavgEntry = FunctionLib.Delay(avgFunc, 1);
                var bMavgExit = FunctionLib.Delay(avgFunc, 1);

                int fisrtbmSide = 0;
                decimal benchMarkaEn = 0; int benchMarksize = 0; decimal benchMarkaEx = 0;
                bool liveSymExist = false;

                #region find the symbol no in live data
                foreach (var compgroup in groupedBySymbolLive)
                {
                    if (compgroup.Key == brenMarkGroup.Key)
                    {
                        liveSymExist = true;
                    }
                }
                #endregion

                if (liveSymExist == false)
                {
                    #region caluate ave benchmark data
                    foreach (var brenchMarkData in brenMarkGroup)
                    {
                        if (fisrtbmSide == 0)
                        {
                            benchMarkSide = brenchMarkData.Side;
                            fisrtbmSide++;
                        }

                        if (benchMarkSide == "Short")
                        {
                            if (brenchMarkData.Side == "Long")
                            {
                                benchMarkaEx = bMavgExit(brenchMarkData.Price);
                            }
                            else if (brenchMarkData.Side == "Short")
                            {
                                benchMarksize = bMsumSize(brenchMarkData.Size);
                                benchMarkaEn = bMavgEntry(brenchMarkData.Price);
                            }
                        }
                        if (benchMarkSide == "Long")
                        {
                            if (brenchMarkData.Side == "Short")
                            {
                                benchMarkaEx = bMavgExit(brenchMarkData.Price);
                            }
                            else if (brenchMarkData.Side == "Long")
                            {
                                benchMarkaEn = bMavgEntry(brenchMarkData.Price);
                                benchMarksize = bMsumSize(brenchMarkData.Size);
                            }
                        }
                    }
                    #endregion

                    res.Add(new ReportViewModel()
                    {
                      //  LiveSymbolsTraded = liveNumSym,
                      //  BenchMarkSymbolsTraded = benchMarkNumSym,
                        LiveAccount = "",
                        BenchMarkAccount = benchMarkAccount,
                        Symbol = brenMarkGroup.Key,
                        LiveSide = "",
                        LiveAveEntry = 0,
                        LiveAveExit = 0,
                        LiveSize = 0,
                        BenchMarkAveEntry = Math.Round(benchMarkaEn, 2),
                        BenchMarkSide = benchMarkSide,
                        BenchMarkSize = benchMarksize,
                        BenchMarkAveExit = Math.Round(benchMarkaEx, 2),
                        PnL = 0,
                        Slippage = -100,
                        Date = "",
                    });
                }

            }
            #endregion

            return res.GroupBy(g =>
                     new
                     {
                         DateMaster = g.Date,
                         BenchMarkAccount = g.BenchMarkAccount,
                         LiveAccount = g.LiveAccount,
                     })
                     .Select(s => new
                     {
                         s.Key.DateMaster,
                         s.Key.BenchMarkAccount,
                         s.Key.LiveAccount,
                         BenchMarkSymbolsTraded = s.Where(r => r.BenchMarkSide != "").Select(r=>r.Symbol).Distinct().Count(),
                         LiveSymbolsTraded = s.Where(r => r.LiveSide != "").Select(r => r.Symbol).Distinct().Count(),
                         LiveGross = s.Where(r => r.LiveSide == "Long").Sum(r => r.LiveSize * r.LiveAveEntry) - s.Where(r => r.LiveSide == "Short").Sum(r => r.LiveSize * r.LiveAveEntry),
                         BenchMarkGross = s.Where(r => r.BenchMarkSide == "Long").Sum(r => r.BenchMarkSize * r.BenchMarkAveEntry) - s.Where(r => r.BenchMarkSide == "Short").Sum(r => r.BenchMarkSize * r.BenchMarkAveEntry),
                         LiveExposure = s.Where(r => r.LiveSide == "Long").Sum(r => r.LiveSize * r.LiveAveEntry) + s.Where(r => r.LiveSide == "Short").Sum(r => r.LiveSize * r.LiveAveEntry),
                         BenchMarkExposure = s.Where(r => r.BenchMarkSide == "Long").Sum(r => r.BenchMarkSize * r.BenchMarkAveEntry) + s.Where(r => r.BenchMarkSide == "Short").Sum(r => r.BenchMarkSize * r.BenchMarkAveEntry),
                         ReportOrders = s,
                     });

            // return res;
        }

        public object ReportData { get { return reportSource; } }

        public bool Signal { get { return signal; } }
    }
}
