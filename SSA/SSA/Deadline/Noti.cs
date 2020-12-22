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
    public partial class Notifi : Form
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

        int x, y;
        public Notifi()
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            SetColor(Properties.Settings.Default.Color);
        }
        public enum enumAction
        {
            wait, start, close
        }
        private Notifi.enumAction action;
        #region EventHanlder
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enumAction.close;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enumAction.wait:
                    timer1.Interval = 10000;
                    action = enumAction.close;
                    break;
                case Notifi.enumAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Notifi.enumAction.wait;
                        }
                    }
                    break;
                case enumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enumAction.close;
        }
        public void showAlert(string msg)
        {
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "Alert" + i.ToString();
                Notifi frm = (Notifi)Application.OpenForms[fname];
                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(x, y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.labelText.Text = msg;
            this.BringToFront();
            this.Show();
            this.action = enumAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }
        void SetColor(Color x)
        {
            bunifuGradientPanel1.GradientTopLeft = bunifuGradientPanel1.GradientTopRight
                = bunifuGradientPanel1.GradientBottomLeft = bunifuGradientPanel1.GradientBottomRight = x;
        }
        #endregion
    }
}
