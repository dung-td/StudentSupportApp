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
        Form parent;
        Review review;
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
        public WriterRVForm(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            review = new Review();
            int temp = 1;
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
