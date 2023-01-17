using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Windows.Forms;
using Test.Data;

namespace Test.Components.AccountView
{
    [POCOViewModel]
    public class AccountViewModel
    {
        //public void NewAccount()
        //{
        //    using (AccountNew frm = new AccountNew() { AccountInfo = new Account() })
        //    {
        //        DialogResult dlgResult = frm.ShowDialog();

        //        if (dlgResult == DialogResult.OK)
        //        {
        //            Accounts.Konten.Add(frm.AccountInfo);
        //            //gridView1.LayoutChanged();
        //        }
        //    }
        //}
    }
}