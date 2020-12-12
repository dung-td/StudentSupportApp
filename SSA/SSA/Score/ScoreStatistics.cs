using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class ScoreStatistics : Form
    {
        string UserID;
        MainForm parent;
        ListSem data;
        Connect CONNECT;
        string sNameOfSem;
        public ScoreStatistics()
        {
            InitializeComponent();
        }

        public ScoreStatistics(MainForm p, string id, string name)
        {
            data = new ListSem();
            CONNECT = new Connect();
            this.UserID = id;
            this.parent = p;
            this.sNameOfSem = name;
            InitializeComponent();

            data.Read(UserID);
            SetColor(Properties.Settings.Default.Color);
            CreateChart();
            //var canvas = new Bunifu.DataViz.Canvas();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScoreStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        void CreateChart()
        {
            chartStatistic.Name = this.sNameOfSem;
            chartStatistic.Series.Add("Điểm số");
            //chartStatistic.Palette = Properties.Settings.Default.Color;

            ScoreTable table = data.GetSemester(data.FindSem(this.sNameOfSem)).SCORETABLE;
            int amount = data.GetSemester(data.FindSem(this.sNameOfSem)).SCORETABLE.Amount;

            for (int i=0; i<amount; i++)
            {
                
                chartStatistic.Series["Điểm số"].Points.AddXY((table.SCOREOFSUB(i).SUBJECT.Name), table.SCOREOFSUB(i).Average);
            }

            chartStatistic.Titles.Add("THỐNG KÊ ĐIỂM: " + this.sNameOfSem );
        }
        void SetColor(Color x)
        {
            panel1.BackColor = bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleForecolor = bExit.IdleLineColor =
            x;
        }
    }
}
