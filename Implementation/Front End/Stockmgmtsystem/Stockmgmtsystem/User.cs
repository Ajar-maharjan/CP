using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Stockmgmtsystem
{
    public class User :DbConnect
    {
        public string Pin { get; set; }
        public string OldPin { get; set; }
        public string RecoveryCode { get; set; }

        DbConnect db;

        public bool Login()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from Users where Pin='" + Pin + "'";
            dt = db.select(query);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public String Register()
        {
            db = new DbConnect();
            RecoveryCode = CreateRecoveryCode();
            string query = "insert into Users values ('" + Pin + "','" 
                            + RecoveryCode + "')";
            db.manipulate(query);
            return RecoveryCode;
        }

        public bool ChangePin()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from Users where Pin = '" + OldPin + "'" +
                "           And RecoveryCode ='" + RecoveryCode + "'";
            dt = db.select(query);
            if (dt.Rows.Count > 0)
            {
                string query2 = "update Users set Pin = '" + Pin + "' " +
                           "where Pin = '" + OldPin + "'And " +
                           "RecoveryCode ='" + RecoveryCode + "'";
                manipulate(query2);
                return true;
            }
            else
                return false; 
        }

        public bool ForgotPin()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select Pin from Users where RecoveryCode ='" 
                            + RecoveryCode + "'";
            dt = db.select(query);
            if (dt.Rows.Count > 0)
            {
                string code = dt.Rows[0][0].ToString();
                Pin = code;
                return true;
            }
            else
                return false;
        }

        public bool CheckUserExist()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from Users";
            dt = db.select(query);
            if (dt.Rows.Count == 0)
                return true;
            else
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
                ch = Convert.ToChar(Convert.ToInt32
                            (Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
    }
}
