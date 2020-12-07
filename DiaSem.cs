using System;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class DiaSem : Form
    {
        SemForm parent;

        public delegate void GetData(string s);
        public GetData getData;

        public DiaSem()
        {
            InitializeComponent();
        }

        public DiaSem(SemForm p, string lable)
        {
            this.parent = p;
            InitializeComponent();
            lDiaSem.Text = lable;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (tbAddNew.Text != "")
            {
                getData(tbAddNew.Text);
                bOK.Enabled = false;
                this.Close();
                this.parent.Show();
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Textbox was blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            bExit.Enabled = false;
            this.Close();
            this.parent.Show();

        }

        private void DiaSem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }
    }
}
