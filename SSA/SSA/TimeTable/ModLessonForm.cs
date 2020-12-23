using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class ModLessonForm : Form
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
        private string[] sOldInfo;
        private bool IsTimeChanged;
        private bool IsNameIDChanged;

        public ModLessonForm()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        public ModLessonForm(MainForm parent, List<string> data, string ID)
        {
            try
            {
                InitializeComponent();
                int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
                style |= NativeWinAPI.WS_EX_COMPOSITED;
                NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

                this.parent = parent;
                this.sUserID = ID;
                this.sOldInfo = new string[6];
                if (data.Count > 4)
                {
                    tbxSemNaML.Text = data[0];
                    cbxDIWML.Text = data[1];
                    tbxSubNaML.Text = data[2];
                    tbxSubIDML.Text = data[3];
                    cbxTimeOrderM.Text = data[4];

                    for (int i = 0; i < data.Count; i++)
                    {
                        this.sOldInfo[i] = data[i];
                    }
                    this.sOldInfo[5] = this.sUserID;
                }

                SetColor(Properties.Settings.Default.Color);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        #region EventHandler
        private void btnExitML_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void btnSaveML_Click(object sender, EventArgs e)
        {
            Timetable lesson = new Timetable(this.sUserID);
            try
            {
                if (cbxDIWML.Text != "" && cbxTimeOrderM.Text != "" && tbxSemNaML.Text != "" && tbxSubIDML.Text != "" && tbxSubNaML.Text != "")
                {
                    if (this.IsTimeChanged == true)
                    {
                        if (lesson.CheckExistLesson(tbxSemNaML.Text, cbxDIWML.Text, cbxTimeOrderM.Text, cbxTimeOrderM.Text, this.sUserID) == false)
                        {
                            string[] sData = new string[] { lesson.SwitchDayToNumber(cbxDIWML.Text).ToString(), cbxTimeOrderM.Text, tbxSubIDML.Text.Remove(0, 1), tbxSubNaML.Text, tbxSemNaML.Text, this.sUserID };
                            if (lesson.UpdateLessonInfo(sOldInfo, sData) == 1)
                                MessageBox.Show("Chỉnh sửa thành công!", "Chỉnh sửa thông tin tiết học");
                            else MessageBox.Show("Chỉnh sửa thất bại. Vui lòng kiểm tra và thử lại!", "Chỉnh sửa thông tin tiết học");
                        }
                        else MessageBox.Show("Thời gian muốn sửa đã có tiết học. Vui lòng kiểm tra và thử lại!", "Chỉnh sửa thông tin tiết học");
                    }
                    else if (this.IsTimeChanged == false && this.IsNameIDChanged == true)
                    {
                        string[] sData = new string[] { lesson.SwitchDayToNumber(cbxDIWML.Text).ToString(), cbxTimeOrderM.Text, tbxSubIDML.Text.Remove(0, 1), tbxSubNaML.Text, tbxSemNaML.Text, this.sUserID };
                        if (lesson.UpdateLessonInfo(sOldInfo, sData) == 1)
                            MessageBox.Show("Chỉnh sửa thành công!", "Chỉnh sửa thông tin tiết học");
                        else MessageBox.Show("Chỉnh sửa thất bại. Vui lòng kiểm tra và thử lại!", "Chỉnh sửa thông tin tiết học");
                    }
                }
                else if (cbxDIWML.Text == "" || cbxTimeOrderM.Text == "" || tbxSemNaML.Text == "" || tbxSubIDML.Text == "" || tbxSubNaML.Text == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin và thử lại!", "Chỉnh sửa thông tin tiết học");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        private void tbxSemNaML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxDIWML.Focus();
        }

        private void cbxDIWML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxSubNaML.Focus();
        }

        private void tbxSubNaML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxSubIDML.Focus();
        }

        private void tbxSubIDML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxTimeOrderM.Focus();
        }

        private void cbxTimeOrderM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSaveML_Click(sender, e);
        }

        private void cbxDIWML_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDIWML.SelectedItem.ToString() != this.sOldInfo[1])
                IsTimeChanged = true;
            else IsTimeChanged = false;
        }

        private void cbxTimeOrderM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTimeOrderM.SelectedItem.ToString() != this.sOldInfo[4])
                IsTimeChanged = true;
            else IsTimeChanged = false;
        }

        private void tbxSubNaML_OnValueChanged(object sender, EventArgs e)
        {
            if (tbxSubNaML.Text != this.sOldInfo[2])
                this.IsNameIDChanged = true;
            else this.IsNameIDChanged = false;
        }

        private void tbxSubIDML_OnValueChanged(object sender, EventArgs e)
        {
            if (tbxSubIDML.Text != this.sOldInfo[3])
                this.IsNameIDChanged = true;
            else this.IsNameIDChanged = false;
        }

        #endregion

        void SetColor(Color x)
        {
            btnExitML.ActiveFillColor = btnExitML.ForeColor = btnExitML.IdleLineColor = btnExitML.IdleForecolor = btnExitML.ActiveLineColor =
                  btnSaveML.ActiveFillColor = btnSaveML.ForeColor = btnSaveML.IdleLineColor = btnSaveML.IdleForecolor = btnSaveML.ActiveLineColor =
                  GradientPanelAddLesson.BackColor = GradientPanelAddLesson.GradientTopLeft = GradientPanelAddLesson.GradientTopRight = GradientPanelAddLesson.GradientBottomLeft = GradientPanelAddLesson.GradientBottomRight =
                  tbxSemNaML.LineFocusedColor = tbxSemNaML.LineMouseHoverColor =
                  tbxSubIDML.LineMouseHoverColor = tbxSubIDML.LineFocusedColor =
                  tbxSubNaML.LineFocusedColor = tbxSubNaML.LineMouseHoverColor = x;

        }
    }
}