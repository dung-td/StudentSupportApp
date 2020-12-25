using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class AddLessonForm : Form
    {
        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        MainForm parent;
        private string sUserID;

        public AddLessonForm()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        public AddLessonForm(MainForm parent, string ID, string semester)
        {
            this.parent = parent;
            this.sUserID = ID;
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            this.tbxSemNaAL.Text = semester;
            SetColor(Properties.Settings.Default.Color);
        }

        #region EventHandler
        private void btnAddAL_Click(object sender, EventArgs e)
        {
            List<string> sDayInWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            try
            {
                if (cbxDIWAL.Text != "" && cbxTimeOrderBegin.Text != "" && tbxSemNaAL.Text != "" && tbxSubIDAL.Text != "" && tbxSubNaAL.Text != "" && cbxTimeOrderEnd.Text != "")
                {
                    Timetable lesson = new Timetable(this.sUserID);
                    if (lesson.CheckExistLesson(tbxSemNaAL.Text, cbxDIWAL.Text, cbxTimeOrderBegin.Text, cbxTimeOrderEnd.Text, this.sUserID) == false)
                    {
                        string[] sData = new string[] { cbxDIWAL.Items[cbxDIWAL.SelectedIndex].ToString(), cbxTimeOrderBegin.Text, cbxTimeOrderEnd.Text, tbxSubIDAL.Text, tbxSubNaAL.Text, tbxSemNaAL.Text, this.sUserID };
                        if (lesson.AddLessonToDatabase(sData) == 1)
                            MessageBox.Show("Thêm tiết học mới thành công!", "Thêm tiết học mới");
                        else MessageBox.Show("Thêm tiết học thất bại. Vui lòng kiểm tra và thử lại!", "Thêm tiết học mới");
                    }
                    else MessageBox.Show("Thời gian muốn thêm đã có tiết học. Vui lòng kiểm tra và thử lại!", "Thêm tiết học mới");
                }
                else if (cbxDIWAL.Text == "" || cbxTimeOrderBegin.Text == "" || tbxSemNaAL.Text == "" || tbxSubIDAL.Text == "" || tbxSubNaAL.Text == "" || cbxTimeOrderEnd.Text == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin và thử lại!", "Thêm tiết học mới");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        private void btnExitAL_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parent.Show();
            this.parent.ReadSchedulesSemesterComboboxItems();
        }

        private void AddLessonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
            this.parent.ReadSchedulesSemesterComboboxItems();
            this.Hide();
        }

        private void tbxSemNaAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxDIWAL.Focus();
        }

        private void cbxDIWAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxSubNaAL.Focus();
        }

        private void tbxSubNaAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxSubIDAL.Focus();
        }

        private void tbxSubIDAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxTimeOrderBegin.Focus();
        }

        private void cbxTimeOrderBegin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTimeOrderEnd.Items.Clear();
            for (int i = cbxTimeOrderBegin.SelectedIndex + 1; i <= 10; i++)
            {
                cbxTimeOrderEnd.Items.Add(i);
            }
        }

        private void cbxTimeOrderBegin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxTimeOrderEnd.Focus();
        }

        private void cbxTimeOrderEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddAL_Click(sender, e);
        }
        #endregion

        void SetColor(Color x)
        {
            GradientPanelAddLesson.BackColor = GradientPanelAddLesson.GradientTopLeft = GradientPanelAddLesson.GradientTopRight
                = GradientPanelAddLesson.GradientBottomLeft = GradientPanelAddLesson.GradientBottomRight =
                tbxSemNaAL.LineFocusedColor = tbxSemNaAL.LineMouseHoverColor =
                tbxSubNaAL.LineFocusedColor = tbxSubNaAL.LineMouseHoverColor =
                tbxSubIDAL.LineFocusedColor = tbxSubIDAL.LineMouseHoverColor =

                  btnAddAL.ActiveFillColor = btnAddAL.ForeColor = btnAddAL.IdleLineColor = btnAddAL.IdleForecolor = btnAddAL.ActiveLineColor =
                    btnExitAL.ActiveFillColor = btnExitAL.ForeColor = btnExitAL.IdleLineColor = btnExitAL.IdleForecolor = btnExitAL.ActiveLineColor = x;
        }
    }
}

