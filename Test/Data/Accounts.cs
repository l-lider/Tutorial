using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test.Data
{
    static class Accounts
    {
        private static Account AccountZimmer = new Account("123", "Max Zimmer", 5.31m);
        private static Account AccountLider = new Account("456", "Lidia Lider", 4.23m);
        private static Account AccountKeller = new Account("789", "Kai-Uwe Keller", 7.45m);

        public static List<Account> Konten = new List<Account>() {AccountZimmer, AccountLider, AccountKeller};
    }
}
