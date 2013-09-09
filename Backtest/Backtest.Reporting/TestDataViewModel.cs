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
    public class TestDataViewModel : INotifyPropertyChanged
    {
        BackTestRepData BackData;

        public TestDataViewModel()
        {
            BackData = new BackTestRepData() { ParentID = -1 ,id = 0 };
        }

        #region BACK DATA
        public string Action
        {
            get { return BackData.Action; }
            set
            {
                if (BackData.Action == value)
                    return;
                BackData.Action = value;
                RaisePropertyChanged("Action");
            }
        }

        public string Timestamp
        {
            get { return BackData.Timestamp; }
            set
            {
                if (BackData.Timestamp == value)
                    return;
                BackData.Timestamp = value;
                RaisePropertyChanged("Timestamp");
            }
        }

        public string Account
        {
            get { return BackData.Account; }
            set
            {
                if (BackData.Account == value)
                    return;
                BackData.Account = value;
                RaisePropertyChanged("Account");
            }
        }

        public string Symbol
        {
            get { return BackData.Symbol; }
            set
            {
                if (BackData.Symbol == value)
                    return;
                BackData.Symbol = value;
                RaisePropertyChanged("Symbol");
            }
        }

        public int ID
        {
            get { return BackData.ID; }
            set
            {
                if (BackData.ID == value)
                    return;
                BackData.ID = value;
                RaisePropertyChanged("ID");
            }
        }

        public string Side
        {
            get { return BackData.Side; }
            set
            {
                if (BackData.Side == value)
                    return;
                BackData.Side = value;
                RaisePropertyChanged("Side");
            }
        }

        public int Size
        {
            get { return BackData.Size; }
            set
            {
                if (BackData.Size == value)
                    return;
                BackData.Size = value;
                RaisePropertyChanged("Size");
            }
        }

        public double Price
        {
            get { return BackData.Price; }
            set
            {
                if (BackData.Price == value)
                    return;
                BackData.Price = value;
                RaisePropertyChanged("Price");
            }
        }

        public int ParentID
        {
            get { return BackData.ParentID; }
            set
            {
                if (BackData.ParentID == value)
                    return;
                BackData.ParentID = value;
                RaisePropertyChanged("ParentID");
            }
        }

        public int id
        {
            get { return BackData.id; }
            set
            {
                if (BackData.id == value)
                    return;
                BackData.id = value;
                RaisePropertyChanged("id");
            }
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
        protected void RaisePropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
