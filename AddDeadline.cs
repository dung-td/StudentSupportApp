﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class AddDeadline : Form
    {
        MainForm parent;
        public delegate void AddItem(string[] temp);
        public AddItem addItem;
        public AddDeadline(MainForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void tbCancel_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }
        private void btbHour_OnValueChanged(object sender, EventArgs e)
        {
            if (!btbHour.Text.All(char.IsDigit))
                btbHour.LineFocusedColor = Color.Red;
            else
                btbHour.LineFocusedColor = Color.Blue;
        }

        private void btbMinute_OnValueChanged(object sender, EventArgs e)
        {
            if (!btbMinute.Text.All(char.IsDigit))
                btbMinute.LineFocusedColor = Color.Red;
            else
                btbMinute.LineFocusedColor = Color.Blue;
        }

        private void btbSubID_OnValueChanged(object sender, EventArgs e)
        {
            if (!btbSubID.Text.All(char.IsLetterOrDigit))
                btbSubID.LineFocusedColor = Color.Red;
            else
                btbSubID.LineFocusedColor = Color.Blue;
        }
        private void tbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string[] sTempString = new string[6];
                sTempString[1] = btbSubID.Text;
                sTempString[2] = btbSubject.Text;
                sTempString[3] = btbDetails.Text;
                DateTime TempDateTime = new DateTime(bDateTime.Value.Year, bDateTime.Value.Month, bDateTime.Value.Day);
                TempDateTime.AddHours(int.Parse(btbHour.Text));
                if (comboBoxTime.Text == "PM")
                    TempDateTime.AddHours(int.Parse(btbHour.Text) + 12);
                TempDateTime.AddMinutes(int.Parse(btbMinute.Text));
                sTempString[4] = TempDateTime.ToString();
                sTempString[5] = "UNFINISHED";
                addItem(sTempString);
                this.Hide();
                this.parent.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}