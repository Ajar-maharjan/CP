using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Stockmgmtsystem
{
    class User :DbConnect
    {
        String loggedPin;
        public string Pin { get; set; }
        public string RecoveryCode { get; set; }

        public bool Login()
        {
            return false;
        }

        public void Logout()
        {
            loggedPin = "";
        }
        
        public String Register()
        {
            return "";
        }

        public string ForgotPin()
        {
            return "";
        }

        public bool CheckUserExist()
        {
            return false;
        }

        private string CreateRecoveryCode()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }  

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
    }
}
