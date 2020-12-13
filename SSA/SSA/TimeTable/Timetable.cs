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
        List<string> sLesson = new List<string> { };

        public Timetable(string ID, string Semester)
        {
            user.ID = ID;
            this.sSemester = Semester;
        }

        public Timetable()
        {
            sSemester = "1";
        }

        public string Semester
        {
            get { return this.sSemester; }
            set { this.sSemester = value; }
        }

        public void LoadUserTimetable()
        {
            Connect loadTimetable = new Connect();
            try
            {
                loadTimetable.OpenConnection();

                string[] sWeekDay = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                for (int j = 0; j < 7; j++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        string sLoadData = "select SUB_NAME, SUB_ID from LESSON where ID_USER='" + this.user.ID
                                         + "' AND DAYINWEEK='" + sWeekDay[j] + "' AND SEM_NAME=N'"
                                         + this.sSemester + "' AND TIMEORDER=" + i;
                        SqlCommand loadDay = loadTimetable.CreateSQLCmd(sLoadData);
                        SqlDataReader reader = loadDay.ExecuteReader();
                        if (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                break;
                            }
                            sLesson.Add(reader.GetString(0) + "\n" + reader.GetString(1));
                        }
                        else sLesson.Add("");
                        reader.Close();
                    }
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
                loadTimetable.CloseConnection();
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

        public int AddLessonToDatabase(string[] args)
        {
            Connect AddLesson = new Connect();
            try
            {
                AddLesson.OpenConnection();
                string sAddData = "INSERT INTO LESSON VALUES('" + args[0] + "', " + args[1] + ", '" + args[2]
                                                           + "', N'" + args[3] + "', N'" + args[4] + "', '" + args[5] + "', null)";
                if (CheckExistSemester(args[4]) == 0)
                {
                    string sAddSem = "INSERT INTO SEMESTER VALUES('" + args[5] + "', N'" + args[4] + "')";
                    SqlCommand AddCommand2 = AddLesson.CreateSQLCmd(sAddSem);
                    AddCommand2.ExecuteNonQuery();
                }
                SqlCommand AddCommand1 = AddLesson.CreateSQLCmd(sAddData);
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
                AddLesson.CloseConnection();
            }
            return 0;
        }

        public int UpdateLessonInfo(string[] oldInfo, string[] newInfo)
        {
            Connect ModLesson = new Connect();

            try
            {
                ModLesson.OpenConnection();
                string sUpdateData = "UPDATE LESSON " +
                    "              SET DAYINWEEK='" + newInfo[0] + "' , TIMEORDER=" + newInfo[1] +
                                        " , SUB_ID='" + newInfo[2] + "' , SUB_NAME=N'" + newInfo[3] +
                                        "' , SEM_NAME=N'" + newInfo[4] +
                                   "' WHERE ID_USER='" + oldInfo[5] + "' AND DAYINWEEK='" + oldInfo[1] +
                                                    "' AND TIMEORDER=" + oldInfo[4] + " AND SUB_ID='" + oldInfo[3].Remove(0, 1) +
                                                    "' AND SUB_NAME=N'" + oldInfo[2] + "' AND SEM_NAME=N'" + oldInfo[0] + "'";

                SqlCommand UpdateCommand = ModLesson.CreateSQLCmd(sUpdateData);
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
                ModLesson.CloseConnection();
            }
            return 0;
        }

        public int CheckExistSemester(string input)
        {
            Connect Check = new Connect();
            try
            {
                Check.OpenConnection();

                SqlCommand command = Check.CreateSQLCmd("select distinct SEM_NAME from SEMESTER where ID='" + this.user.ID + "'");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    if (reader.GetString(0) == input) return 1;
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
                Check.CloseConnection();
            }
            return 0;
        }

        public bool CheckExistLesson(string sem, string diw, string time, string userID)
        {
            Connect check = new Connect();
            try
            {
                diw = SwitchVietnameseDayToEnglish(diw);
                check.OpenConnection();
                string sLoadData = "select * from LESSON where SEM_NAME=N'" + sem
                                             + "' AND DAYINWEEK='" + diw + "' AND ID_USER = '" + userID + "' AND TIMEORDER=" + time;
                SqlCommand loadInfo= check.CreateSQLCmd(sLoadData);
                SqlDataReader reader = loadInfo.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
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
                check.CloseConnection();
            }
            return false;
        }

        private string SwitchVietnameseDayToEnglish(string today)
        {
            if (today == "Thứ hai")
                return "Monday";
            else if (today == "Thứ ba")
                return "Tuesday";
            else if (today == "Thứ tư")
                return "Wednesday";
            else if (today == "Thứ năm")
                return "Thursday";
            else if (today == "Thứ sáu")
                return "Friday";
            else if (today == "Thứ bảy")
                return "Saturday";
            else return "Sunday nhật";
        }
    }
}
