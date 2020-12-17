using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class ListWeb
    {
        Connect Connection = new Connect();
        List<Web> list = new List<Web>();
        string UserID;

        public ListWeb(string id)
        {
            UserID = id;
        }  
        
        public int Amount
        {
            get => list.Count();
        }

        public void ReadData()
        {
            try
            {
                this.list.Clear();

                Connection.OpenConnection();
                SqlCommand command = Connection.CreateSQLCmd(@"select * from WEB  where ID_USER = '" + this.UserID + "'");
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    Web tmp = new Web(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    list.Add(tmp);
                }
                Connection.CloseConnection();               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ShowToListView(ListView lv)
        {
            this.list.Clear();
            this.ReadData();
            for (int i=0; i<this.Amount; i++)
                list[i].ShowToListView(lv, i);
        }
    }
}
