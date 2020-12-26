using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class Review
    {
        int ID;
        string SubjectID;
        string Subject;
        string ID_User;
        string Details;
        int Like;
        int Dislike;
        int Report;
        DateTime Date;
        Connect Connection = new Connect();
        public Review()
        {
            ID = Like = Dislike = Report = 0;
            Subject = SubjectID = ID_User = Details = "Không có dữ liệu!";
            Date = DateTime.Now;
        }
        public Review(string[] args, int[] num, DateTime date)
        {
            SubjectID = args[0];
            Subject = args[1];
            ID_User = args[2];
            Details = args[3];
            ID = num[0];
            Like = num[1];
            Dislike = num[2];
            Report = num[3];
            Date = date;
        }
        public int _ID
        {
            get => ID;
            set => ID = value;
        }
        public string _SubjectID
        {
            get => SubjectID;
            set => SubjectID = value;
        }
        public string _Subject
        {
            get => Subject;
            set => Subject = value;
        }
        public string _ID_User
        {
            get => ID_User;
            set => ID_User = value;
        }
        public string _Details
        {
            get => Details;
            set => Details = value;
        }
        public int _Like
        {
            get => Like;
            set => Like = value;
        }
        public int _Dislike
        {
            get => Dislike;
            set => Dislike = value;
        }
        public int _Report
        {
            get => Report;
            set => Report = value;
        }
        public DateTime _Date
        {
            get => Date;
            set => Date = value;
        }
        public void AddReviewToDatabase()
        {
            try
            {
                Connection.OpenConnection();
                string Query = "INSERT INTO REVIEW VALUES(" + ID.ToString() + ", N'" + SubjectID + "', N'" + Subject + "', '" + ID_User + "', N'" + Details + "', " + Like + ", " + Dislike + ", " + Report + ", '" + Date + "')";
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm bài viết thành công!");
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
        public void UpdateReviewInfo()
        {
            try
            {
                Connection.OpenConnection();
                string Query = @"UPDATE REVIEW SET SubjectID='" + SubjectID + "', Subject=N'" + Subject + "', Details=N'" + Details + "', Date_ ='" + Date + "' WHERE ID=" + ID.ToString();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                cmd.ExecuteNonQuery();
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
        public void SetLike()
        {
            try
            {
                Connection.OpenConnection();
                string Query = @"UPDATE REVIEW_DETAIL SET STAT = 1 WHERE RV_ID=" + ID.ToString();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                cmd.ExecuteNonQuery();
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
        public void SetDislike()
        {
            try
            {
                Connection.OpenConnection();
                string Query = @"UPDATE REVIEW_DETAIL SET STAT = 2 WHERE RV_ID=" + ID.ToString();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                cmd.ExecuteNonQuery();
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
        public void SetReset()
        {
            try
            {
                Connection.OpenConnection();
                string Query = @"UPDATE REVIEW_DETAIL SET STAT = 0 WHERE RV_ID=" + ID.ToString();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                cmd.ExecuteNonQuery();
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
        public void UpdateReport()
        {
            try
            {
                Connection.OpenConnection();
                string Query = @"UPDATE REVIEW SET Reports= Reports + 1 WHERE ID=" + ID.ToString();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                cmd.ExecuteNonQuery();
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
        public void FirstReact(string ID_User, int i)
        {
            try
            {
                Connection.OpenConnection();
                string Query = "INSERT INTO REVIEW_DETAIL VALUES(" + ID.ToString() +",'" + ID_User + "', " + i.ToString() + ")";
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                cmd.ExecuteNonQuery();
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
        public void GetReviewID(ref int i)
        {
            string Query = "SELECT TOP (1) * FROM REVIEW ORDER BY ID DESC";
            try
            {
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    i = reader.GetInt32(0) + 1;
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
        public void ModifyReview()
        {
            string Query = "UPDATE REVIEW SET SubjectID=N'" + SubjectID + "', Subject_=N'" + Subject + "', Details=N'" + Details + "', Date_='" + Date + "' WHERE ID='" + ID + "'";
            try
            {
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công!");
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
        public int CheckStatus(string ID_User)
        {
            int temp = -1;
            string Query = "SELECT * FROM REVIEW_DETAIL WHERE RV_ID=" + ID.ToString() + "AND ID_User = '" + ID_User + "'";
            try
            {
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    temp = reader.GetInt32(2);
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
            return temp;
        }
        public void DeleteReview()
        {
            string Query = "DELETE FROM REVIEW WHERE ID=" + ID.ToString();
            try
            {
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa bài viết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
