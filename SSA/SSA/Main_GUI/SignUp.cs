using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class SignUp : Form
    {
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
        LoginForm parent;
        EmailVerify EmailVerify;
        public SignUp(LoginForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        #region EventHandler
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }
        private int CheckPassword()
        {
            if (tbxPass.Text.Length < 8) return 2;
            if (tbxPass.Text != tbxConfirmPass.Text) return 3;
            return 1;
        }
        private int CheckCode()
        {
            if (this.EmailVerify.GetCode != tbxCode.Text)
                return 0;
            else return 1;
        }
        private int CheckEmail()
        {
            if (!(tbxEmail.Text.Contains("@")))
                return 0;
            return 1;
        }
        private void bSignUp_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (CheckPassword() == 1 && CheckCode() == 1)
            {
                USER user = new USER();
                user.ID = tbxID.Text;
                MD5Encoder PasswordEncoder = new MD5Encoder();
                user.Password = PasswordEncoder.FromString(tbxPass.Text);
                user.Birthday = dateBirth.Value;
                user.Email = tbxEmail.Text;
                user.Name = tbxName.Text;
                user.Class = tbxClass.Text;
                user.Gender = tbxGender.Text;
                this.EmailVerify = new EmailVerify(user.Email);
                user.AddUserToDatabase();
                MessageBox.Show("Đăng ký thành công!", "StudentSupportApp", buttons);
                this.Close();
                this.parent.Show();
            }
            else if (CheckCode() == 0)
            {
                MessageBox.Show("Mật mã không đúng! Vui lòng thử lại!", "StudentSupportApp", buttons);
                lbCodeSent.Hide();
            }
            else if (CheckPassword() == 2) lbShortPass.Visible = true;
            else if (CheckPassword() == 3) lbConfirmWrong.Visible = true;
        }
        private void bSendCode_Click(object sender, EventArgs e)
        {
            USER temp = new USER();
            temp.Email = this.tbxEmail.Text;
            if (CheckEmail() == 0)
            {
                lbValidEmail.Show();
            }
            else if (temp.CheckEmail() == 1)
            {
                this.EmailVerify = new EmailVerify(tbxEmail.Text);
                this.EmailVerify.GetRandomCode();
                this.EmailVerify.SendMail();
                lbCodeSent.Show();
            }
            else
            {
                lbUsedMail.Show();
            }
        }
        private void tbxPass_OnValueChanged(object sender, EventArgs e)
        {
            lbShortPass.Visible = false;
            lbConfirmWrong.Visible = false;
            tbxPass.isPassword = true;
        }
        private void tbxConfirmPass_OnValueChanged(object sender, EventArgs e)
        {
            lbConfirmWrong.Visible = false;
            tbxConfirmPass.isPassword = true;
        }
        private void tbxEmail_OnValueChanged(object sender, EventArgs e)
        {
            lbUsedMail.Hide();
            lbValidEmail.Hide();
        }
        private void SignUp_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        #endregion
    }
}
