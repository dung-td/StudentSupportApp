using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace StudentSupportApp
{
    public partial class AddDeadline : Form
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
        public delegate void AddItem(string[] temp);
        public AddItem addItem;
        public AddDeadline(MainForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetColor(Properties.Settings.Default.Color);
        }
        #region EventHandler
        private void tbCancel_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }
        private void btbHour_OnValueChanged(object sender, EventArgs e)
        {

            if (!btbHour.Text.All(char.IsDigit))
                btbHour.LineFocusedColor = Color.Red;
            else
                btbHour.LineFocusedColor = Color.Blue;
        }
        private void btbMinute_OnValueChanged(object sender, EventArgs e)
        {
            if (!btbMinute.Text.All(char.IsDigit))
                btbMinute.LineFocusedColor = Color.Red;
            else
                btbMinute.LineFocusedColor = Color.Blue;
        }
        private void btbSubID_OnValueChanged(object sender, EventArgs e)
        {
            if (!btbSubID.Text.All(char.IsLetterOrDigit))
                btbSubID.LineFocusedColor = Color.Red;
            else
                btbSubID.LineFocusedColor = Color.Blue;
        }
        private void TurnTime(ref int h, ref int m)
        {
            if (h < 0 || h > 12 || m < 0 || m > 59)
            {
                h = m = -1;
            }
            else
            {
                if (comboBoxTime.Text == "PM")
                    h += 12;
                if (h == 24)
                    h = 0;
            }
        }
        private void tbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string[] sTempString = new string[8];
                sTempString[1] = btbSubID.Text;
                sTempString[2] = btbSubject.Text;
                sTempString[3] = btbDetails.Text;
                int min = int.Parse(btbMinute.Text);
                int hour = int.Parse(btbHour.Text);
                TurnTime(ref hour, ref min);
                if (hour == -1 || min == -1)
                    labelTimeFormat.Show();
                else
                {
                    DateTime TempDateTime = new DateTime(bDateTime.Value.Year, bDateTime.Value.Month, bDateTime.Value.Day, hour, min, 0);
                    sTempString[4] = TempDateTime.ToString();
                    sTempString[5] = btbStatus.Text;
                    sTempString[6] = "";
                    sTempString[7] = "0";
                    addItem(sTempString);
                    this.Hide();
                    this.parent.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }

        }
        void SetColor(Color x)
        {
            GradientPanelAddDeadline.BackColor = GradientPanelAddDeadline.GradientTopLeft = GradientPanelAddDeadline.GradientTopRight =
                GradientPanelAddDeadline.GradientBottomLeft = GradientPanelAddDeadline.GradientBottomRight =
                bDateTime.BackColor =
                btbDetails.LineFocusedColor = btbDetails.LineMouseHoverColor =
                 btbSubject.LineFocusedColor = btbSubject.LineMouseHoverColor =
                  btbSubID.LineFocusedColor = btbSubID.LineMouseHoverColor = btbSubID.LineFocusedColor =
                   btbDetails.LineFocusedColor = btbDetails.LineMouseHoverColor =
                    btbHour.LineFocusedColor = btbHour.LineMouseHoverColor =
                     btbMinute.LineFocusedColor = btbMinute.LineMouseHoverColor =
                      btbStatus.LineFocusedColor = btbStatus.LineMouseHoverColor =

                       tbAdd.ActiveFillColor = tbAdd.ForeColor = tbAdd.IdleLineColor = tbAdd.IdleForecolor = tbAdd.ActiveLineColor =
                        tbCancel.ActiveFillColor = tbCancel.ForeColor = tbCancel.IdleLineColor = tbCancel.IdleForecolor = tbCancel.ActiveLineColor = x;
        }
        private void btbSubID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btbSubject.Focus();
            }
        }
        private void btbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btbDetails.Focus();
            }
        }
        private void btbDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                bDateTime.Focus();
            }
        }
        private void btbHour_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btbMinute.Focus();
            }
        }
        private void btbMinute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btbStatus.Focus();
            }
        }
        private void btbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                tbAdd_Click(sender, e);
            }
        }
        private void bDateTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btbStatus.Focus();
            }
        }
        private void btbHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }
        private void btbMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }
        #endregion
    }
}
