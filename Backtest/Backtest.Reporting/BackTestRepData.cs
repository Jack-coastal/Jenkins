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

namespace DXApplication1
{
    public class BackTestRepData
    {
        public string Action { get; set; }
        public string Timestamp { get; set; }
        public string Account { get; set; }
        public string Symbol { get; set; }
        public int ID { get; set; }
        public string Side { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public int ParentID { get; set; }
        public int id { get; set; }
    
    }

}