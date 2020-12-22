using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class AboutUs : Form
    {
        MainForm parent;

        [DllImport("user32")]
        private static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        public AboutUs()
        {
            InitializeComponent();
        }

        public AboutUs(MainForm p)
        {
            InitializeComponent();
            this.Size = new Size(810, 530);
            this.parent = p;
            SetColor(Properties.Settings.Default.Color);

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        void SetColor(Color x)
        {
            panel1.BackColor = bExit.IdleForecolor = bExit.IdleLineColor =
                lbHome.ForeColor = lbInfomation.ForeColor = lbNotification.ForeColor = lbScore.ForeColor = lbTimetable.ForeColor =
                lbSetting.ForeColor = lbSocial.ForeColor = lbUser.ForeColor = lbLastWord.ForeColor = lbGoal.ForeColor =
                bExit.ActiveLineColor = bExit.ActiveFillColor = bExit.ForeColor =
                bunifuCards1.color = bunifuCards2.color = bunifuCards3.color = 
                bunifuCustomLabel1.ForeColor = bunifuCustomLabel2.ForeColor = bunifuCustomLabel3.ForeColor =
                x;
        }

        private void AboutUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }
    }
}
