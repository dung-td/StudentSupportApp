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
    public partial class Add : Form
    {
        MainForm parent;
        public delegate void AddItem(string[] temp);
        public AddItem addItem;

        public Add(MainForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] sTempString = new string[6];
            sTempString[1] = textBoxSubID.Text;
            sTempString[2] = textBoxSubName.Text;
            sTempString[3] = textBoxDetails.Text;
            DateTime TempDateTime = new DateTime(dateTimePickerDS.Value.Year, dateTimePickerDS.Value.Month, dateTimePickerDS.Value.Day);
            TempDateTime.AddHours(int.Parse(textBoxTimeSub1.Text));
            if (listBoxTS.Text == "PM")
                TempDateTime.AddHours(int.Parse(textBoxTimeSub1.Text) + 12);
            TempDateTime.AddMinutes(int.Parse(textBoxTimeSub2.Text));
            sTempString[4] = TempDateTime.ToString();
            sTempString[5] = "FINISHED";
            addItem(sTempString);
            MessageBox.Show(" ADDED SUCCESSFULLY!");
            this.Hide();
            this.parent.Show();
        }


        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }
    }
}
