using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Data.SqlClient;

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
        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        LoginForm parent;
        EmailVerify EmailVerify;
        bool IsCodeSent = false;
        public SignUp(LoginForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetColor(Properties.Settings.Default.Color);
        }

        #region EventHandler
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }
        private int CheckFullInfo()
        {
            if (tbxID.Text == "" || tbxName.Text == "" || tbxPass.Text == "" || tbxGender.Text == "" || tbxCode.Text == ""
                || tbxConfirmPass.Text == "" || tbxClass.Text == "")
            {
                return 0;
            }
            return 1;
        }
        private int CheckPassword()
        {
            if (tbxPass.Text.Length < 8) return 2;
            if (tbxPass.Text != tbxConfirmPass.Text) return 3;
            return 1;
        }
        private int CheckCode()
        {
            if (IsCodeSent == false)
                return 0;
            else if (IsCodeSent == true && this.EmailVerify.GetCode != tbxCode.Text)
                return 0;
            else return 1;
        }
        private int CheckEmail()
        {
            if (!(tbxEmail.Text.Contains("@")))
                return 0;
            return 1;
        }
        private int CheckExistID()
        {
            Connect connection = new Connect();
            try
            {
                connection.OpenConnection();

                SqlCommand command = connection.CreateSQLCmd("select ID_USER from USERS");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    if (reader.GetString(0) == tbxID.Text) return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
            finally
            {
                connection.CloseConnection();
            }
            return 0;
        }
        private void bSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                if (CheckPassword() == 1 && CheckCode() == 1 && CheckFullInfo() == 1 && CheckExistID() == 0)
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
                    MessageBox.Show("Mã xác nhận không đúng! Vui lòng thử lại!", "StudentSupportApp", buttons);
                    lbCodeSent.Hide();
                }
                else if (CheckPassword() == 2) lbShortPass.Visible = true;
                else if (CheckPassword() == 3) lbConfirmWrong.Visible = true;
                else if (CheckExistID() == 1) lbUsedID.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }
        private void bSendCode_Click(object sender, EventArgs e)
        {
            try
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
                    this.IsCodeSent = true;
                }
                else
                {
                    lbUsedMail.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
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
        private void tbxID_OnValueChanged(object sender, EventArgs e)
        {
            lbUsedID.Visible = false;
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
        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbxPass.Focus();
        }
        private void tbxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbxConfirmPass.Focus();
        }
        private void tbxConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbxEmail.Focus();
        }
        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                bSendCode.Focus();
        }
        private void tbxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbxName.Focus();
        }
        private void dateBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbxGender.Focus();
        }
        private void tbxClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                bSignUp_Click(sender, e);
        }
        private void tbxGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbxClass.Focus();
        }
        private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar) == false && (e.KeyChar != (char)Keys.Space) && e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
                dateBirth.Focus();
        }
        #endregion

        void SetColor(Color x)
        {
            bunifuGradientPanel1.BackColor = bunifuGradientPanel1.GradientTopLeft = bunifuGradientPanel1.GradientTopRight =
                bunifuGradientPanel1.GradientBottomLeft = bunifuGradientPanel1.GradientBottomRight =
                bunifuCustomLabel1.ForeColor = bunifuSeparator2.ForeColor = lbBirthSU.ForeColor = lbPassSU.ForeColor = lbRePassSU.ForeColor =
                lbEmailSU.ForeColor = lbVerify.ForeColor = lbCodeSent.ForeColor = lnAddtitional.ForeColor = lbNameSU.ForeColor = lbBirthSU.ForeColor = lbGenderSU.ForeColor =
              lbClassSU.ForeColor = lbIDSU.ForeColor = bunifuSeparator2.LineColor = dateBirth.BackColor =

              bSendCode.ActiveFillColor = bSendCode.ForeColor = bSendCode.IdleLineColor = bSendCode.IdleForecolor = bSendCode.ActiveLineColor =
              bCancel.ActiveFillColor = bCancel.ForeColor = bCancel.IdleLineColor = bCancel.IdleForecolor = bCancel.ActiveLineColor =
              bSignUp.ActiveFillColor = bSignUp.ForeColor = bSignUp.IdleLineColor = bSignUp.IdleForecolor = bSignUp.ActiveLineColor =

              tbxPass.LineFocusedColor = tbxPass.LineMouseHoverColor =
              tbxConfirmPass.LineFocusedColor = tbxConfirmPass.LineMouseHoverColor =
              tbxID.LineFocusedColor = tbxID.LineMouseHoverColor =
              tbxEmail.LineFocusedColor = tbxEmail.LineMouseHoverColor =
              tbxCode.LineFocusedColor = tbxCode.LineMouseHoverColor =
              tbxName.LineFocusedColor = tbxName.LineMouseHoverColor =
              tbxGender.LineFocusedColor = tbxGender.LineMouseHoverColor =
              tbxClass.LineFocusedColor = tbxClass.LineMouseHoverColor = x;
        }
    }
}
