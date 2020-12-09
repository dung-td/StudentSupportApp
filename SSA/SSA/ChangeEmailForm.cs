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

namespace StudentSupportApp
{
    public partial class ChangeEmailForm : Form
    {
        EmailVerify emailVerify;
        Connect Connection = new Connect();
        MainForm parent;
        string sID, sPasswd;

        public ChangeEmailForm()
        {
            InitializeComponent();
        }

        public ChangeEmailForm(MainForm parent, string id)
        {
            InitializeComponent();
            this.parent = parent;
            this.sID = id;
            GetEncodedPasswd();
        }

        private void GetEncodedPasswd()
        {
            try
            {
                string sGetPass = "SELECT PASS FROM USERS WHERE ID_USER = '" + this.sID + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sGetPass);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                        break;
                    if (reader.GetString(0) != null)
                    {
                        this.sPasswd = reader.GetString(0);
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                Connection.CloseConnection();
            }
        }

        private void btnExitEmailF_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void tbxCurPass_OnValueChanged(object sender, EventArgs e)
        {
            tbxCurPass.isPassword = true;
            lbWrongPasswd.Visible = false;
        }

        private int CheckCode()
        {
            if (this.emailVerify.GetCode != tbxChangeMailVC.Text)
                return 0;
            else return 1;
        }

        private int CheckEmail()
        {
            if (!(tbxNewEmail.Text.Contains("@")))
                return 0;
            return 1;
        }

        private void btnSendCodeCE_Click(object sender, EventArgs e)
        {
            USER temp = new USER();
            temp.Email = this.tbxNewEmail.Text;

            if (CheckEmail() == 0)
            {
                lbInvalidEmailAddr.Visible = true;
            }
            else if (temp.CheckEmail() == 1)
            {
                this.emailVerify = new EmailVerify(tbxNewEmail.Text);
                this.emailVerify.GetRandomCode();
                this.emailVerify.SendMail();
                lbSentCode.Show();
            }
            else lbUsedEmail.Visible = true;
        }

        private void tbxNewEmail_OnValueChanged(object sender, EventArgs e)
        {
            lbInvalidEmailAddr.Visible = false;
            lbUsedEmail.Visible = false;
            lbSentCode.Visible = false;
        }

        private void btnChangeEmailF_Click(object sender, EventArgs e)
        {
            MD5Encoder PasswdEncoder = new MD5Encoder();

            try
            {
                if (tbxCurPass.Text == "" | tbxChangeMailVC.Text == "" | tbxNewEmail.Text == "")
                {
                    MessageBox.Show("Don't leave your data blank! Please try again!", "Change Email");
                }
                else
                {
                    if (PasswdEncoder.FromString(tbxCurPass.Text) == this.sPasswd && CheckCode() == 1)
                    {
                        try
                        {
                            Connection.OpenConnection();

                            string sql = @"UPDATE USERS SET EMAIL ='" + tbxNewEmail.Text + "' WHERE(ID_USER= '" + sID + "')";
                            SqlCommand command = Connection.CreateSQLCmd(sql);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Changed new email succesfully!", "Change Email");
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message);
                        }
                        finally
                        {
                            Connection.CloseConnection();
                        }
                    }
                    else if (tbxCurPass.Text != this.sPasswd && CheckCode() == 1)
                    {
                        lbWrongPasswd.Visible = true;
                    }
                    else if (tbxCurPass.Text == this.sPasswd && CheckCode() == 0)
                    {
                        lbWrongVeriCode.Visible = true;
                    }
                    else
                    {
                        lbWrongVeriCode.Visible = true;
                        lbWrongPasswd.Visible = true;
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void tbxCurPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxNewEmail.Focus();
        }

        private void tbxNewEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxChangeMailVC.Focus();
        }

        private void tbxChangeMailVC_KeyDown(object sender, KeyEventArgs e)
        {
            btnChangeEmailF_Click(sender, e);
        }

        private void tbxChangeMailVC_OnValueChanged(object sender, EventArgs e)
        {
            lbWrongVeriCode.Visible = false;
        }
    }
}
