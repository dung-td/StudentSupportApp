using System;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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
            tbxPass.isPassword = true;
        }
    }
}
