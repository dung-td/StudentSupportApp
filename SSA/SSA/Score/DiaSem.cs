using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class DiaSem : Form
    {
        SemForm parent;

        public delegate void GetData(string s);
        public GetData getData;

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        public DiaSem()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        public DiaSem(SemForm p, string lable)
        {
            this.parent = p;
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            lDiaSem.Text = lable;
            SetColor(Properties.Settings.Default.Color);
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            try
            {


                if (tbAddNew.Text != "")
                {
                    getData(tbAddNew.Text);
                    bOK.Enabled = false;
                    this.Close();
                    this.parent.Show();
                    MessageBox.Show("Đã xong!");
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            bExit.Enabled = false;
            this.Close();
            this.parent.Show();

        }

        private void DiaSem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        void SetColor(Color x)
        {
            panel1.BackColor = x;
            tbAddNew.LineFocusedColor = tbAddNew.LineMouseHoverColor = x;
        }
    }
}
