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
    public partial class DiaWeb : Form
    {
        string UserID;
        Web selectedWeb;
        string choice;
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
        public DiaWeb(MainForm parent,string id, Web web, string choice)
        {

            InitializeComponent();
            selectedWeb = new Web(web);
            this.choice = choice;
            this.lbWeb.Text = "Thông\ntin";
            this.tbTitle.Text = web.Title;
            this.tbURL.Text = web.URL;
            SetColor(Properties.Settings.Default.Color);
            this.parent = parent;
            bAccess.Visible = true;
            bOK.ButtonText = "Cập nhật";
            bAccess.BackColor = Color.Transparent;
        }
        public DiaWeb(MainForm parent, string id, string choice)
        {
            this.UserID = id;
            this.choice = choice;
            InitializeComponent();
            this.lbWeb.Text = "Thêm\nmột\ntrang\nweb";
            SetColor(Properties.Settings.Default.Color);
            this.parent = parent;
            bAccess.Visible = false;
            bAccess.BackColor = Color.Transparent;
        }

        bool BlankData()
        {
            return !(this.tbTitle.Text != "" && this.tbURL.Text != "");
        }
        void SetColor(Color x)
        {
            panel1.BackColor = tbTitle.LineMouseHoverColor = tbTitle.LineFocusedColor = tbURL.LineFocusedColor = tbURL.LineMouseHoverColor =
            bOK.ActiveFillColor = bOK.ForeColor = bOK.IdleForecolor = bOK.IdleLineColor = bOK.ActiveLineColor =
            bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleForecolor = bExit.IdleLineColor = bExit.ActiveLineColor =
            bDelWeb.ActiveFillColor = bDelWeb.ForeColor = bDelWeb.IdleForecolor = bDelWeb.IdleLineColor = bDelWeb.ActiveLineColor =
            bAccess.ActiveFillColor = bAccess.ForeColor = bAccess.IdleForecolor = bAccess.IdleLineColor = bAccess.ActiveLineColor = x;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            try
            {
                Web tmpWeb = new Web(this.UserID, this.tbTitle.Text, this.tbURL.Text);
                if (!BlankData())
                {
                    if (choice == "add")
                    {
                        tmpWeb.Add();
                        bAccess.Visible = true;
                    }
                    if (choice == "modify")
                        selectedWeb.Modify(tmpWeb);

                    MessageBox.Show("Đã xong!");
                }
                else
                    MessageBox.Show("Dữ liệu còn trống!");
            }   
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
            }
        }

        private void DiaWeb_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
            this.parent.ShowWebsToListView();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bDelWeb_Click(object sender, EventArgs e)
        {
            try
            {
                selectedWeb.Delete();
                MessageBox.Show("Đã xoá!");
                this.Close();
            }

            catch (Exception err)
            {

                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
            }
        }

        private void bAccess_Click(object sender, EventArgs e)
        {
            try
            {
                Web accessWeb = new Web(this.UserID, this.tbTitle.Text, this.tbURL.Text);
                accessWeb.Access();
            }

            catch(Exception err)
            {

                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
            }
        }
    }
}
