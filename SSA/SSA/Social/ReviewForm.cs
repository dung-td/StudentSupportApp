using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class ReviewForm : Form
    {
        Connect Connection = new Connect();
        Review[] Reviews;
        int temp;
        int num;
        string Key = "";
        string ID_User;
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
        public ReviewForm(string ID_User)
        {
            num = 0;
            this.ID_User = ID_User;
            Reviews = new Review[1000];
            InitializeComponent();
        }
        private void ReviewForm_Load(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM REVIEW";
            ReadData(Query);
            temp = 0;
            SetReview();
        }
        public void ReadData(string Query)
        {
            num = 0;
            try
            {
                Connection.OpenConnection();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                        break;
                    Reviews[num] = new Review();
                    Reviews[num]._ID = reader.GetInt32(0);
                    Reviews[num]._SubjectID = reader.GetString(1);
                    Reviews[num]._Subject = reader.GetString(2);
                    Reviews[num]._ID_User = reader.GetString(3);
                    Reviews[num]._Details = reader.GetString(4);
                    Reviews[num]._Like = reader.GetInt32(5);
                    Reviews[num]._Dislike = reader.GetInt32(6);
                    Reviews[num]._Report = reader.GetInt32(7);
                    Reviews[num]._Date = reader.GetDateTime(8);
                    num++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        public void SetReview()
        {
            if (Reviews[temp] == null || temp < 0 || temp > num)
                MessageBox.Show("Đã hết dữ liệu!");
            else
            {
                this.lWriter.Text = Reviews[temp]._ID_User;
                this.lSubID.Text = Reviews[temp]._SubjectID;
                this.lSubName.Text = Reviews[temp]._Subject;
                this.lDate.Text = Reviews[temp]._Date.ToString();
                this.btnLike.Text = Reviews[temp]._Like.ToString();
                this.btnDislike.Text = Reviews[temp]._Dislike.ToString();
                this.tbxDetails.Text = Reviews[temp]._Details;
            }
        }
        private void btnLike_Click(object sender, EventArgs e)
        {
            Reviews[temp].UpdateLike();
        }
        private void btnDislike_Click(object sender, EventArgs e)
        {
            Reviews[temp].UpdateDislike();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            Reviews[temp].UpdateReport();
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            temp--;
            if (temp < 0)
                temp = 0;
            SetReview();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            temp++;
            if (temp > num)
                temp = num;
            SetReview();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cbbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = cbbCate.Text;
        }
        private void tbxKeyWord_OnValueChanged(object sender, EventArgs e)
        {
            string Query;
            switch (cbbCate.Text)
            {
                case "ID Môn học":
                    Query = "SELECT * FROM REVIEW WHERE SubjectID='" + tbxKeyWord.Text + "'";
                    break;
                case "Người viết":
                    Query = "SELECT * FROM REVIEW WHERE ID_USER='" + tbxKeyWord.Text + "'";
                    break;
                case "Môn học":
                    Query = "SELECT * FROM REVIEW WHERE Subject='" + tbxKeyWord.Text + "'";
                    break;
                default:
                    Query = "SELECT * FROM REVIEW";
                    break;
            }
            ReadData(Query);
            temp = 0;
            SetReview();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }
    }
}
