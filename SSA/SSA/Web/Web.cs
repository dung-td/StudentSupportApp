using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentSupportApp
{
    public class Web
    {
        string sTitle;
        string sURL;
        string UserID;
        Connect CONNECT = new Connect();

        public Web()
        {

        }

        public Web(string id, string title, string url)
        {
            this.sTitle = title;
            this.sURL = url;
            this.UserID = id;
        }

        public string URL
        {
            get => sURL;
        }

        public string Title
        {
            get => sTitle;
        }
        public Web(Web tmp)
        {
            this.UserID = tmp.UserID;
            this.sTitle = tmp.sTitle;
            this.sURL = tmp.sURL;
        }

        public void Add()
        {
            try
            {
                CONNECT.OpenConnection();
                string sql = "insert into WEB values(N'" + this.UserID + "', N'" + this.sTitle + "',N'"+this.sURL+"')";
                SqlCommand command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                CONNECT.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete()
        {
            try
            {
                CONNECT.OpenConnection();
                string sql = "delete from WEB where URL_WEB = '"+this.URL+"' and ID_USER = '"+this.UserID+"' and TITLE = '"+this.sTitle+"'" ;
                SqlCommand command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                CONNECT.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Modify(Web web)
        {
            try
            {
                CONNECT.OpenConnection();
                string sql = "update WEB set TITLE = N'"+web.sTitle+"', URL_WEB = N'"+web.sURL+ "' where TITLE = '"+this.sTitle+ "' and URL_WEB = '" + this.sURL + "' and ID_USER = '" + this.UserID + "'";
                SqlCommand command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                CONNECT.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Access()
        {
            try
            {
                System.Diagnostics.Process.Start(this.URL);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ShowToListView(ListView lv, int index)
        {
            try
            {
                lv.Items.Add(this.sTitle.ToString());
                lv.Items[index].SubItems.Add(this.sURL.ToString());
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
