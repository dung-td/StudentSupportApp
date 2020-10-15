using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.InteropServices;

namespace SSA
{
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
    class Connect
    {
        SqlConnection Connection;
        public Connect()
        {
            String connString = @"Server=DUNGDEEPTRY;Database=SSADATABASE;User Id=sa;Password=Dung2705;";
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
    class USER
    {
        string sID;
        string sPassword;
        string sName;
        DateTime Birth;
        string sClass;
        string sEmail;
        string sGender;
        Connect Connection = new Connect();
        public USER()
        {
            this.sID = this.sPassword = this.sName = this.sGender = this.sEmail = this.sClass = "";
            this.Birth = DateTime.Today;
        }
        public USER(string[] args)
        {
            this.sID = args[0];
            this.sPassword = args[1];
        }
        public string ID
        {
            get
            {
                return sID;
            }
            set
            {
                sID = value;
            }
        }
        public string Password
        {
            get
            {
                return sPassword;
            }
            set
            {
                sPassword = value;
            }
        }
        public string Name
        {
            get
            {
                return sName;
            }
            set
            {
                sName = value;
            }
        }
        public string Gender
        {
            get
            {
                return sGender;
            }
            set
            {
                sGender = value;
            }
        }
        public string Class
        {
            get
            {
                return sClass;
            }
            set
            {
                sClass = value;
            }
        }
        public string Email
        {
            get
            {
                return sEmail;
            }
            set
            {
                sEmail = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return Birth;
            }
            set
            {
                Birth = value;
            }

        }

        public int CheckLogin()
        {
            string sCheckLogin = "SELECT PASS FROM USERS WHERE ID_USER = '" + this.sID + "'";
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                MD5Encoder PasswordEncoder = new MD5Encoder();
                if (reader.Read() == false) break;
                if (reader.GetString(0) == PasswordEncoder.FromString(this.sPassword))
                {
                    this.Connection.CloseConnection();
                    return 1;
                }
                this.Connection.CloseConnection();
                return -1;
            }
            this.Connection.CloseConnection();
            return 0;
        }
        public void LoadUserInfo()
        {
            string sLoadUserInfo = "SELECT * FROM USERS WHERE ID_USER = '" + this.sID + "'";
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(sLoadUserInfo);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                this.Email = reader.GetString(1);
                //this.Birthday = reader.GetString(2);
                this.Password = reader.GetString(3);
                this.Name = reader.GetString(4);
                this.Class = reader.GetString(5);
                this.Gender = reader.GetString(6);
            }
            this.Connection.CloseConnection();
        }
        public void AddUserToDatabase()
        {
            try
            {
                string sCheckLogin = "INSERT INTO USERS VALUES('" + this.ID + "', '" + this.Email + "', '" + this.Birth + "', '" +
                                                                    this.Password + "', '" + this.Name + "', '" + this.Class + "', '" + this.Gender + "')";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
    }
}
