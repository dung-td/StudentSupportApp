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
    public partial class Feedback : Form
    {
        MainForm parent;
        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }
        public Feedback()
        {
            InitializeComponent();
        }

        public Feedback(MainForm p)
        {
            InitializeComponent();
            this.parent = p;
            SetColor(Properties.Settings.Default.Color);
        }

        void SetColor(Color x)
        {
            panel1.BackColor =
                bExit.ForeColor = bExit.IdleForecolor = bExit.IdleLineColor = bExit.ActiveFillColor =
                bSend.ForeColor = bSend.IdleForecolor = bSend.IdleLineColor = bSend.ActiveFillColor =
                tbFeed.BorderColorFocused = tbFeed.BorderColorMouseHover = x;
        }

        private void Feedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
