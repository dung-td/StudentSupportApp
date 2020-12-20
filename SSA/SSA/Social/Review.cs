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
                string Query = "INSERT INTO REVIEW VALUES(" + ID.ToString() + ", '" + SubjectID + "', '" + Subject + "', '" + ID_User + "', '" + Details + "', " + Like + ", " + Dislike + ", " + Report + ", '" + Date + "')";
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
        public void DeleteReview()
        {
            try
            {
                Connection.OpenConnection();
                string Query = "";
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
        public void UpdateReviewInfo()
        {
            try
            {
                Connection.OpenConnection();
                string Query = @"UPDATE REVIEW SET SubjectID='" + SubjectID + "', Subject='" + Subject + "', Details='" + Details + "', Date_ ='" + Date + "' WHERE ID=" + ID.ToString();
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
        public void UpdateLike()
        {
            try
            {
                Connection.OpenConnection();
                string Query = @"UPDATE REVIEW SET Likes = Likes + 1 WHERE ID=" + ID.ToString();
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
        public void UpdateDislike()
        {
            try
            {
                Connection.OpenConnection();
                string Query = @"UPDATE REVIEW SET Dislikes= Dislikes + 1 WHERE ID=" + ID.ToString();
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
            string Query = "UPDATE REVIEW SET SujectID='" + SubjectID + "' Subject='" + Subject + "' Details='" + Details + "' Date_='" + Date + "' WHERE ID='" + ID + "'";
            try
            {
                this.Connection.OpenConnection();
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
        //public void GetReviewInfomation()
        //{
        //    try
        //    {
        //        Connection.OpenConnection();
        //        string Query = "";
        //        SqlCommand cmd = Connection.CreateSQLCmd(Query);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.HasRows)
        //        {
        //            if (!reader.Read())
        //            {
        //                ID = reader.GetInt32(0);
        //                SubjectID = reader.GetString(1);
        //                Subject = reader.GetString(2);
        //                ID_User = reader.GetString(3);
        //                Details = reader.GetString(4);
        //                Like = reader.GetInt32(5);
        //                Dislike = reader.GetInt32(6);
        //                Report = reader.GetInt32(7);
        //                Date = reader.GetDateTime(8);
        //            }
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    finally
        //    {
        //        Connection.CloseConnection();
        //    }
        //}
    }
}
