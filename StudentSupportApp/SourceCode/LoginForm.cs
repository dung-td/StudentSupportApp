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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm(this);
            signup.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            user.ID = tbxID.Text;
            user.Password = tbxPassLogin.Text;
            if (user.CheckLogin() == 1)
            {
                MainForm SSA = new MainForm(this, user.ID);
                SSA.Show();
                this.Hide();
            }
            else if (user.CheckLogin() == 0)
            {
                lbIDinvalid.Visible = true;
            }
            else lbWrongPass.Visible = true;
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxPassLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
