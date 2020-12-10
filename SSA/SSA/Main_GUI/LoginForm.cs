using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace StudentSupportApp
{
    public partial class LoginForm : Form
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
        public LoginForm()
        {
            InitializeComponent();
            SetColor(Properties.Settings.Default.Color);
        }
        #region EventHandler
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bLogin_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            user.ID = tbxID.Text;
            user.Password = tbxPass.Text;
            if (user.CheckLogin() == 1)
            {
                MainForm mainForm = new MainForm(this, user.ID);
                mainForm.Show();
                this.Hide();
            }
            else if (user.CheckLogin() == 0)
            {
                labelInvalid.Visible = true;
            }
            else labelWrong.Visible = true;

        }
        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bLogin_Click(sender, e);
            }
        }
        private void bSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
            this.Hide();
        }
        private void tbxID_OnValueChanged(object sender, EventArgs e)
        {
            labelInvalid.Hide();
        }
        private void tbxPass_OnValueChanged(object sender, EventArgs e)
        {
            labelWrong.Hide();
        }
        private void tbxPass_Enter(object sender, EventArgs e)
        {
            tbxPass.isPassword = true;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.tbxPass.Text = "";
        }
        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            this.tbxPass.Text = "";
        }
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        void SetColor(Color x)
        {
            bunifuGradientPanel1.BackColor = bunifuGradientPanel1.GradientTopLeft = bunifuGradientPanel1.GradientTopRight =
                bunifuGradientPanel1.GradientBottomLeft = bunifuGradientPanel1.GradientBottomRight =

                bunifuCustomLabel1.ForeColor = bunifuSeparator1.LineColor =
                tbxID.LineFocusedColor = tbxID.LineMouseHoverColor =
                tbxPass.LineMouseHoverColor = tbxPass.LineFocusedColor =

                 bLogin.ActiveFillColor = bLogin.ForeColor = bLogin.IdleLineColor = bLogin.IdleForecolor =

                  bSignUp.ActiveFillColor = bSignUp.ForeColor = bSignUp.IdleLineColor = bSignUp.IdleForecolor =

                   bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleLineColor = bExit.IdleForecolor =
                   bID.OnHoverTextColor = bPassword.OnHoverTextColor = bForgot.OnHoverTextColor = x;
        }
        #endregion
    }
}
