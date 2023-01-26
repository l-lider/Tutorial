using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Test.Components.AccountEditView
{
    [POCOViewModel]
    public class AccountEditViewModel
    {
        public List<UICommand> Commands { get; set; }

        public AccountEditViewModel()
        {
            Commands = new List<UICommand>
        {
            new UICommand {
                Id = DialogResult.OK,
                Caption = "Speichern",
                Command = new DelegateCommand(() =>{}),
                IsDefault = true,
                IsCancel = false,
                Tag = DialogResult.OK
            },
            new UICommand {
                Id = DialogResult.Cancel,
                Caption = "Schließen",
                Command = new DelegateCommand(() =>{}),
                IsDefault = false,
                IsCancel = false,
                Tag = DialogResult.Cancel
            }
        };
        }
        public void Speichern() { }

        public void Schließen() { }
    }
}