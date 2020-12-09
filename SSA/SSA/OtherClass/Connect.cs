using System;
using System.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace StudentSupportApp
{
    class Connect
    {
        SqlConnection Connection;
        public Connect()
        {
            String connString = @"Server=LAPTOP-SJVI7FIS;Database=SSADATABASE;User Id=sa;Password=Dung2406";
            this.Connection = new SqlConnection(connString);
        }
        public void OpenConnection()
        {
            Connection.Open();
        }
        public SqlCommand CreateSQLCmd(string args)
        {
            String sqlQuery = args;
            SqlCommand command = new SqlCommand(sqlQuery, Connection);
            return command;
        }
        public void CloseConnection()
        {
            Connection.Close();
        }
    }
    class MD5Encoder
    {
        public string FromString(string Message)
        {
            MD5 MyMD5 = MD5.Create();
            byte[] HashCode = MyMD5.ComputeHash(Encoding.Unicode.GetBytes(Message));
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < HashCode.Length; i++)
                SB.Append(HashCode[i].ToString("X2"));
            return SB.ToString();
        }
    }
}
