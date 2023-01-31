using DevExpress.ChartRangeControlClient.Core;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.Diagnostics;
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
        public AccountEditView()
        {
            InitializeComponent();
            if (mvvmContext1.IsDesignMode)
            {
                return;
            }
            InitializeBindings();            
        }

        void InitializeBindings()
        {
            MVVMContextFluentAPI<AccountEditViewModel> fluent = mvvmContext1.OfType<AccountEditViewModel>();

            // Binding um TextEdit Inhalt ins ViewModel zu bringen
            fluent.SetBinding(textEdit1, control => control.EditValue, viewmodel => viewmodel.Nummer);
            fluent.SetBinding(textEdit2, control => control.EditValue, viewmodel => viewmodel.Name);
            fluent.SetBinding(spinEdit1, control => control.EditValue, viewmodel => viewmodel.Betrag);
        }
    }
}

