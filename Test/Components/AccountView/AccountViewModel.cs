using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Test.Components.AccountEditView;
using Test.Data;

namespace Test.Components.AccountView
{
    [POCOViewModel]
    public class AccountViewModel


    {

        protected IDialogService DialogService
        {
            get { return this.GetService<IDialogService>(); }

        }

        // hier wird der DialogService gestartet 
        // er brauch ein ViewModel und die darin enthaltenen UIcommands
        // die entsprechende View soll in dem Dialog angezeigt werden.
        // In dem Dialog sollen 2 Buttons (Schließen und Speichern) vorhanden sein.

        public void OpenAccountEdit()
        {
            AccountEditViewModel accountEditViewModel = new AccountEditViewModel();
            
            var editAccount = DialogService.ShowDialog(accountEditViewModel.Commands, "Konten bearbeiten", "AccountEditView", null, this);

        }


        public virtual List<Account> Account { get; set; }

        public AccountViewModel()
        {
            Account = Accounts.Konten;
        }


    }
}