using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class SemForm : Form
    {
        ListSem data;
        Connect CONNECT;
        MainForm parent;
        string UserID;

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }
        public SemForm()
        {

        }
        public SemForm(MainForm p, string id)
        {
            try
            {
                data = new ListSem();
                CONNECT = new Connect();
                this.UserID = id;
                this.parent = p;

                InitializeComponent();

                int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
                style |= NativeWinAPI.WS_EX_COMPOSITED;
                NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

                data.Read(UserID);
                data.ShowSemToGridView(dtgvSem);
                lSum.Text = "Số tín chỉ: " + data.SumOfCre.ToString();
                lAver.Text = "Điểm TB: " + data.Average.ToString();

                bMod.Visible = bDel.Visible = false;
                data.SEMESTERS.Clear();

                SetColor(Properties.Settings.Default.Color);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
            }
        }

        public void GetValue(string value)
        {
            try
            {
                string sText = value;

                Semester sem = new Semester(sText);

                data.SEMESTERS.Clear();
                data.Read(UserID);
                sem.Add(dtgvSem);

                data.SEMESTERS.Add(sem);

                CONNECT.OpenConnection();
                string sql = "Insert Into SEMESTER(SEM_NAME, ID) values (N'" + value + "', '" + this.UserID + "')";
                SqlCommand command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, e);
                rp.Show();
                this.Hide();
            }
            finally
            {
                CONNECT.CloseConnection();
            }

        }

        public void Modify(string value)
        {
            try
            {
                string s = "";
                foreach (DataGridViewRow row in dtgvSem.SelectedRows)
                {
                    s = row.Cells[0].Value.ToString();
                    row.Cells[0].Value = value;
                }

                data.SEMESTERS.Clear();
                data.Read(UserID);

                CONNECT.OpenConnection();
                string sql = @"UPDATE SEMESTER SET SEM_NAME=N'" + value + "' where SEM_NAME=N'" + s + "' AND ID = '" + this.UserID + "'";
                SqlCommand command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, e);
                rp.Show();
                this.Hide();
            }
            finally
            {
                CONNECT.CloseConnection();
            }
        }

        private void SemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                data.Read(UserID);
                this.parent.AddItemToComboBoxSemester();
                this.parent.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            bExit.Enabled = false;
            this.Close();
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "";
                foreach (DataGridViewRow row in dtgvSem.SelectedRows)
                {
                    s = row.Cells[0].Value.ToString();
                    dtgvSem.Rows.RemoveAt(row.Index);
                }

                data.SEMESTERS.Clear();

                CONNECT.OpenConnection();
                string sql = @"Delete FROM SEMESTER WHERE(SEM_NAME= '" + s + "' and ID='" + this.UserID + "')";
                sql += "Delete FROM TABLESCORE WHERE(SEM_NAME= '" + s + "' and ID_USER='" + this.UserID + "')";
                SqlCommand command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
            }
            finally
            {
                CONNECT.CloseConnection();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {

                this.Hide();
                DiaSem dia = new DiaSem(this, "Nhập tên học kì mới: ");
                dia.getData = new DiaSem.GetData(GetValue);
                dia.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
            }

        }

        private void bMod_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                DiaSem dia = new DiaSem(this, "Chỉnh sửa tên học kì: ");
                dia.getData = new DiaSem.GetData(Modify);
                dia.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
            }
        }

        private void dtgvSem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bDel.Visible = bMod.Visible = true;
        }

        private void dtgvSem_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            bDel.Visible = bMod.Visible = true;
        }

        void SetColor(Color x)
        {
            dtgvSem.HeaderForeColor =
                SemFormPanel.BackColor =
            bAdd.BackColor = bAdd.ActiveFillColor= bAdd.ForeColor = bAdd.IdleForecolor = bAdd.IdleLineColor =
            bMod.BackColor = bMod.ActiveFillColor = bMod.ForeColor = bMod.IdleForecolor = bMod.IdleLineColor =
            bDel.BackColor = bDel.ActiveFillColor = bDel.ForeColor = bDel.IdleForecolor = bDel.IdleLineColor =
            bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleForecolor = bExit.IdleLineColor =
             bStatistic.ActiveFillColor = bStatistic.ForeColor = bStatistic.IdleForecolor = bStatistic.IdleLineColor =
            x;
        }

        private void bStatistic_Click(object sender, EventArgs e)
        {
            ScoreStatistics form = new ScoreStatistics(this, UserID);
            form.Show();
            this.Hide();
        }
    }
}
