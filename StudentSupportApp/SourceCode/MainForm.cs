using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSA
{
    
    public partial class MainForm : Form
    {
        USER User;
        LoginForm parent;
        Connect Connection;
        Deadlines[] ListDeadline = new Deadlines[1000];
        public MainForm(LoginForm parent, string User)
        {
            this.User = new USER();
            this.User.ID = User;
            this.parent = parent;
            this.Connection = new Connect();
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Add ADD = new Add(this);
            ADD.addItem = new Add.AddItem(ReLoad);
            ADD.Show();
            this.Hide();
        }
        private void ReLoad(string[] temp)
        {
            this.Connection.OpenConnection();
            this.dataDeadline.Rows.Add(temp[2], temp[1], temp[3], temp[4], temp[5]);
            temp[0] = (dataDeadline.Rows.Count + 1).ToString();
            string Query = "INSERT INTO DEADLINE VALUES('" + temp[0] + "', '" + temp[1] + "', '" + temp[2] + "', '" + 
                                                            temp[3] + "', '" + temp[4] + "', '" + temp[5] + "', '" + this.User.ID + "')";
            SqlCommand command = this.Connection.CreateSQLCmd(Query);
            command.ExecuteNonQuery();
            this.Connection.CloseConnection();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(" All selected items will be delete!", "WARNING!", button);
            foreach (DataGridViewRow row in dataDeadline.SelectedRows)
            {
                dataDeadline.Rows.RemoveAt(row.Index);
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bExport_Click(object sender, EventArgs e)
        {

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            bAdd.Hide();
            bDelete.Hide();
            bEdit.Hide();
            bExport.Hide();
            bSave.Hide();
            bExport.Hide();
            bSave2.Show();
            bCancel.Show();
            textBoxDetail.ReadOnly = false;
            textBoxSubject.ReadOnly = false;
            textBoxTimeRemain.ReadOnly = false;
            textBoxStatus.ReadOnly = false;
        }

        private void bSave2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("SAVED!", "Notification", buttons);
            bAdd.Show();
            bDelete.Show();
            bEdit.Show();
            bExport.Show();
            bSave.Show();
            bExport.Show();
            bSave2.Show();
            bCancel.Hide();
            textBoxDetail.ReadOnly = true;
            textBoxSubject.ReadOnly = true;
            textBoxTimeRemain.ReadOnly = true;
            textBoxStatus.ReadOnly = true;
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            string sQuery = "SELECT * FROM DEADLINE WHERE ID_USER='" + this.User.ID + "'";
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
            SqlDataReader reader = command.ExecuteReader();
            int temp = 0;
            string[] args = new string[5];
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                args[0] = reader.GetString(0);
                args[1] = reader.GetString(1);
                args[2] = reader.GetString(2);
                args[3] = reader.GetString(3);
                args[4] = reader.GetString(4);
                this.ListDeadline[temp] = new Deadlines(args);
            }
            this.Connection.CloseConnection();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Connection.OpenConnection();
            foreach (DataGridViewRow row in dataDeadline.Rows)
            {
                try
                {
                    string Query = "INSERT INTO USERS VALUES('" + row.Cells[0] + "', '" + row.Cells[1] + "', '" + row.Cells[2] + "', '" +
                                                                        row.Cells[3] + "', '" + row.Cells[4] + "')";
                    SqlCommand command = this.Connection.CreateSQLCmd(Query);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while connecting to Server");
                }
                finally
                {
                    this.Connection.CloseConnection();
                }
            }
        }
    }

}
