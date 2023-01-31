using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Windows.Forms;
using Test.Components.AccountEditView;
using Test.Data;

namespace Test.Components.AccountView
{
    [POCOViewModel]
    public class AccountViewModel
    {
        [BindableProperty]
        public virtual BindingList<Account> AccountList { get; set; }

        protected IDialogService DialogService
        {
            get { return this.GetService<IDialogService>(); }

        }

        public void OpenAccountEdit()
        {
            // soll mit Create() erstellt werden
            AccountEditViewModel accountEditViewModel = AccountEditViewModel.Create(AccountList); //Viewodel A

            //Welche Viewmodel? => Baut sich selbst eine
            DialogService.ShowDialog(accountEditViewModel.Commands, "Konten bearbeiten", nameof(AccountEditView.AccountEditView), accountEditViewModel, null, this);

       
            //this.RaisePropertiesChanged();
            //private BindingList<Account> account;
            //this.account = new BindingList<Account>(Accounts.Konten);
            //var source = new BindingSource(account, null);
            //this.gridControl1.DataSource = account;
        }


        //public virtual List<Account> Account { get; set; }


        public AccountViewModel()
        {
            this.AccountList = new BindingList<Account>(Accounts.Konten);
            //BindingSource source = new BindingSource(AccountList, null);

            //    Account = Accounts.Konten;
        }


    }
}
