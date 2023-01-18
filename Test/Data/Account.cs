using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data
{
    public class Account :INotifyPropertyChanged
    {

        private string _accountNumber { get; set; } 
        private string _accountName { get; set; }
        private decimal _balance { get; set; }

        

        public Account(string kontonummer, string name, decimal kontostand)
        {
            _accountNumber = kontonummer;
            _accountName = name;
            _balance = kontostand;
        }

        public Account()
        {
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public string AccountNumber
        {
            get
            {
                return this._accountNumber;
            }
            set
            {
                if (this._accountNumber != value)
                {
                    this._accountNumber = value;
                    this.OnPropertyChanged("AccountNumber");
                }    
            }
        }

        public string AccountName
        {
            get
            {
                return this._accountName;
            }
            set
            {
                if (this._accountName != value)
                {
                    this._accountName = value;
                    this.OnPropertyChanged("AccountName");
                }


            }

        }


        public decimal Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                if (this._balance != value)
                {
                    this._balance = value;
                    this.OnPropertyChanged("Balance");
                }
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
