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

            SetColor(Properties.Settings.Default.Color) ;
        }
        public ReportError(Exception e)
        {
            this.e = e;
            InitializeComponent();
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
                 bSend.ActiveFillColor = bSend.ForeColor = bSend.IdleLineColor = bSend.IdleForecolor =
                  bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleLineColor = bExit.IdleForecolor = x;
        }
    }
}
