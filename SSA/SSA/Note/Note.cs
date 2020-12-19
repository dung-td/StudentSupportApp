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
        int iWidth;
        int iHeight;
        Connect connection;

        public Note(string id)
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

        public int Width
        {
            get => iWidth;
            set => iWidth = value;
        }

        public int Height
        {
            get => iHeight;
            set => iHeight = value;
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
                    else break;
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

        public void LoadNoteData()
        {
            try
            {
                connection = new Connect();
                string sQuery = "SELECT * FROM NOTE WHERE ID_USER='" + UserID + "' AND NOTE_NAME=N'" + Name + "'";
                connection.OpenConnection();

                SqlCommand command = connection.CreateSQLCmd(sQuery);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        Detail = reader.GetString(1);
                        Width = reader.GetInt16(3);
                        Height = reader.GetInt16(4);
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
        }

        public void AddNoteToDatabase()
        {
            try
            {
                connection = new Connect();
                if (CheckExistName() == false)
                {
                    string sQuery = "INSERT INTO NOTE VALUES(N'" + Name + "', N'" + Detail + "', '" + UserID + "', " + Width + ", " + Height + ")";
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

        public void UpdateNoteInfo(string oldName)
        {
            try
            {
                connection = new Connect();
                if (CheckExistName() == false || (CheckExistName() == true && oldName == Name))
                {
                    string sQuery = "UPDATE NOTE SET NOTE_NAME=N'" + Name + "', NOTE_DETAIL=N'" + Detail + "' , NOTE_WIDTH=" + Width + ", NOTE_HEIGHT=" + Height + 
                                    " WHERE NOTE_NAME=N'" + oldName + "' AND ID_USER='" + UserID + "'";
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

        public void DeleleNoteFromDatabase(string name)
        {
            try
            {
                connection = new Connect();
                string sQuery = "DELETE NOTE WHERE NOTE_NAME=N'" + name + "' AND ID_USER='" + UserID + "'";
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
