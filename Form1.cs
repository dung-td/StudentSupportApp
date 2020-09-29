using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StudentSupportApp
{
    public partial class MainForm : Form
    {
        private List <string> sInfo;
        private string link = @"Data Source=DESKTOP-LRHKKSS\SQLEXPRESS;Initial Catalog=StudentScoreTable;Integrated Security=True";
        private string sql;
        private SqlConnection connect;
        private SqlCommand command;
        private SqlDataReader readfile;

        private ScoreTable SCORETABLE;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabScores_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lvScoreBoard.Items.Clear();
                connect.Open();
                sql = @"Delete FROM TableScore WHERE (ID= N'" + tbSubID.Text + @"')";
                command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Delete successfully! ");
                Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                lvScoreBoard.Items.Clear();
                connect.Open();
                //string aver = Math.Round((
                //    (float.Parse(tbProVa.Text) * float.Parse(tbProWei.Text)
                //    + float.Parse(tbMidWei.Text) * float.Parse(tbMidVa.Text)
                //    + float.Parse(tbPracVa.Text) * float.Parse(tbPracWei.Text)
                //    + float.Parse(tbFinVa.Text) * float.Parse(tbFinWei.Text))
                //    / (float.Parse(tbProWei.Text) + float.Parse(tbMidWei.Text) + float.Parse(tbPracWei.Text) + float.Parse(tbFinWei.Text))
                //    ),2).ToString();

                Score s1 = new Score(float.Parse(tbProVa.Text), float.Parse(tbProWei.Text));
                Score s2 = new Score(float.Parse(tbMidVa.Text), float.Parse(tbMidWei.Text));
                Score s3 = new Score(float.Parse(tbPracVa.Text), float.Parse(tbPracWei.Text));
                Score s4 = new Score(float.Parse(tbFinVa.Text), float.Parse(tbFinWei.Text));

                ScoreOfSub SCOREOFSUB = new ScoreOfSub(tbSubID.Text, tbSubName.Text, int.Parse(tbCredit.Text), s1, s2, s3, s4);
                string aver = (SCOREOFSUB.Average).ToString();

                sql = @"Insert Into TableScore(ID, SUBJECT, CREDIT, PROCESS, MID, PRACT, FINAL, W1, W2, W3, W4, AVER)
VALUES (N'" + tbSubID.Text + @"', N'" + tbSubName.Text + @"', N'" + tbCredit.Text + @"', N'" + tbProVa.Text + @"', 
N'" + tbMidVa.Text + @"', N'" + tbPracVa.Text + @"', N'" + tbFinVa.Text + @"', N'" + tbProWei.Text + @"', 
N'" + tbMidWei.Text + @"', N'" + tbPracWei.Text + @"', N'" + tbFinWei.Text + @"', N'" + aver + @"')";


                //sql = @"Insert Into TableScore(ID, SUBJECT, CREDIT, PROCESS, MID, PRACT, FINAL, W1, W2, W3, W4, AVER)
                //VALUES (N'" + tbSubID.Text + @"', N'" + tbSubName.Text + @"', N'" + tbCredit.Text + @"', N'" + tbProVa.Text + @"', 
                //N'" + tbMidVa.Text + @"', N'" + tbPracVa.Text + @"', N'" + tbFinVa.Text + @"', N'" + tbProWei.Text + @"', 
                //N'" + tbMidWei.Text + @"', N'" + tbPracWei.Text + @"', N'" + tbFinWei.Text + @"', N'" + SCOREOFSUB.Average.ToString() + @"')";
                command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
                Show();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(link);
            Show();
            connect.Close();
        }

        //public void GetScoreOfSub()
        //{
        //    lvScoreBoard.Items.Clear();
        //    connect.Open();
        //    sql = @"Select ID, SUBJECT, CREDIT, PROCESS, MID, PRACT, FINAL, W1, W2, W3, W4, AVER
        //        FROM TableScore";
        //    command = new SqlCommand(sql, connect);
        //    readfile = command.ExecuteReader();
        //    int i = 0;
        //    while (readfile.Read())
        //    { 
        //        Score s1 = new Score(float.Parse(readfile[3].ToString()), float.Parse(readfile[7].ToString()));
        //        Score s2 = new Score(float.Parse(readfile[4].ToString()), float.Parse(readfile[8].ToString()));
        //        Score s3 = new Score(float.Parse(readfile[5].ToString()), float.Parse(readfile[9].ToString()));
        //        Score s4 = new Score(float.Parse(readfile[3].ToString()), float.Parse(readfile[7].ToString()));
        //        ScoreOfSub SCOREOFSUB = new ScoreOfSub(readfile[0].ToString(), readfile[1].ToString(), int.Parse(readfile[2].ToString()), s1, s2, s3, s4);
        //        SCORETABLE.Add(SCOREOFSUB);
        //        i++;
        //    }
        //    connect.Close();
        //}
        public void Show()
        {
            try
            {
                lvScoreBoard.Items.Clear();
                connect.Open();
                sql = @"Select ID, SUBJECT, CREDIT, PROCESS, MID, PRACT, FINAL, W1, W2, W3, W4, AVER
                FROM TableScore";
                command = new SqlCommand(sql, connect);
                readfile = command.ExecuteReader();
                int i = 0;
                while (readfile.Read())
                {
                    lvScoreBoard.Items.Add(readfile[0].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[1].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[2].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[3].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[4].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[5].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[6].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[7].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[8].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[9].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[10].ToString());
                    lvScoreBoard.Items[i].SubItems.Add(readfile[11].ToString());
                    i++;

                }
                connect.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void lvScoreBoard_Click(object sender, EventArgs e)
        {
            try
            {
                tbSubID.Text = lvScoreBoard.SelectedItems[0].SubItems[0].Text;
                tbSubName.Text = lvScoreBoard.SelectedItems[0].SubItems[1].Text;
                tbCredit.Text = lvScoreBoard.SelectedItems[0].SubItems[2].Text;

                tbProVa.Text = lvScoreBoard.SelectedItems[0].SubItems[3].Text;
                tbMidVa.Text = lvScoreBoard.SelectedItems[0].SubItems[4].Text;
                tbPracVa.Text = lvScoreBoard.SelectedItems[0].SubItems[5].Text;
                tbFinVa.Text = lvScoreBoard.SelectedItems[0].SubItems[6].Text;

                tbProWei.Text = lvScoreBoard.SelectedItems[0].SubItems[7].Text;
                tbMidWei.Text = lvScoreBoard.SelectedItems[0].SubItems[8].Text;
                tbPracWei.Text = lvScoreBoard.SelectedItems[0].SubItems[9].Text;
                tbFinWei.Text = lvScoreBoard.SelectedItems[0].SubItems[10].Text;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void GetInfo(List <string> l)
        {
            sInfo = new List<string>();
            sInfo = l;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lvScoreBoard.Items.Clear();
                connect.Open();
                sql = @"UPDATE TableScore SET
            ID=N'" + tbSubID.Text + @"', SUBJECT = N'" + tbSubName.Text + @"',CREDIT= N'" + tbCredit.Text + @"',
            PROCESS=N'" + tbProVa.Text + @"', MID=N'" + tbMidVa.Text + @"',  PRACT=N'" + tbPracVa.Text + @"',  FINAL =N'" + tbFinVa.Text + @"', 
            W1=N'" + tbProWei.Text + @"', W2=N'" + tbMidWei.Text + @"',  W3=N'" + tbPracWei.Text + @"',  W4 =N'" + tbFinWei.Text + @"'
            WHERE (ID = N'" + tbSubID.Text + @"')";

                command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
                Show();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

