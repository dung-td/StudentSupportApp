using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class ReportError : Form
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

        Form parent;
        Exception e;
        EmailVerify Email = new EmailVerify("tngcdng@gmail.com");
        public ReportError(Form parent, Exception e)
        {
            this.parent = parent;
            this.e = e;
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetColor(Properties.Settings.Default.Color) ;
        }
        public ReportError(Exception e)
        {
            this.e = e;
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetColor(Properties.Settings.Default.Color);
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
            if (parent != null)
                this.parent.Show();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            Email.SendFeedBack(listType.Text + "\n" + tbxDetails.Text + "\n" + this.e.Message);
            MessageBox.Show("Chúng tôi rất xin lỗi về vấn đề bạn đang gặp phải, chúng tôi sẽ cố gắng sửa trong thời gian sớm nhất!", "Xin lỗi!");
            this.Close();
            if (parent != null)
                this.parent.Show();
        }

        void SetColor(Color x)
        {
            bunifuGradientPanel1.BackColor =
                bunifuGradientPanel1.GradientBottomLeft = bunifuGradientPanel1.GradientBottomRight = bunifuGradientPanel1.GradientTopLeft = bunifuGradientPanel1.GradientTopRight =
               
                bunifuCustomLabel1.ForeColor = labelWrong.ForeColor =
                tbxDetails.LineFocusedColor = tbxDetails.LineMouseHoverColor =
                 bSend.ActiveFillColor = bSend.ForeColor = bSend.IdleLineColor = bSend.IdleForecolor = bSend.ActiveLineColor =
                  bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleLineColor = bExit.IdleForecolor = bExit.ActiveLineColor = x;
        }
    }
}
