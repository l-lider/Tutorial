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
        public virtual List<Account> Account { get; set; }

        public AccountViewModel()
        {
            Account = Accounts.Konten;
        }

        public void AccountNew()
        {
            using (AccountNew frm = new AccountNew() { AccountInfo = new Account() })
            {
                DialogResult dlgResult = frm.ShowDialog();

                if (dlgResult == DialogResult.OK)
                {
                    this.Account.Add(frm.AccountInfo);

                }
            }
        }
    }
}