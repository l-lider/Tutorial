using DevExpress.Utils.Filtering.Internal;
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
    
            
        }

        void InitBindings()
        {   
            var fluent = mvvmContext1.OfType<AccountViewModel>();
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource,
                x => x.account);


            // event to command (withevent ... tocommand ...)
        }

    }
}
