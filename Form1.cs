using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentSupportApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void ReadData()
        {
            var tbx = labelsText();

            string[] data = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Timetable.txt"));
            //MessageBox.Show(data.Length + "");
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
        }

        public List<TextBox> labelsText()
        {
            var tbx = new List<TextBox> { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8, tbx9, tbx10,
                                    tbx11, tbx12, tbx13, tbx14, tbx15, tbx16, tbx17, tbx18, tbx19, tbx20,
                                    tbx21, tbx22, tbx23, tbx24, tbx25, tbx26, tbx27, tbx28, tbx29, tbx30,
                                    tbx31, tbx32, tbx33, tbx34, tbx35, tbx36, tbx37, tbx38, tbx39, tbx40,
                                    tbx41, tbx42, tbx43, tbx44, tbx45, tbx46, tbx47, tbx48, tbx49, tbx50,
                                    tbx51, tbx52, tbx53, tbx54, tbx55, tbx56, tbx57, tbx58, tbx59, tbx60,
                                    tbx61, tbx62, tbx63, tbx64, tbx65 };
            return tbx;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadData();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
    }
}
