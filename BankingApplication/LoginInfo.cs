using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public static class LoginInfo
    {
        public static string Email;
        public static string AccountNumber;
        public static int Balance;

        public static OptionForm OptionForm = new OptionForm();
    }
    public static class Consants
    {
        public static string database = "DESKTOP-TRC58QD\\SQLEXPRESS";
    }
}
