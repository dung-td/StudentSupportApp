using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSA
{
    public partial class SignupForm : Form
    {
        LoginForm parent;
        public SignupForm()
        {
            InitializeComponent();
        }
        public SignupForm(LoginForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private int CheckPassword()
        {
            if (tbxPassSU.Text.Length < 8) return 2;
            if (tbxRePassSU.Text != tbxPassSU.Text) return 3;
            return 1;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (CheckPassword() == 1)
            {
                USER user = new USER();
                user.ID = tbxIDSU.Text;
                MD5Encoder PasswordEncoder = new MD5Encoder();
                user.Password = PasswordEncoder.FromString(tbxPassSU.Text);
                user.AddUserToDatabase();
                MessageBox.Show("Signed up successfully!", "StudentSupportApp");
            }
            else if (CheckPassword() == 2) lbShortPass.Visible = true;
            else lbRepassWrong.Visible = true;
        }

        private void btnCancelSU_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void tbxPassSU_TextChanged(object sender, EventArgs e)
        {
            lbShortPass.Visible = false;
            lbRepassWrong.Visible = false;
        }

        private void tbxRePassSU_TextChanged(object sender, EventArgs e)
        {
            lbRepassWrong.Visible = false;
        }
    }
}
