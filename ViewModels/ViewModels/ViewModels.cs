using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class AccountViewModel //test commit
    {
        #region Data Members
        string _action;
        string _timestamp;
        string _account;
        string _symbol;
        int _id;
        string _side;
        int _size;
        decimal _price;
        int _order;
        decimal _avePrice;
        #endregion

        #region Data Properties
        public string Action
        {
            get { return _action; }
            set
            {
                _action = value;
                OnPropertyChanged("Action");
            }
        }

        public string Timestamp
        {
            get { return _timestamp; }
            set
            {
                _timestamp = value;
                OnPropertyChanged("Timestamp");
            }
        }

        public string Account
        {
            get { return _account; }
            set
            {
                _account = value;
                OnPropertyChanged("Account");
            }
        }

        public string Symbol
        {
            get { return _symbol; }
            set
            {
                _symbol = value;
                OnPropertyChanged("Symbol");
            }
        }

        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }

        public string Side
        {
            get { return _side; }
            set
            {
                _side = value;
                OnPropertyChanged("Side");
            }
        }

        public int Size
        {
            get { return _size; }
            set
            {
                _size = value;
                OnPropertyChanged("Size");
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        public decimal AvePrice
        {
            get { return _avePrice; }
            set
            {
                _avePrice = value;
                OnPropertyChanged("AvePrice");
            }
        }

        public int Order
        {
            get { return _order; }
            set
            {
                _order = value;
                OnPropertyChanged("Order");
            }
        }
        #endregion

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }


    // Custom comparer for the Product class 
    class SymbolComparer : IEqualityComparer<AccountViewModel>
    {
        // Products are equal if their names and product numbers are equal. 
        public bool Equals(AccountViewModel x, AccountViewModel y)
        {

            //Check whether the compared objects reference the same data. 
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null. 
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal. 
            return x.Symbol == y.Symbol;
        }

        // If Equals() returns true for a pair of objects  
        // then GetHashCode() must return the same value for these objects. 

        public int GetHashCode(AccountViewModel product)
        {
            //Check whether the object is null 
            if (Object.ReferenceEquals(product, null)) return 0;

            //Get hash code for the Name field if it is not null. 
            int hashProductSymbol = product.Symbol == null ? 0 : product.Symbol.GetHashCode();

            //Get hash code for the Code field. 
            // int hashProductCode = product.Code.GetHashCode();

            //Calculate the hash code for the product. 
            //return hashProductName ^ hashProductCode;
            return hashProductSymbol;
        }
    }


    public class BenchMarkViewModel
    {
        #region Data Members
        string _account;
        string _symbol;
        string _side;
        int _size;
        decimal _price;
        decimal _avePrice;
        #endregion

        #region Data Properties

        public string Account
        {
            get { return _account; }
            set
            {
                _account = value;
                OnPropertyChanged("Account");
            }
        }

        public string Symbol
        {
            get { return _symbol; }
            set
            {
                _symbol = value;
                OnPropertyChanged("Symbol");
            }
        }


        public string Side
        {
            get { return _side; }
            set
            {
                _side = value;
                OnPropertyChanged("Side");
            }
        }

        public int Size
        {
            get { return _size; }
            set
            {
                _size = value;
                OnPropertyChanged("Size");
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        public decimal AvePrice
        {
            get { return _avePrice; }
            set
            {
                _avePrice = value;
                OnPropertyChanged("AvePrice");
            }
        }

        #endregion

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }


    // Custom comparer for the Product class 
    class BenchMarkSymbolComparer : IEqualityComparer<BenchMarkViewModel>
    {
        // Products are equal if their names and product numbers are equal. 
        public bool Equals(BenchMarkViewModel x, BenchMarkViewModel y)
        {

            //Check whether the compared objects reference the same data. 
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null. 
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal. 
            return x.Symbol == y.Symbol;
        }

        // If Equals() returns true for a pair of objects  
        // then GetHashCode() must return the same value for these objects. 

        public int GetHashCode(BenchMarkViewModel product)
        {
            //Check whether the object is null 
            if (Object.ReferenceEquals(product, null)) return 0;

            //Get hash code for the Name field if it is not null. 
            int hashProductSymbol = product.Symbol == null ? 0 : product.Symbol.GetHashCode();

            //Get hash code for the Code field. 
            // int hashProductCode = product.Code.GetHashCode();

            //Calculate the hash code for the product. 
            //return hashProductName ^ hashProductCode;
            return hashProductSymbol;
        }
    }

    public class ReportViewModel
    {
        #region Data Members
        string _symbol;
        decimal _liveaveEntry;
        decimal _liveaveExit;
        string _liveside;
        int _livesize;
        decimal _pnl;
        decimal _slippage;
        decimal _benchMarkaveEntry;
        decimal _benchMarkaveExit;
        string _benchMarkside;
        int _benchMarksize;

        string _date;
        string _liveAccount;
        string _benchMarkAccount;
        int _liveSymbolsTraded;
        int _benchMarkSymbolsTraded;
        decimal _liveNetExposure;
        decimal _benchMarkNetExposure;
        decimal _liveGrossExposure;
        decimal _benchMarkGrossExposure;
        #endregion

        #region Data Properties

        public string Symbol
        {
            get { return _symbol; }
            set
            {
                _symbol = value;
                OnPropertyChanged("Symbol");
            }
        }

        public string LiveSide
        {
            get { return _liveside; }
            set
            {
                _liveside = value;
                OnPropertyChanged("LiveSide");
            }
        }

        public int LiveSize
        {
            get { return _livesize; }
            set
            {
                _livesize = value;
                OnPropertyChanged("LiveSize");
            }
        }

        public decimal LiveAveEntry
        {
            get { return _liveaveEntry; }
            set
            {
                _liveaveEntry = value;
                OnPropertyChanged("LiveAveEntry");
            }
        }

        public decimal LiveAveExit
        {
            get { return _liveaveExit; }
            set
            {
                _liveaveExit = value;
                OnPropertyChanged("LiveAveExit");
            }
        }

        public decimal Slippage
        {
            get { return _slippage; }
            set
            {
                _slippage = value;
                OnPropertyChanged("Slippage");
            }
        }

        public decimal PnL
        {
            get { return _pnl; }
            set
            {
                _pnl = value;
                OnPropertyChanged("PnL");
            }
        }

        public decimal BenchMarkAveEntry
        {
            get { return _benchMarkaveEntry; }
            set
            {
                _benchMarkaveEntry = value;
                OnPropertyChanged("benchMarkAveEntry");
            }
        }

        public decimal BenchMarkAveExit
        {
            get { return _benchMarkaveExit; }
            set
            {
                _benchMarkaveExit = value;
                OnPropertyChanged("benchMarkAveExit");
            }
        }

        public string BenchMarkSide
        {
            get { return _benchMarkside; }
            set
            {
                _benchMarkside = value;
                OnPropertyChanged("BenchMarkSide");
            }
        }

        public int BenchMarkSize
        {
            get { return _benchMarksize; }
            set
            {
                _benchMarksize = value;
                OnPropertyChanged("BenchMarkSize");
            }
        }

        public string Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }

        public string LiveAccount
        {
            get { return _liveAccount; }
            set
            {
                _liveAccount = value;
                OnPropertyChanged("LiveAccount");
            }
        }

        public string BenchMarkAccount
        {
            get { return _benchMarkAccount; }
            set
            {
                _benchMarkAccount = value;
                OnPropertyChanged("BenchMarkAccount");
            }
        }

        public int LiveSymbolsTraded
        {
            get { return _liveSymbolsTraded; }
            set
            {
                _liveSymbolsTraded = value;
                OnPropertyChanged("LiveSymbolsTraded");
            }
        }

        public int BenchMarkSymbolsTraded
        {
            get { return _benchMarkSymbolsTraded; }
            set
            {
                _benchMarkSymbolsTraded = value;
                OnPropertyChanged("BenchMarkSymbolsTraded");
            }
        }

        public decimal LiveNetExposure
        {
            get { return _liveNetExposure; }
            set
            {
                _liveNetExposure = value;
                OnPropertyChanged("LiveNetExposure");
            }
        }

        public decimal BenchMarkNetExposure
        {
            get { return _benchMarkNetExposure; }
            set
            {
                _benchMarkNetExposure = value;
                OnPropertyChanged("BenchMarkNetExposure");
            }
        }

        public decimal LiveGrossExposure
        {
            get { return _liveGrossExposure; }
            set
            {
                _liveGrossExposure = value;
                OnPropertyChanged("LiveGrossExposure");
            }
        }

        public decimal BenchMarkGrossExposure
        {
            get { return _benchMarkGrossExposure; }
            set
            {
                _benchMarkGrossExposure = value;
                OnPropertyChanged("BenchMarkGrossExposure");
            }
        }
        #endregion

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
