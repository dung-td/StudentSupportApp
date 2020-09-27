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
                btnFinish.Visible = true;
                btnCancel.Visible = true;
                var tbx = labelsText();
                
                using (var myFile = File.Create(@"C:\Users\Acer\Desktop\StudentSupportApp\StudentSupportApp\Timetable.txt"))
                {
                    myFile.Close();
                    string data = File.ReadAllText(@"C:\Users\Acer\Desktop\StudentSupportApp\StudentSupportApp\Timetable.txt");
                    foreach (TextBox a in tbx)
                    {
                        a.Text = data;
                        
                    }
                }
                btnFinish.Click += new EventHandler((sender1, e1) => btnFinish_Click(sender, e, tbx));
            }
        }
        public void btnFinish_Click (object sender, EventArgs e, List<TextBox> tbx)
        {
            string path = @"C:\Users\Acer\Desktop\StudentSupportApp\StudentSupportApp\Timetable.txt";
            using (StreamWriter File = new StreamWriter(path, true))
            foreach (TextBox a in tbx)
            {
                  File.WriteLine(a.Text);
            }
            string[] data = File.ReadAllLines(path);
            for (int i = 0; i < data.Length; i++)
            {
                tbx[i].Text = data[i];
            }
            MessageBox.Show("Your data has been saved!", "Well done");
        }
    }
}
