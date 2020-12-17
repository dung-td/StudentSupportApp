using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentSupportApp
{
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
            try
            {
                Data.OpenConnection();

                SqlCommand command = Data.CreateSQLCmd("select FULLNAME, EMAIL from USERS where ID_USER='" + arg + "'");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.sName = reader.GetString(0);
                    this.sEmail = reader.GetString(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                Data.CloseConnection();
            }
            this.sID = this.sPassword = this.sGender =  this.sClass = "";
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                Connection.CloseConnection();
            }
            return 1;
        }
        public int CheckLogin()
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
            return 0;
        }
        public void LoadUserInfo()
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        public int UpdateUserInfo(string id, string[] newInfo)
        {
            Connect UpdateInfo = new Connect();
            try
            {
                UpdateInfo.OpenConnection();
                string sUpdateData = "UPDATE USERS " +
                    "                 SET BIRTH='" + newInfo[1] + "' , FULLNAME=N'" + newInfo[0] +
                                        "' , GENDER=N'" + newInfo[2] + "' , CLASSNAME=N'" + newInfo[3] +
                                   "' WHERE ID_USER='" + id + "'";

                SqlCommand UpdateCommand = UpdateInfo.CreateSQLCmd(sUpdateData);
                UpdateCommand.ExecuteNonQuery();
                UpdateInfo.CloseConnection();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
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
                Form temp = new Form();
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(temp, ex);
                rp.Show();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        public void GetDeadlineID(ref string i)
        {
            string Query = "SELECT TOP (1) * FROM DEADLINE ORDER BY ID DESC";
            try
            {
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    i = (int.Parse(reader.GetString(0)) + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                Connection.CloseConnection();
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
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
    }
}
