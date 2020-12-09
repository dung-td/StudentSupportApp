using System;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class Load : Form
    {
        int temp = 0;
        public Load()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 10;
            if (this.progressBar1.Value == 100)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                timer1.Stop();
            }
        }
    }
}
