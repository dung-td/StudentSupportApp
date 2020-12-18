using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class DiaWeb : Form
    {
        string UserID;
        Web selectedWeb;
        string choice;
        MainForm parent;
        public DiaWeb(MainForm parent,string id, Web web, string choice)
        {

            InitializeComponent();
            selectedWeb = new Web(web);
            this.choice = choice;
            this.lbWeb.Text = "Chỉnh sửa trang web";
            this.tbTitle.Text = web.Title;
            this.tbURL.Text = web.URL;
            SetColor(Properties.Settings.Default.Color);
            this.parent = parent;
        }
        public DiaWeb(MainForm parent, string id, string choice)
        {
            this.UserID = id;
            this.choice = choice;
            InitializeComponent();
            this.lbWeb.Text = "Thêm 1 trang web";
            SetColor(Properties.Settings.Default.Color);
            this.parent = parent;
        }

        bool BlankData()
        {
            return !(this.tbTitle.Text != "" && this.tbURL.Text != "");
        }
        void SetColor(Color x)
        {
            bOK.BackColor = bOK.ActiveFillColor = bOK.ForeColor = bOK.IdleForecolor = bOK.IdleLineColor =
                 bExit.BackColor = bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleForecolor = bExit.IdleLineColor =
                 bDelWeb.BackColor = bDelWeb.ActiveFillColor = bDelWeb.ForeColor = bDelWeb.IdleForecolor = bDelWeb.IdleLineColor = x;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            try
            {
                Web tmpWeb = new Web(this.UserID, this.tbTitle.Text, this.tbURL.Text);
                if (!BlankData())
                {
                    if (choice == "add")
                        tmpWeb.Add();
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
            selectedWeb.Delete();
        }
    }
}
