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
        private string sInfo;
        TXT txtFile=new TXT();
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

                CScore s1 = new CScore(float.Parse(tbProVa.Text), float.Parse(tbProWei.Text));
                CScore s2 = new CScore(float.Parse(tbMidVa.Text), float.Parse(tbMidWei.Text));
                CScore s3 = new CScore(float.Parse(tbPracVa.Text), float.Parse(tbPracWei.Text));
                CScore s4 = new CScore(float.Parse(tbFinVa.Text), float.Parse(tbFinWei.Text));

                ScoreOfSub scTmp = new ScoreOfSub(tbSubID.Text, tbSubName.Text, int.Parse(tbCredit.Text), s1, s2, s3, s4);

                txtFile.SCORETABLE.DeleteScore(txtFile.SCORETABLE.Find(sInfo));

                txtFile.DeleteAllData();

                txtFile.Write();

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

                CScore s1 = new CScore(float.Parse(tbProVa.Text), float.Parse(tbProWei.Text));
                CScore s2 = new CScore(float.Parse(tbMidVa.Text), float.Parse(tbMidWei.Text));
                CScore s3 = new CScore(float.Parse(tbPracVa.Text), float.Parse(tbPracWei.Text));
                CScore s4 = new CScore(float.Parse(tbFinVa.Text), float.Parse(tbFinWei.Text));

                ScoreOfSub scTmp = new ScoreOfSub(tbSubID.Text, tbSubName.Text, int.Parse(tbCredit.Text), s1, s2, s3, s4);

                txtFile.SCORETABLE.Add(scTmp);

                txtFile.Write();

                Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Show();
        }

        public void Show()
        {
            try
            {
                txtFile.Read();
                lvScoreBoard.Items.Clear();
                txtFile.SCORETABLE.Show(lvScoreBoard);

            }
            catch (Exception err)
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

                CScore s1 = new CScore(float.Parse(tbProVa.Text), float.Parse(tbProWei.Text));
                CScore s2 = new CScore(float.Parse(tbMidVa.Text), float.Parse(tbMidWei.Text));
                CScore s3 = new CScore(float.Parse(tbPracVa.Text), float.Parse(tbPracWei.Text));
                CScore s4 = new CScore(float.Parse(tbFinVa.Text), float.Parse(tbFinWei.Text));

                ScoreOfSub sTmp = new ScoreOfSub(tbSubID.Text, tbSubName.Text, int.Parse(tbCredit.Text), s1, s2, s3, s4);
                sInfo = sTmp.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            
            //try
            //{
                
            //   lvScoreBoard.Items.Clear();

            //    Score s1 = new Score(float.Parse(tbProVa.Text), float.Parse(tbProWei.Text));
            //    Score s2 = new Score(float.Parse(tbMidVa.Text), float.Parse(tbMidWei.Text));
            //    Score s3 = new Score(float.Parse(tbPracVa.Text), float.Parse(tbPracWei.Text));
            //    Score s4 = new Score(float.Parse(tbFinVa.Text), float.Parse(tbFinWei.Text));

            //    ScoreOfSub scTmp = new ScoreOfSub(tbSubID.Text, tbSubName.Text, int.Parse(tbCredit.Text), s1, s2, s3, s4);

            //    txtFile.SCORETABLE.ModifySub(txtFile.SCORETABLE.Find(sInfo), scTmp);

            //    txtFile.DeleteAllData();

            //    txtFile.Write();

            //    Show();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);
            //}
        }
    }
}
