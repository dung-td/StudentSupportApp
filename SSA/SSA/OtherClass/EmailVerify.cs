using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace StudentSupportApp
{
    class EmailVerify
    {
        string Email, Code, Name;
        public EmailVerify(string Email)
        {
            this.Email = Email;
            this.Name = "";
            this.Code = "";
        }
        public string GetEmail
        {
            get
            {
                return this.Email;
            }
            set
            {
                this.Email = value;
            }
        }
        public string GetName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public string GetCode
        {
            get
            {
                return this.Code;
            }
            set
            {
                this.Code = value;
            }
        }
        public void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("ssa.nonreply@gmail.com");
                mail.To.Add(this.Email);
                mail.Subject = "Student Support App OTP";
                mail.Body = "Hello" + this.Name + ", \nHere is your OTP: " + this.Code + "\n";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ssa.nonreply@gmail.com", "Dung0478");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void SendFeedBack(string args)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("ssa.nonreply@gmail.com");
                mail.To.Add(this.Email);
                mail.Subject = "Student Support App OTP";
                mail.Body = args;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ssa.nonreply@gmail.com", "Dung0478");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void GetRandomCode()
        {
            Random rand = new Random();
            char[] letters = "0123456789".ToCharArray();
            string word = "";
            for (int i = 0; i < 7; i++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                word += letters[letter_num];
            }
            this.GetCode = word;
        }
    }
}
