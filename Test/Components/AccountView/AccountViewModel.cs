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
        //protected IDialogService DialogService
        //{
        //    get { return this.GetService<IDialogService>(); }
        //}

        // hier wird der DialogService gestartet 
        // er brauch ein ViewModel und die darin enthaltenen UIcommands
        // die entsprechende View soll in dem Dialog angezeigt werden.
        // In dem Dialog sollen 2 Buttons (Schließen und Speichern) vorhanden sein.
        
        public void OpenAccountEdit()
        {
            var commands = new List<UICommand>
        {
            // Button with custom command attached
            new UICommand {
                Id = "Speichern",
                Caption = "Speichern",
                Command = new DelegateCommand(() =>{
                     // . . . implement the Speichern command here 

                 }),
                IsDefault = true,
                IsCancel = false,
                Tag = DialogResult.OK
            },
            // standard button caption customization
            new UICommand {
                 Caption = "Schließen",
                 Tag = DialogResult.Cancel
            }
        };
            var editAccount = DialogService.ShowDialog(commands, "Konten bearbeiten", "Test", null, this);

        }


        public virtual List<Account> Account { get; set; }

        public AccountViewModel()
        {
            Account = Accounts.Konten;
        }


    }
}