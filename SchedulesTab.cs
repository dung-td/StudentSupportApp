using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class SchedulesTab
    {
    }
    public partial class MainForm : Form
    {
        public void SaveData()
        {
            var tbx = labelsText();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Timetable.txt");
            using (StreamWriter File = new StreamWriter(path, true))
            {
                foreach (TextBox a in tbx)
                {
                    File.WriteLine(a.Text);
                }
            }
            string[] data = File.ReadAllLines(path);
            if (data.Length == 0)
            {
                for (int i = 0; i < 65; i++)
                {
                    tbx[i].Text = "";
                }
            }
            else
            {
                for (int i = 0; i < data.Length; i++)
                {
                    tbx[i].Text = data[i];
                }
            }
            MessageBox.Show("Your data has been saved!", "Well done");
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to make a new timetable?";
            const string caption = "Creating Timetable";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                //this.Close();
            }
            else
            {
                btnFinishCr.Visible = true;
                btnCancelCr.Visible = true;
                btnModify.Visible = false;
                var tbx = labelsText();

                using (var myFile = File.Create(Path.Combine(Directory.GetCurrentDirectory(), "timetable.txt")))
                {
                    myFile.Close();
                    string data = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Timetable.txt"));
                    foreach (TextBox a in tbx)
                    {
                        a.Text = data;
                    }
                }  
            }
        }

        private void btnFinishCr_Click(object sender, EventArgs e)
        {
            SaveData();
            btnFinishCr.Visible = false;
            btnCancelCr.Visible = false;
            btnModify.Visible = true;
        }

        private void btnCancelCr_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to stop the progress?\nYour data will not be saved";
            const string caption = "Canceling creation";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                //this.Close();
            }
            else
            {
                var tbx = labelsText();
                string data = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Timetable.txt"));
                foreach (TextBox a in tbx)
                {
                    a.Text = data;
                }
                btnFinishCr.Hide();
                btnCancelCr.Hide();
                btnModify.Visible = true;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            btnFinishM.Visible = true;
            btnCancelM.Visible = true;
            btnNewData.Visible = false;
        }

        private void btnFinishM_Click(object sender, EventArgs e)
        {
            using (var myFile = File.Create(Path.Combine(Directory.GetCurrentDirectory(), "timetable.txt")))
            {
                myFile.Close();
                SaveData();
            }
            btnCancelM.Visible = false;
            btnFinishM.Visible = false;
            btnNewData.Visible = true;
        }

        private void btnCancelM_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to stop the progress?\nYour data will not be saved";
            const string caption = "Cancel modifying";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                //this.Close();
            }
            else
            {
                var tbx = labelsText();
                string[] data = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Timetable.txt"));
                for (int i = 0; i < data.Length; i++)
                {
                    tbx[i].Text = data[i];
                }
                btnFinishM.Hide();
                btnCancelM.Hide();
                btnNewData.Visible = true;
            }
        }
    }
}
