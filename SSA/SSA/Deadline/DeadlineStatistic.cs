using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace StudentSupportApp
{
    public partial class DeadlineStatistic : Form
    {
        MainForm parent;
        string ID_User;
        Connect Connection;
        string TimeCondition;
        string[] Queries = new string[3];
        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }
        public DeadlineStatistic(MainForm parent, string ID_User)
        {
            try
            {
                Connection = new Connect();
                this.parent = parent;
                this.ID_User = ID_User;
                TimeCondition = " AND DATEDIFF(DAY, DATESUBMIT, GETDATE()) <= 30";
                UpdateTimeCondition();
                InitializeComponent();

                SetColor(Properties.Settings.Default.Color);
                chartStatistic.Titles.Add("THỐNG KÊ DEADLINE THEO MÔN HỌC");
                DeadlineStatisticBySubject(Queries[0], "Số lượng deadline");
                DeadlineStatisticBySubject(Queries[1], "Số deadline đã hoàn thành");
                DeadlineStatisticBySubject(Queries[2], "Số deadline chưa hoàn thành");

                int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
                style |= NativeWinAPI.WS_EX_COMPOSITED;
                NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }
        void DeadlineStatisticBySubject(string Query, string Series)
        {
            try
            {
                Connection.OpenConnection();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    if (!reader.Read())
                        break;
                    chartStatistic.Series[Series].Points.AddXY(reader.GetString(0), reader.GetInt32(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void cb1_OnChange(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
            {
                DeadlineStatisticBySubject(Queries[1], "Số deadline đã hoàn thành");
            }
            else
            {
                chartStatistic.Series["Số deadline đã hoàn thành"].Points.Clear();
            }
        }

        private void cb2_OnChange(object sender, EventArgs e)
        {
            if (cb2.Checked == true)
            {
                DeadlineStatisticBySubject(Queries[2], "Số deadline chưa hoàn thành");
            }
            else
            {
                chartStatistic.Series["Số deadline chưa hoàn thành"].Points.Clear();
            }
        }
        private void UpdateTimeCondition()
        {
            Queries[0] = "SELECT SUB_NAME, COUNT(ID) SL FROM DEADLINE WHERE ID_USER = '" + ID_User + "'" + TimeCondition + " GROUP BY SUB_ID, SUB_NAME";
            Queries[1] = "SELECT SUB_NAME, COUNT(ID) SL FROM DEADLINE WHERE STATU = 100 AND ID_USER='" + ID_User + "'" + TimeCondition + " GROUP BY SUB_ID, SUB_NAME";
            Queries[2] = "SELECT SUB_NAME, COUNT(ID) SL FROM DEADLINE WHERE STATU < 100 AND ID_USER='" + ID_User + "'" + TimeCondition + " GROUP BY SUB_ID, SUB_NAME";
        }
        private void Reload()
        {
            chartStatistic.Series["Số deadline chưa hoàn thành"].Points.Clear();
            chartStatistic.Series["Số deadline đã hoàn thành"].Points.Clear();
            chartStatistic.Series["Số lượng deadline"].Points.Clear();
            DeadlineStatisticBySubject(Queries[0], "Số lượng deadline");
            DeadlineStatisticBySubject(Queries[1], "Số deadline đã hoàn thành");
            DeadlineStatisticBySubject(Queries[2], "Số deadline chưa hoàn thành");
            cb1.Checked = true;
            cb2.Checked = true;
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTime.Text)
            {
                case "Ngày qua":
                    TimeCondition = " AND DATEDIFF(MINUTE, DATESUBMIT, GETDATE()) <= 1440";
                    break;
                case "Tuần qua":
                    TimeCondition = " AND DATEDIFF(DAY, DATESUBMIT, GETDATE()) <= 7";
                    break;
                case "Tháng qua (Mặc định)":
                    TimeCondition = " AND DATEDIFF(DAY, DATESUBMIT, GETDATE()) <= 30";
                    break;
                case "Năm qua":
                    TimeCondition = " AND DATEDIFF(DAY, DATESUBMIT, GETDATE()) <= 365";
                    break;
                case "Tất cả":
                    TimeCondition = "";
                    break;
            }
            UpdateTimeCondition();
            Reload();
        }
        void SetColor(Color x)
        {
            this.panel1.BackColor =
                bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleLineColor = bExit.IdleForecolor = bExit.ActiveLineColor = x;
        }
    }
}
