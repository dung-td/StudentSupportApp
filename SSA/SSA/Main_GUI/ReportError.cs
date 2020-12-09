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
    public partial class ReportError : Form
    {
        Form parent;
        Exception e;
        EmailVerify Email = new EmailVerify("tngcdng@gmail.com");
        public ReportError(Form parent, Exception e)
        {
            this.parent = parent;
            this.e = e;
            InitializeComponent();
        }
        public ReportError(Exception e)
        {
            this.e = e;
            InitializeComponent();
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
    }
}
