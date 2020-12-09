using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace StudentSupportApp
{
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
    class EmailVerify
    {
        string Email, Code, Name;
        public EmailVerify(string Email)
        {
            this.Email = Email;
            this.Name = "";
            this.Code = "";
        }
        public string GetEmail
        {
            get
            {
                return this.Email;
            }
            set
            {
                this.Email = value;
            }
        }
        public string GetName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public string GetCode
        {
            get
            {
                return this.Code;
            }
            set
            {
                this.Code = value;
            }
        }
        public void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("ssa.nonreply@gmail.com");
                mail.To.Add(this.Email);
                mail.Subject = "Student Support App OTP";
                mail.Body = "Hello" + this.Name + ", \nHere is your OTP: " + this.Code + "\n";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ssa.nonreply@gmail.com", "Dung0478");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void GetRandomCode()
        {
            Random rand = new Random();
            char[] letters = "0123456789".ToCharArray();
            string word = "";
            for (int i = 0; i < 7; i++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                word += letters[letter_num];
            }
            this.GetCode = word;
        }
    }
    class Connect
    {
        SqlConnection Connection;
        public Connect()
        {
            String connString = @"Server=DESKTOP-LRHKKSS;Database=SSADATABASE;User Id=sa;Password=Linh2001";
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
        public USER(string arg)
        {
            Connect Data = new Connect();
            Data.OpenConnection();

            SqlCommand command = Data.CreateSQLCmd("select FULLNAME from USERS where ID_USER='" + arg + "'");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                this.sName = reader.GetString(0);
            }
            Data.CloseConnection();
            this.sID = this.sPassword = this.sGender = this.sEmail = this.sClass = "";
            this.Birth = DateTime.Today;
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
        public int CheckEmail()
        {
            string sCheckLogin = "SELECT EMAIL FROM USERS WHERE EMAIL = '" + this.sEmail + "'";
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                return 0;
            else
                return 1;
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

        public int UpdateUserInfo(string id, string[] newInfo)
        {
            Connect UpdateInfo = new Connect();
            try
            {
                UpdateInfo.OpenConnection();
                string sUpdateData = "UPDATE USERS " +
                    "                 SET BIRTH='" + newInfo[1] + "' , FULLNAME='" + newInfo[0] +
                                        "' , GENDER='" + newInfo[2] + "' , CLASSNAME='" + newInfo[3] +
                                   "' WHERE ID_USER='" + id + "'";

                SqlCommand UpdateCommand = UpdateInfo.CreateSQLCmd(sUpdateData);
                UpdateCommand.ExecuteNonQuery();
                UpdateInfo.CloseConnection();
                return 1;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                UpdateInfo.CloseConnection();
            }
            return 0;
        }

        public void AddUserToDatabase()
        {
            try
            {
                string sCheckLogin = "INSERT INTO USERS VALUES('" + this.ID + "', '" + this.Email + "', '" + this.Birth.ToShortDateString() + "', '" +
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
        public void GetDeadlineID(ref string i)
        {
            string Query = "SELECT TOP (1) * FROM DEADLINE ORDER BY ID DESC";
            //try
            // {
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(Query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                i = (int.Parse(reader.GetString(0)) + 1).ToString();
            }
            //this.Connection.CloseConnection();
            // i = "1";
            /*
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
                this.Connection.CloseConnection();
                i = "-1";
            }
            */
            this.Connection.CloseConnection();
        }

        public void SetDataDefault()
        {
            try
            {
                string Query = "delete from DEADLINE where ID = '" + this.ID + "'";
                Query += "delete from LESSON where ID_USER = '" + this.ID + "'";
                Query += "delete from TABLESCORE where ID_USER = '" + this.ID + "'";
                Query += "delete from SEMESTER where ID = '" + this.ID + "'";
                Query += "delete from SUBJECTS where ID = '" + this.ID + "'";

                Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
                Connection.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void DeleteUser()
        {
            try
            {
                string Query = "delete from USERS where ID_USER = '" + this.ID + "'";


                Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
