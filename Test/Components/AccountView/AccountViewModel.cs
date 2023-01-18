using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Test.Data;

namespace Test.Components.AccountView
{
    [POCOViewModel]
    public class AccountViewModel
    {

        public virtual BindingList<Account> account { get; set; } = new BindingList<Account>();

        public void AccountNew()
        {
            using (AccountNew frm = new AccountNew() { AccountInfo = new Account() })
            {
                DialogResult dlgResult = frm.ShowDialog();

                if (dlgResult == DialogResult.OK)
                {
                    this.account.Add(frm.AccountInfo);

                }

            }
        }

        //protected void OnAccountChanged()
        //{
        //    this.RaiseCanExecuteChanged(x => x.AccountNew());
        //}

        protected AccountViewModel() {
            
            this.account = new BindingList<Account>(Accounts.Konten);
            var source = new BindingSource(account, null);
       
        }

        public static AccountViewModel Create()
        {
            return ViewModelSource.Create(() => new AccountViewModel());
        }
    }
}