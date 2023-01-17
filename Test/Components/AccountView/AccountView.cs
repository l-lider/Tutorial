using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Data;

namespace Test.Components.AccountView
{
    public partial class AccountView : DevExpress.XtraEditors.XtraUserControl
    {
        private BindingList<Account> account;
        public AccountView()
        {
            InitializeComponent();

            this.account = new BindingList<Account>(Accounts.Konten);
            var source = new BindingSource(account, null);
            this.gridControl1.DataSource = account;
            
        }

        private void AccountNew(object sender, EventArgs e)
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

    }
}
