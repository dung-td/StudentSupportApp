using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentSupportApp
{
    class Note
    {
        string sUserID;
        string sNoteName;
        string sNoteDetail;
        Connect connection;

        Note(string id)
        {
            sUserID = id;
            sNoteName = sNoteDetail = "";
        }

        public string Name
        {
            get => sNoteName;
            set => sNoteName = value;
        }

        public string Detail
        {
            get => sNoteDetail;
            set => sNoteDetail = value;
        }

        public string UserID
        {
            get => sUserID;
            set => sUserID = value;
        }

        private bool CheckExistName()
        {
            try
            {
                connection = new Connect();
                string sQuery = "SELECT NOTE_NAME FROM NOTE WHERE ID_USER='" + UserID + "'";
                connection.OpenConnection();

                SqlCommand loadName = connection.CreateSQLCmd(sQuery);
                SqlDataReader reader = loadName.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        if (Name == reader.GetString(0))
                            return true;
                    }
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
                connection.CloseConnection();
            }
            return false;
        }

        private void AddNoteToDatabase()
        {
            try
            {
                connection = new Connect();
                if (CheckExistName() == false)
                {
                    string sQuery = "INSERT INTO NOTE VALUES(N'" + Name + "', N'" + Detail + "', '" + UserID + "')";
                    connection.OpenConnection();

                    SqlCommand addCommand = connection.CreateSQLCmd(sQuery);
                    addCommand.ExecuteNonQuery();
                    MessageBox.Show("Tạo ghi chú mới thành công!", "Tạo ghi chú mới");
                }
                else
                {
                    MessageBox.Show("Tên của ghi chú đã tồn tại. Vui lòng đặt tên khác!", "Tạo ghi chú mới");
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
                connection.CloseConnection();
            }
        }

        private void UpdateNoteInfo(string oldName)
        {
            try
            {
                connection = new Connect();
                if (CheckExistName() == false)
                {
                    string sQuery = "UPDATE NOTE SET NOTE_NAME=N'" + Name + "' AND NOTE_DETAIL=N'" + Detail + "' WHERE NOTE_NAME=N'" + oldName + "'";
                    connection.OpenConnection();

                    SqlCommand addCommand = connection.CreateSQLCmd(sQuery);
                    addCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật ghi chú thành công!", "Cập nhật ghi chú");
                }
                else
                {
                    MessageBox.Show("Tên của ghi chú đã tồn tại. Vui lòng đặt tên khác!", "Cập nhật ghi chú");
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
                connection.CloseConnection();
            }
        }

        private void DeleleNoteFromDatabase(string name)
        {
            try
            {
                connection = new Connect();
                string sQuery = "DELETE NOTE WHERE NOTE_NAME=N'" + name + "'";
                connection.OpenConnection();

                SqlCommand addCommand = connection.CreateSQLCmd(sQuery);
                addCommand.ExecuteNonQuery();
                MessageBox.Show("Xóa ghi chú thành công!", "Xóa ghi chú");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
