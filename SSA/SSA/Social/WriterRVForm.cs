using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class WriterRVForm : Form
    {
        MainForm parent1;
        ReviewForm parent2;
        Review review;
        int temp = 0;
        [DllImport("user32")]
        private static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }
        public WriterRVForm(ReviewForm parent, string ID_User)
        {
            temp = 1;
            review = new Review();
            this.review._ID_User = ID_User;
            this.parent2 = parent;
            InitializeComponent();
            SetColor(Properties.Settings.Default.Color);
            this.Size = new Size(900, 470);
        }
        public WriterRVForm(MainForm parent, string ID_User)
        {
            temp = 1;
            review = new Review();
            this.review._ID_User = ID_User;
            this.parent1 = parent;
            InitializeComponent();
            SetColor(Properties.Settings.Default.Color);
            this.Size = new Size(900, 470);
        }
        public WriterRVForm(ReviewForm parent, int ID, string[] args, DateTime Date)
        {
            temp = -1;
            review = new Review();
            this.review._ID = ID;
            this.review._SubjectID = args[0];
            this.review._Subject = args[1];
            this.review._Details = args[2];
            this.review._Date = Date;
            InitializeComponent();
            this.tbxSubID.Text = review._SubjectID;
            this.tbxSubName.Text = review._Subject;
            this.tbxDetails.Text = review._Details;
            this.Size = new Size(900, 470);
            this.parent2 = parent;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (temp == 1)
            {
                review = new Review();
                review.GetReviewID(ref temp);
                review._ID = temp;
                review._Like = 0;
                review._Report = 0;
                review._Dislike = 0;
                review._Subject = tbxSubName.Text;
                review._SubjectID = tbxSubID.Text;
                review._Date = DateTime.Now;
                review._Details = tbxDetails.Text;
                review.AddReviewToDatabase();
            }
            else
            {
                review._Subject = tbxSubName.Text;
                review._SubjectID = tbxSubID.Text;
                review._Date = DateTime.Now;
                review._Details = tbxDetails.Text;
                review.ModifyReview();
            }
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SetColor(Color x)
        {
            tbxSubID.LineFocusedColor = tbxSubID.LineMouseHoverColor =
                tbxSubName.LineMouseHoverColor = tbxSubName.LineFocusedColor =
                    header.BackColor = x;
        }

        private void WriterRVForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
