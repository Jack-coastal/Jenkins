using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtest.Reporting.ViewModels
{
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
