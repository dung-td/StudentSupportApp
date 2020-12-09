using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class ModLessonForm : Form
    {
        MainForm parent;
        private string sUserID;
        private string[] sOldInfo;

        public ModLessonForm()
        {
            InitializeComponent();
        }

        public ModLessonForm(MainForm parent, List<string> data, string ID)
        {
            try
            {
                InitializeComponent();
                this.parent = parent;
                this.sUserID = ID;
                this.sOldInfo = new string[6];
                if (data.Count > 4)
                {
                    tbxSemNaML.Text = data[0];
                    cbxDIWML.Text = data[1];
                    tbxSubNaML.Text = data[2];
                    tbxSubIDML.Text = data[3];
                    cbxTimeOrderM.Text = data[4];

                    for (int i = 0; i < data.Count; i++)
                    {
                        this.sOldInfo[i] = data[i];
                    }
                    this.sOldInfo[5] = this.sUserID;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnExitML_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void btnSaveML_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxDIWML.Text != "" && cbxTimeOrderM.Text != "" && tbxSemNaML.Text != "" && tbxSubIDML.Text != "" && tbxSubNaML.Text != "")
                {
                    Timetable lesson = new Timetable();
                    string[] sData = new string[] { cbxDIWML.Text, cbxTimeOrderM.Text, tbxSubIDML.Text.Remove(0, 1), tbxSubNaML.Text, tbxSemNaML.Text, this.sUserID };
                    if (lesson.UpdateLessonInfo(sOldInfo, sData) == 1)
                        MessageBox.Show("Sucessfully modified!", "Modify Lesson Information");
                    else MessageBox.Show("Failed to modify lesson. Check your data.", "Modify Lesson");
                }
                else
                {
                    MessageBox.Show("Failed to modify lesson. Check your data.", "Modify Lesson");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void tbxSemNaML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxDIWML.Focus();
        }

        private void cbxDIWML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxSubNaML.Focus();
        }

        private void tbxSubNaML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxSubIDML.Focus();
        }

        private void tbxSubIDML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbxTimeOrderM.Focus();
        }

        private void cbxTimeOrderM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSaveML_Click(sender, e);
        }
    }
}
