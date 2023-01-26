using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Data;

namespace Test.Components.AccountEditView
{
    public partial class AccountEditView : DevExpress.XtraEditors.XtraUserControl
    {

        public Account AccountInfo { get; set; }
        public AccountEditView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        private void Speichern(object sender, EventArgs e)
        {
            AccountInfo.AccountNumber = textEdit1.Text;
            AccountInfo.AccountName = textEdit2.Text;
            AccountInfo.Balance = (decimal)spinEdit1.EditValue;

            //this.DialogResult = DialogResult.OK;
        }

        private void Schließen(object sender, EventArgs e)
        {
           // this.DialogResult = DialogResult.Cancel;
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<AccountEditViewModel>();
        }
    }
}

