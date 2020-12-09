using System;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class AddLessonForm : Form
    {
        MainForm parent;
        private string sUserID;

        public AddLessonForm()
        {
            InitializeComponent();
        }

        public AddLessonForm(MainForm parent, string ID)
        {
            this.parent = parent;
            this.sUserID = ID;
            InitializeComponent();
        }

        private void btnAddAL_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxDIWAL.Text != "" && cbxTimeOrder.Text != "" && tbxSemNaAL.Text != "" && tbxSubIDAL.Text != "" && tbxSubNaAL.Text != "")
                {
                    Timetable lesson = new Timetable();
                    string[] sData = new string[] { cbxDIWAL.Text, cbxTimeOrder.Text, tbxSubIDAL.Text, tbxSubNaAL.Text, tbxSemNaAL.Text, this.sUserID };
                    if (lesson.AddLessonToDatabase(sData) == 1)
                        MessageBox.Show("Succeeded in adding new lesson!", "Add Lesson");
                    else MessageBox.Show("Failed to add new lesson. Check your data.", "Add Lesson");
                }
                else
                {
                    MessageBox.Show("Failed to add new lesson. Check your data.", "Add Lesson");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnExitAL_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parent.Show();
        }

        private void AddLessonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
            this.Hide();
        }

        private void tbxSemNaAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxDIWAL.Focus();
        }

        private void cbxDIWAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxSubNaAL.Focus();
        }

        private void tbxSubNaAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxSubIDAL.Focus();
        }

        private void tbxSubIDAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxTimeOrder.Focus();
        }

        private void cbxTimeOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddAL_Click(sender, e);
        }

       
    }
}

