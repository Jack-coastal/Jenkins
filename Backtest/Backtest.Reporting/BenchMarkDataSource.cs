using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Layout.Core;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DevExpress.Xpf.NavBar;
using DevExpress.Xpf.Charts;
using Microsoft.Win32;
using System.IO;
using Backtest.Reporting.ViewModels;
using FunctionLibrary;

namespace Backtest.Reporting
{
    public class BenchMarkDataSource
    {
        object source;
        object report;
        string path;

        public ObservableCollection<BenchMarkViewModel> OpenFileAction(string path)
        {
            ObservableCollection<BenchMarkViewModel> res = new ObservableCollection<BenchMarkViewModel>();
            
            string strpath = path; 
            try
            {

                string strline;
                string[] aryline;
                StreamReader mysr = new StreamReader(strpath, System.Text.Encoding.Default);

                decimal price; int size = 0; int order = 0;;string side = "Other";
                bool headerIgnored = false;
                while ((strline = mysr.ReadLine()) != null)
                {
                    if (!headerIgnored)
                    {
                        headerIgnored = true;
                        continue;
                    }
                    aryline = strline.Split(new char[] { ',' });

                    if (aryline.Count() > 0)
                    {
                           if (!decimal.TryParse(aryline[3], out price))
                            {
                                price = 0;
                            }
                           if (!int.TryParse(aryline[2], out size))
                           {
                               size = 0;
                           }
                           if (aryline[1] == "S" ||aryline[1] == "T")
                           {
                               side = "Short";
                               price = -price;
                           }
                          else if (aryline[1] == "B")
                           {
                            side = "Long";
                           }
                           
                            res.Add(new BenchMarkViewModel()
                            {
                                Account = aryline[4],
                                Symbol = aryline[0],
                                Side = side,
                                Size = size,
                                Price = price,
                            });
                            order++;
                    }
                }
                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
                return null;
            }
        }

        public BenchMarkDataSource()
        {
            source = CreateDataSource();
            Report rep = new Report();
            rep.FetchBenchmarkData(OpenFileAction(path));
            report = rep.ReportData;
            
        }

        protected object CreateDataSource()
        {
            path = "benchmark.csv";
                return OpenFileAction(path).GroupBy(g=>
                    new { Account = g.Account, Symbol = g.Symbol, Side = g.Side})
                    .Select(s => new {s.Key.Account,s.Key.Symbol, s.Key.Side, AvePrice = s.Average(r=>r.Price), SumSize = s.Sum(r=>r.Size)
                        , Orders = s
                    });
                
           
        }

        protected object CreateReportSource(ObservableCollection<BenchMarkViewModel> source)
        {
            ObservableCollection<ReportViewModel> report = new ObservableCollection<ReportViewModel>();

            IEnumerable<BenchMarkViewModel> noduplicates = source.Distinct(new BenchMarkSymbolComparer());
            int nodupsym = 0;
            foreach (var product in noduplicates)
                nodupsym++;

            report.Add(new ReportViewModel()
            {
                LiveSymbolsTraded = nodupsym
            });

            return report;

        }

        public object Data { get { return source; } }

        public object ReportData { get { return report; } }
    }
}
