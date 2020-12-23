using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class Timetable
    {
        USER user = new USER();
        private string sSemester;
        Connect connection;
        string[] sLesson = new string[70];
        string[] sTodayLesson = new string[10];

        public Timetable(string ID, string Semester)
        {
            user.ID = ID;
            this.sSemester = Semester;
            connection = new Connect();

            for (int i = 0; i < sLesson.Length; i++)
            {
                sLesson[i] = "";
                if (i < 10)
                {
                    sTodayLesson[i] = "";
                }
            }
        }

        public Timetable(string id)
        {
            sSemester = "1";
            this.user.ID = id;
            connection = new Connect();

            for (int i = 0; i < sLesson.Length; i++)
            {
                sLesson[i] = "";
                if (i < 10)
                {
                    sTodayLesson[i] = "";
                }
            }
        }

        public Timetable()
        {
            sSemester = "1";
            connection = new Connect();
        }

        public string Semester
        {
            get { return this.sSemester; }
            set { this.sSemester = value; }
        }

        public void LoadUserTimetable()
        {
            try
            {
                connection.OpenConnection();

                string sLoadData = "select SUB_NAME, SUB_ID, DAYINWEEK, TIMEORDER " +
                                   "from LESSON " +
                                   "where ID_USER='" + this.user.ID + "' AND SEM_NAME=N'" + this.sSemester + "' " +
                                   "order by DAYINWEEK ASC, TIMEORDER ASC";
                SqlCommand loadDay = connection.CreateSQLCmd(sLoadData);
                SqlDataReader reader = loadDay.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }
                    string data = reader.GetString(0) + "\n" + reader.GetString(1);
                    int index = ((Int32.Parse(reader.GetString(2)) - 2) * 10) + (Int32.Parse(reader.GetInt32(3).ToString()) - 1);

                    sLesson[index] = data;
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

        public void LoadTodayTimetable(string today)
        {
            try
            {
                connection.OpenConnection();

                int iWeekDay = SwitchDayToNumber(today);
                string sLoadData = "select SUB_NAME, TIMEORDER from LESSON where ID_USER='" + this.user.ID
                                    + "' AND DAYINWEEK=" + iWeekDay.ToString() + " AND SEM_NAME=N'" + this.sSemester + "'";

                SqlCommand loadDay = connection.CreateSQLCmd(sLoadData);
                SqlDataReader reader = loadDay.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }
                    else
                    {
                        string data = reader.GetString(0);
                        int index = Int32.Parse(reader.GetInt32(1).ToString()) - 1;

                        sTodayLesson[index] = data;
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

        public void LoadTimetableToDGV(DataGridView obj)
        {
            try
            {
                int iLessonIndex = 0;
                for (int j = 1; j <= 7; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        obj.Rows[i].Cells[j].Value = sLesson[iLessonIndex];
                        iLessonIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
        }

        public void LoadTimetableToHomeDGV(DataGridView obj)
        {
            try
            {
                int iLessonIndex = 0;
                for (int i = 0; i < 10; i++)
                {
                    obj.Rows[i].Cells[1].Value = sTodayLesson[iLessonIndex];
                    iLessonIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
        }

        public int AddLessonToDatabase(string[] args)
        {
            try
            {
                string sAddData = "";
                args[0] = SwitchDayToNumber(args[0]).ToString();
                for (int i = 0; i <= int.Parse(args[2]) - int.Parse(args[1]); i++)
                {
                    sAddData += "INSERT INTO LESSON VALUES(" + args[0] + ", " + (int.Parse(args[1]) + i).ToString() + ", '" + args[3]
                                                            + "', N'" + args[4] + "', N'" + args[5] + "', '" + args[6] + "', null)\n";
                }

                connection.OpenConnection();

                if (CheckExistSemester(args[5]) == 0)
                {
                    string sAddSem = "INSERT INTO SEMESTER VALUES('" + args[6] + "', N'" + args[5] + "')";
                    SqlCommand AddCommand2 = connection.CreateSQLCmd(sAddSem);
                    AddCommand2.ExecuteNonQuery();
                }
                SqlCommand AddCommand1 = connection.CreateSQLCmd(sAddData);
                AddCommand1.ExecuteNonQuery();
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
                connection.CloseConnection();
            }
            return 0;
        }

        public int UpdateLessonInfo(string[] oldInfo, string[] newInfo)
        {
            try
            {
                connection.OpenConnection();
                string sUpdateData = "UPDATE LESSON " +
                    "              SET DAYINWEEK=" + newInfo[0] + " , TIMEORDER=" + newInfo[1] +
                                        " , SUB_ID='" + newInfo[2] + "' , SUB_NAME=N'" + newInfo[3] +
                                        "' , SEM_NAME=N'" + newInfo[4] +
                                   "' WHERE ID_USER='" + oldInfo[5] + "' AND DAYINWEEK=" + oldInfo[1] +
                                                    " AND TIMEORDER=" + oldInfo[4] + " AND SUB_ID='" + oldInfo[3].Remove(0, 1) +
                                                    "' AND SUB_NAME=N'" + oldInfo[2] + "' AND SEM_NAME=N'" + oldInfo[0] + "'";

                SqlCommand UpdateCommand = connection.CreateSQLCmd(sUpdateData);
                UpdateCommand.ExecuteNonQuery();
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
                connection.CloseConnection();
            }
            return 0;
        }

        public int RemoveLesson(List<string> lessonInfo)
        {
            try
            {
                connection.OpenConnection();
                string sRemove = "DELETE LESSON " +
                                 "WHERE ID_USER='" + lessonInfo[5] + "' AND DAYINWEEK=" + lessonInfo[1] +
                                                    " AND TIMEORDER=" + lessonInfo[4] + " AND SUB_ID='" + lessonInfo[3].Remove(0, 1) +
                                                    "' AND SUB_NAME=N'" + lessonInfo[2] + "' AND SEM_NAME=N'" + lessonInfo[0] + "'";

                SqlCommand RemoveCommand = connection.CreateSQLCmd(sRemove);
                RemoveCommand.ExecuteNonQuery();
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
                connection.CloseConnection();
            }
            return 0;
        }

        public int RemoveTimetable()
        {
            try
            {
                connection.OpenConnection();
                string sRemove = "DELETE LESSON " +
                                 "WHERE ID_USER='" + this.user.ID + "' AND SEM_NAME=N'" + this.sSemester + "'";

                SqlCommand RemoveCommand = connection.CreateSQLCmd(sRemove);
                RemoveCommand.ExecuteNonQuery();
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
                connection.CloseConnection();
            }
            return 0;
        }

        public int CheckExistSemester(string input)
        {
            try
            {
                string sQuery = "select distinct SEM_NAME from SEMESTER where ID='" + this.user.ID + "'";
                SqlCommand command = connection.CreateSQLCmd(sQuery);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        reader.Close();
                        break;
                    }
                    if (reader.GetString(0) == input)
                    {
                        reader.Close();
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            return 0;
        }

        public bool CheckExistLesson(string sem, string diw, string timebegin, string timeend, string userID)
        {
            try
            {
                diw = SwitchDayToNumber(diw).ToString();
                string sLoadData = "";
                connection.OpenConnection();

                if (int.Parse(timebegin) == int.Parse(timeend))
                {
                    sLoadData = "select * from LESSON where SEM_NAME=N'" + sem
                                                 + "' AND DAYINWEEK='" + diw + "' AND ID_USER = '" + userID + "' AND TIMEORDER=" + timebegin;
                }
                else
                {
                    sLoadData = "select * from LESSON where SEM_NAME=N'" + sem
                                                 + "' AND DAYINWEEK='" + diw + "' AND ID_USER = '" + userID + "' AND " + timebegin + " <= TIMEORDER AND TIMEORDER <= " + timeend;
                }

                SqlCommand loadInfo = connection.CreateSQLCmd(sLoadData);
                SqlDataReader reader = loadInfo.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
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

        public int SwitchDayToNumber(string today)
        {
            if (today == "Thứ hai")
                return 2;
            else if (today == "Thứ ba")
                return 3;
            else if (today == "Thứ tư")
                return 4;
            else if (today == "Thứ năm")
                return 5;
            else if (today == "Thứ sáu")
                return 6;
            else if (today == "Thứ bảy")
                return 7;
            else return 8;
        }

        public int SwitchDayWithNumberToNumber(string today)
        {
            if (today == "Thứ 2")
                return 2;
            else if (today == "Thứ 3")
                return 3;
            else if (today == "Thứ 4")
                return 4;
            else if (today == "Thứ 5")
                return 5;
            else if (today == "Thứ 6")
                return 6;
            else if (today == "Thứ 7")
                return 7;
            else return 8;
        }
    }
}