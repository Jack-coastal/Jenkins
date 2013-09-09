﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtest.Reporting.ViewModels
{
    public class AccountViewModel
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

}
