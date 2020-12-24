using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class ChangePass : Form
    {
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
        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        string sUserPass, sID;
        Connect Connection = new Connect();
        MainForm parent;

        public ChangePass()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        public ChangePass(MainForm form, string id, string pass)
        {
            InitializeComponent();
            this.parent = form;
            this.sUserPass = pass;
            this.sID = id;
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetColor(Properties.Settings.Default.Color);
        }

        bool BlankData()
        {
            if (tbNewPass1.Text == "" || tbNewPass2.Text == "" || tbOldPass.Text == "")
            {
                MessageBox.Show("Dữ liệu trống!", "ĐỔI MẬT KHẨU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool CheckOldPass()
        {
            string sCheckLogin = "SELECT PASS FROM USERS WHERE ID_USER = '" + this.sID + "'";
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                MD5Encoder PasswordEncoder = new MD5Encoder();
                if (reader.Read() == false)
                    break;
                if (reader.GetString(0) == PasswordEncoder.FromString(this.tbOldPass.Text))
                {
                    Connection.CloseConnection();
                    return true;
                }
                Connection.CloseConnection();
                return false;
            }
            Connection.CloseConnection();
            return false;
        }
        private int CheckPassword()
        {
            if (tbNewPass1.Text.Length < 8 && tbNewPass2.Text.Length < 8)
                return 2;
            if (tbNewPass1.Text != tbNewPass2.Text)
                return 3;
            return 1;
        }
        private void bChange_Click(object sender, EventArgs e)
        {
            if (!BlankData())
            {
                if (!CheckOldPass())
                    lWrong.Visible = true;
                if (CheckPassword() == 2)
                    lShortPass.Visible = true;
                if (CheckPassword() == 3)
                    lConfirmWrong.Visible = true;

                if (CheckPassword() == 1 && CheckOldPass())
                {
                    ChangePassword();
                    this.Close();
                }
            }
        }
        private void tbOldPass_OnValueChanged(object sender, EventArgs e)
        {
            lWrong.Visible = false;
        }
        private void tbNewPass1_OnValueChanged(object sender, EventArgs e)
        {
            lShortPass.Visible = false;
            lConfirmWrong.Visible = false;
        }
        private void tbNewPass2_OnValueChanged(object sender, EventArgs e)
        {
            lConfirmWrong.Visible = lShortPass.Visible = false;
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangePass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }
        private void tbOldPass_Enter(object sender, EventArgs e)
        {

            tbOldPass.Text = "";
            tbOldPass.isPassword = true;

        }
        private void tbOldPass_Leave(object sender, EventArgs e)
        {
            if (tbOldPass.Text == "")
            {
                tbOldPass.Text = "Mật khẩu cũ";
                tbOldPass.isPassword = false;
            }
        }
        private void tbNewPass1_Leave(object sender, EventArgs e)
        {
            if (tbNewPass1.Text == "")
            {
                tbNewPass1.Text = "Mật khẩu mới";
                tbNewPass1.isPassword = false;
            }
        }
        private void tbNewPass1_Enter(object sender, EventArgs e)
        {
            tbNewPass1.Text = "";
            tbNewPass1.isPassword = true;
        }
        private void tbNewPass2_Leave(object sender, EventArgs e)
        {
            if (tbNewPass2.Text == "")
            {
                tbNewPass2.Text = "Xác nhận mật khẩu mới";
                tbNewPass2.isPassword = false;
            }
        }
        private void tbNewPass2_Enter(object sender, EventArgs e)
        {
            tbNewPass2.Text = "";
            tbNewPass2.isPassword = true;
        }
        private void ChangePass_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        public void ChangePassword()
        {
            try
            {
                MD5Encoder PasswordEncoder = new MD5Encoder();
                string newPass = PasswordEncoder.FromString(tbNewPass1.Text);

                Connection.OpenConnection();
                string sql = @"UPDATE USERS SET PASS ='" + newPass + "' WHERE(ID_USER= '" + sID + "')";
                SqlCommand command = Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                Connection.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            finally
            {
                MessageBox.Show("Đã xong!", "ĐỔI MẬT KHẨU", MessageBoxButtons.OK);
            }

        }
        void SetColor(Color x)
        {
            panel1.BackColor =
                tbOldPass.LineFocusedColor = tbOldPass.LineMouseHoverColor =
                tbNewPass1.LineMouseHoverColor = tbNewPass1.LineFocusedColor =
                tbNewPass2.LineFocusedColor = tbNewPass2.LineMouseHoverColor =
                bChange.ActiveFillColor = bChange.ForeColor = bChange.IdleLineColor = bChange.IdleForecolor =
                 bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleLineColor = bExit.IdleForecolor = x;
        }
    }
}

