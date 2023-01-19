using DevExpress.Utils.Filtering.Internal;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Data;

namespace Test.Components.AccountView
{
    public partial class AccountView : DevExpress.XtraEditors.XtraUserControl
    {
        public AccountView()
        {
            InitializeComponent();
            InitBindings();
            
        }

        void InitBindings()
        {
            MVVMContextFluentAPI<AccountViewModel> fluent = mvvmContext1.OfType<AccountViewModel>();

            fluent.BindCommand(btnnewaccount, viewModel => viewModel.AccountNew());

            //BindingSource account = new BindingSource();
            fluent.SetBinding(gridControl1, gridControl => gridControl.DataSource, vm => vm.Account);

        }
    }
}
