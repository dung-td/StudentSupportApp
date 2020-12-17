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
using System.Net.Mail;

namespace StudentSupportApp
{
    public partial class Feedback : Form
    {
        MainForm parent;
        string Email, ID;
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

        public Feedback(MainForm p, string email, string id)
        {
            InitializeComponent();
            this.parent = p;
            this.Email = email;
            this.ID = id;
            SetColor(Properties.Settings.Default.Color);
        }

        void SetColor(Color x)
        {
            panel1.BackColor =
                bExit.ForeColor = bExit.IdleForecolor = bExit.IdleLineColor = bExit.ActiveFillColor =
                bSend.ForeColor = bSend.IdleForecolor = bSend.IdleLineColor = bSend.ActiveFillColor =
                
                tbTitle.BorderColorFocused = tbTitle.BorderColorMouseHover =
                x;
        }

        private void Feedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool BlankData()
        {
            return (tbFeed.Text == "" || tbTitle.Text == "");
        }

        public void SendMail()
        {
            try
            {
               MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("ssa.nonreply@gmail.com");
                mail.To.Add("ssa.nonreply@gmail.com");
                mail.Subject = "<FEEDBACK>" + this.tbTitle.Text;
                mail.Body = "UserID: " + this.ID + "\nEmail: " + this.Email + "\n\n" + this.tbFeed.Text;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ssa.nonreply@gmail.com", "Dung0478");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if(!BlankData())
            {
                SendMail();
                MessageBox.Show("Đã gửi thành công");
            }
            else
                MessageBox.Show("Dữ liệu không được trống!");
        }
    }
}
