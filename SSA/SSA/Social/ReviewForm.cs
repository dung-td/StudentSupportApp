using System;
using System.Drawing;
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
            SetColor(Properties.Settings.Default.Color);
            this.Size = new Size(1600, 900);
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
            Reviews[num] = new Review();
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
            {
                MessageBox.Show("Đã hết dữ liệu!");
                this.lWriter.Text = "Không có dữ liệu";
                this.lSubID.Text = "Không có dữ liệu";
                this.lSubName.Text = "Không có dữ liệu";
                this.lDate.Text = "Không có dữ liệu";
                this.btnLike.Text = "Không có dữ liệu";
                this.btnDislike.Text = "Không có dữ liệu";
                this.tbxDetails.Text = "Không có dữ liệu";
                this.lbLike.Text = "0";
                this.lbDislike.Text = "0";
            }
            else
            {
                this.lWriter.Text = Reviews[temp]._ID_User;
                this.lSubID.Text = Reviews[temp]._SubjectID;
                this.lSubName.Text = Reviews[temp]._Subject;
                this.lDate.Text = Reviews[temp]._Date.ToString();
                this.btnLike.Text = Reviews[temp]._Like.ToString();
                this.btnDislike.Text = Reviews[temp]._Dislike.ToString();
                this.tbxDetails.Text = Reviews[temp]._Details;
                this.lbLike.Text = Reviews[temp]._Like.ToString();
                this.lbDislike.Text = Reviews[temp]._Dislike.ToString();
                if (Reviews[temp].CheckStatus(ID_User) == 1)
                    lbLike.ForeColor = Color.Red;
                else if (Reviews[temp].CheckStatus(ID_User) == 2)
                    lbDislike.ForeColor = Color.Red;
            }
        }
        private void btnLike_Click(object sender, EventArgs e)
        {
            int i = Reviews[temp].CheckStatus(this.ID_User);
            if (i == -1)
            {
                Reviews[temp].FirstReact(ID_User, 0);
                this.lbLike.Text = (int.Parse(this.lbLike.Text) + 1).ToString();
                this.lbLike.ForeColor = Color.Red;
                Reviews[temp]._Like += 1;
                Reviews[temp].SetLike();
            }
            else if (i == 1)
            {
                this.lbLike.Text = (int.Parse(this.lbLike.Text) - 1).ToString();
                Reviews[temp]._Like -= 1;
                Reviews[temp].SetReset();
                this.lbLike.ForeColor = Color.Black;
            }
            else if (i == 2)
            {
                this.lbLike.Text = (int.Parse(this.lbLike.Text) + 1).ToString();
                Reviews[temp]._Like += 1;
                this.lbDislike.Text = (int.Parse(this.lbDislike.Text) - 1).ToString();
                Reviews[temp]._Dislike -= 1;
                Reviews[temp].SetLike();
                this.lbLike.ForeColor = Color.Red;
                this.lbDislike.ForeColor = Color.Black;
            }
            else if (i == 0)
            {
                this.lbLike.Text = (int.Parse(this.lbLike.Text) + 1).ToString();
                Reviews[temp]._Like += 1;
                Reviews[temp].SetLike();
                this.lbLike.ForeColor = Color.Red;
            }
        }
        private void btnDislike_Click(object sender, EventArgs e)
        {
            int i = Reviews[temp].CheckStatus(this.ID_User);
            if (i == -1)
            {
                Reviews[temp].FirstReact(ID_User, 2);
                Reviews[temp].SetDislike();
                this.lbDislike.Text = (int.Parse(this.lbDislike.Text) + 1).ToString();
                Reviews[temp]._Dislike += 1;
                this.lbDislike.ForeColor = Color.Red;
            }
            else if (i == 2)
            {
                Reviews[temp].SetReset();
                this.lbDislike.Text = (int.Parse(this.lbDislike.Text) - 1).ToString();
                Reviews[temp]._Dislike -= 1;
                this.lbDislike.ForeColor = Color.Black;
            }
            else if (i == 1)
            {
                Reviews[temp].SetDislike();
                this.lbDislike.Text = (int.Parse(this.lbDislike.Text) + 1).ToString();
                Reviews[temp]._Dislike += 1;
                this.lbLike.Text = (int.Parse(this.lbLike.Text) - 1).ToString();
                Reviews[temp]._Like -= 1;
                this.lbDislike.ForeColor = Color.Red;
                this.lbLike.ForeColor = Color.Black;
            }
            else if (i == 0)
            {
                Reviews[temp].SetDislike();
                this.lbDislike.Text = (int.Parse(this.lbDislike.Text) + 1).ToString();
                Reviews[temp]._Dislike += 1;
                this.lbDislike.ForeColor = Color.Red;
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            Reviews[temp].UpdateReport();
            MessageBox.Show("Cảm ơn bạn đã báo cáo bài viết! Chúng tôi sẽ xem xét báo cáo của bạn!");
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
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cbbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = cbbCate.Text;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

        }
        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriterRVForm Writer = new WriterRVForm(this, ID_User);
            Writer.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Reviews[temp]._ID_User == ID_User)
            {
                WriterRVForm writerRVForm = new WriterRVForm(this, Reviews[temp]._ID, new string[] { Reviews[temp]._SubjectID, Reviews[temp]._Subject, Reviews[temp]._Details }, Reviews[temp]._Date);
                writerRVForm.Show();
            }
            else
            {
                MessageBox.Show("Đây không phải bài viết của bạn, bạn không thể chỉnh sửa!");
            }
        }
        private void tbxKeyWord_OnValueChanged(object sender, EventArgs e)
        {
            string Query;
            switch (cbbCate.Text)
            {
                case "ID Môn học":
                    Query = "SELECT * FROM REVIEW WHERE SubjectID LIKE '%" + tbxKeyWord.Text + "%'";
                    break;
                case "Người viết":
                    Query = "SELECT * FROM REVIEW WHERE ID_USER LIKE '%" + tbxKeyWord.Text + "%'";
                    break;
                case "Môn học":
                    Query = "SELECT * FROM REVIEW WHERE Subject_ LIKE '%" + tbxKeyWord.Text + "%'";
                    break;
                default:
                    Query = "SELECT * FROM REVIEW WHERE SubjectID LIKE '%" + tbxKeyWord.Text + "%'" + "OR ID_USER LIKE '%" + tbxKeyWord.Text + "%'" + "OR Subject_ LIKE '%" + tbxKeyWord.Text + "%'";
                    break;
            }
            ReadData(Query);
            temp = 0;
            SetReview();
        }
        void SetColor(Color x)
        {
            header.BackColor =
            tbxKeyWord.LineFocusedColor = tbxKeyWord.LineMouseHoverColor = x;
        }
    }
}
