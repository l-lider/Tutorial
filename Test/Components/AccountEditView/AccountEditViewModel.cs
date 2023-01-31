using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Test.Data;

namespace Test.Components.AccountEditView
{
    [POCOViewModel]
    public class AccountEditViewModel
    {
        public List<UICommand> Commands { get; set; }
        public BindingList<Account> AccountList { get; set; }
        public Account AccountNeu
        {
            get;
            set;
        }

        public virtual string Nummer
        {
            get;
            set;
        }
        public virtual string Name
        {
            get;
            set;
        }
        public virtual decimal Betrag
        {
            get;
            set;
        }

        // DelegateCommand anlegen
        public DelegateCommand _delegateSaveCommand { get; set; }

        // Create() erstellen
        public static AccountEditViewModel Create(BindingList<Account> AccountList) =>
        ViewModelSource.Create(() => new AccountEditViewModel(AccountList));

        protected AccountEditViewModel(BindingList<Account> accountList)
        {
            AccountList = accountList;
            // DelegateCommand initialisieren, soll Speichern() enthalten
            _delegateSaveCommand = new DelegateCommand(Speichern, CanSpeichern);

            Commands = new List<UICommand>
            {
            new UICommand {
                Id = DialogResult.OK,
                Caption = "Speichern",
                Command = _delegateSaveCommand,
                IsDefault = true,
                IsCancel = false,
                Tag = DialogResult.OK
            },
            new UICommand {
                Id = DialogResult.Cancel,
                Caption = "Schließen",
                Command = new DelegateCommand(() =>{ }),
                IsDefault = false,
                IsCancel = false,
                Tag = DialogResult.Cancel
            }            };

        }

        private bool CanSpeichern()
        {
            return true;
        }


        private void Speichern()
        {
            AccountNeu = new Account();

            AccountNeu.AccountNumber = Nummer;
            AccountNeu.AccountName = Name;
            AccountNeu.Balance = Betrag;

            //Accounts.Konten.Add(AccountNeu);


            AccountList.Add(AccountNeu);

        }
    }
}