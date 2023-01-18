using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data
{
    public class Account :INotifyPropertyChanged
    {

        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        

        public Account(string kontonummer, string name, decimal kontostand)
        {
            AccountNumber = kontonummer;
            AccountName = name;
            Balance = kontostand;
        }

        public Account()
        {
        }

        protected virtual void OnPropretyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string kontonummer
        {
            get
            {
                return this.AccountNumber;
            }
            set
            {
                if (this.AccountNumber != value)
                {
                    this.AccountNumber = value;
                    this.OnPropretyChanged("AccountNumber");
                }
                        
            }

        }

        public string name
        {
            get
            {
                return this.AccountName;
            }
            set
            {
                if (this.AccountName != value)
                {
                    this.AccountName = value;
                    this.OnPropretyChanged("AccountName");
                }


            }

        }


        public decimal kontostand
        {
            get
            {
                return this.Balance;
            }
            set
            {
                if (this.Balance != value)
                {
                    this.Balance = value;
                    this.OnPropretyChanged("Balance");
                }
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
