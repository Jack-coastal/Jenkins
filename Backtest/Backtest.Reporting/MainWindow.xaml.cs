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


namespace Backtest.Reporting
{
    

    public partial class MainWindow : DXRibbonWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            var ds = new DataSource();
            if (ds != null)
            {
                LayoutPanel panel = new LayoutPanel() { Caption = "Live Report", AllowClose = false };
                AccountDataSheet sheet = new AccountDataSheet() { DataContext = ds };
                panel.Content = sheet;
                documents.Add(panel);
                panel.IsActive = true;
            }

             var bds = new BenchMarkDataSource();

             if (bds != null)
             {
                 LayoutPanel panel = new LayoutPanel() { Caption = "BenchMark Report", AllowClose = false };

                 BenchMarkDataSheet sheet = new BenchMarkDataSheet() { DataContext = bds };
                 panel.Content = sheet;
                 documents.Add(panel);

                 panel = new LayoutPanel() { Caption = "Report", AllowClose = false };
                     NewReportDataSheet Nsheet = new NewReportDataSheet() { DataContext = bds };
                     panel.Content = Nsheet;
                     documents.Add(panel);

                 panel.IsActive = true;
             }
        }

    }



}