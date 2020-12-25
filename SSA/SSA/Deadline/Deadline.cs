using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class Deadlines
    {
        string sID;
        DateTime dtTimeSubmit;
        string sSubject;
        string sSubjectCode;
        string sDetails;
        string sID_User;
        string bStatus;
        int iProgress;
        Connect Connection = new Connect();
        public Deadlines()
        {
            sID = "00000";
            dtTimeSubmit = DateTime.Today;
            sSubject = "Nhap Mon Lap Trinh";
            sSubjectCode = "IT001.K15";
            sDetails = "Nop bai NMLT!";
            bStatus = "Da nop bai";
            sID_User = "";
            iProgress = 0;
        }
        public Deadlines(string[] args)
        {
            sID = args[0];
            sSubjectCode = args[1];
            sSubject = args[2];
            sDetails = args[3];
            dtTimeSubmit = DateTime.Parse(args[4]);
            bStatus = args[5];
            sID_User = args[6];
            iProgress = int.Parse(args[7]);
        }
        public string ID
        {
            get
            {
                return sID;
            }
            set
            {
                this.sID = value;
            }
        }
        public DateTime TimeSubmit
        {
            get
            {
                return dtTimeSubmit;
            }
            set
            {
                dtTimeSubmit = value;
            }
        }
        public string Subject
        {
            get
            {
                return sSubject;
            }
            set
            {
                this.sSubject = value;
            }
        }
        public string SubjectCode
        {
            get
            {
                return sSubjectCode;
            }
            set
            {
                this.sSubjectCode = value;
            }
        }
        public string Details
        {
            get
            {
                return sDetails;
            }
            set
            {
                this.sDetails = value;
            }
        }
        public string ID_User
        {
            get => sID_User;
            set => sID_User = value;
        }
        public string Status
        {
            get
            {
                return bStatus;
            }
            set
            {
                this.bStatus = value;
            }
        }
        public int Progress
        {
            get => iProgress;
            set => iProgress = value;
        }
        public void Delete()
        {
            try
            {
                this.Connection.OpenConnection();
                string Query = "DELETE FROM DEADLINE WHERE ID ='" + sID + "'";
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
                this.Connection.CloseConnection();
            }
        }
        public void AddDeadline()
        {
            try
            {
                
                ID = "1";
                this.GetDeadlineID(ID);
                iProgress = 0;
                this.Connection.OpenConnection();
                string Query = "INSERT INTO DEADLINE VALUES('" + ID + "', N'" + Subject + "', '" + SubjectCode + "', N'" +
                                                                Details + "', '" + dtTimeSubmit + "', N'" + Status + "', '" + ID_User + "', " + iProgress + ")";
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
                this.Connection.CloseConnection();
            }
        }
        public void GetDeadlineID(string i)
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
                reader.Close();
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
    }
}
