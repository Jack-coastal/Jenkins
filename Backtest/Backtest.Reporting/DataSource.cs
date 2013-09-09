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
    public class DataSource
    {
        object source;
        object report;
        string path;

        public ObservableCollection<AccountViewModel> OpenFileAction(string path)
        {
            ObservableCollection<AccountViewModel> res = new ObservableCollection<AccountViewModel>();
            
            string strpath = path; 
            try
            {

                string strline;
                string[] aryline;
                StreamReader mysr = new StreamReader(strpath, System.Text.Encoding.Default);

                int id = 0; decimal price; int size = 0; int order = 0; string side = "Other";
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
                            if (!int.TryParse(aryline[4], out id))
                            {
                                id = 0;
                            } 
                           if (!decimal.TryParse(aryline[2], out price))
                            {
                                price = 0;
                            }
                           if (!int.TryParse(aryline[5], out size))
                           {
                               size = 0;
                           }
                           if (aryline[3] == "2" || aryline[3] == "5")
                           {
                               side = "Short";
                               price = -price;
                           }
                           else if (aryline[3] == "1")
                           {
                               side = "Long";
                           }

                        

                            res.Add(new AccountViewModel()
                            {
                                Timestamp = aryline[6],
                                Account = aryline[0],
                                Symbol = aryline[1],
                                ID = id,
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

        public DataSource()
        {
            Report rep = new Report();
            source = CreateDataSource();
            rep.FetchLiveData(OpenFileAction(path));
            report = rep.ReportData;
        }

        protected object CreateDataSource()
        {

            path = "live.csv";
                return OpenFileAction(path).GroupBy(g=>
                    new { Account = g.Account,Symbol = g.Symbol})
                    .Select(s => new
                    {
                        s.Key.Account,
                        s.Key.Symbol,
                        LongAvgPrice = s.Where(r=>r.Side=="Long").Average(r => r.Price),
                        ShortAvgPrice = s.Where(r => r.Side == "Short").Average(r => r.Price),
                        SumSize = s.Sum(r => r.Size)/2
                        , Orders = s
                    });
        }
        
        protected object CreateReportSource(ObservableCollection<AccountViewModel> source)
        {
            ObservableCollection<ReportViewModel> report = new ObservableCollection<ReportViewModel>();

            IEnumerable<AccountViewModel> noduplicates = source.Distinct(new SymbolComparer());
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
