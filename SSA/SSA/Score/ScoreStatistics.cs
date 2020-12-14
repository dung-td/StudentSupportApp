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
        string parent = "";
        MainForm parent1;
        SemForm parent2;
        ListSem data;
        Connect CONNECT;
        string sNameOfSem ="";
        public ScoreStatistics()
        {
            InitializeComponent();
        }

        public ScoreStatistics(MainForm p, string id, string name)
        {
            data = new ListSem();
            CONNECT = new Connect();
            this.UserID = id;
            this.parent1 = p;
            this.sNameOfSem = name;
            InitializeComponent();

            data.Read(UserID);
            SetColor(Properties.Settings.Default.Color);
            CreateChart();

            parent = "mainform";
            //var canvas = new Bunifu.DataViz.Canvas();
        }

        public ScoreStatistics(SemForm p, string id)
        {
            data = new ListSem();
            CONNECT = new Connect();
            this.UserID = id;
            this.parent2 = p;
            InitializeComponent();

            data.Read(UserID);
            SetColor(Properties.Settings.Default.Color);
            parent = "semform";

            CreateChartOfSemesters();
            //var canvas = new Bunifu.DataViz.Canvas();
        }
        private void bExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void ScoreStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent == "semform")
                this.parent2.Show();
            else
                this.parent1.Show();
        }

        void CreateChart()
        {
            try
            {
                chartStatistic.Name = this.sNameOfSem;
                chartStatistic.Series.Add("Điểm số");
                //chartStatistic.Palette = Properties.Settings.Default.Color;

                ScoreTable table = data.GetSemester(data.FindSem(this.sNameOfSem)).SCORETABLE;
                int amount = data.GetSemester(data.FindSem(this.sNameOfSem)).SCORETABLE.Amount;

                for (int i = 0; i < amount; i++)
                {

                    chartStatistic.Series["Điểm số"].Points.AddXY((table.SCOREOFSUB(i).SUBJECT.Name), table.SCOREOFSUB(i).Average);
                }

                chartStatistic.Titles.Add("THỐNG KÊ ĐIỂM: " + this.sNameOfSem);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        void CreateChartOfSemesters()
        {
            try
            {
                chartStatistic.Series.Add("Điểm trung bình");
                chartStatistic.Series.Add("Số tín chỉ");
                //chartStatistic.Palette = Properties.Settings.Default.Color;

                int amount = data.Amount;

                for (int i = 0; i < amount; i++)
                {
                    chartStatistic.Series["Điểm trung bình"].Points.AddXY((data.GetSemester(i).Name), data.GetSemester(i).SCORETABLE.Average);
                    chartStatistic.Series["Số tín chỉ"].Points.AddXY((data.GetSemester(i).Name), data.GetSemester(i).SCORETABLE.SumOfCred);
                }

                chartStatistic.Titles.Add("THỐNG KÊ ĐIỂM CÁC HỌC KÌ");
            }
            catch(Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, e);
                rp.Show();
            }
        }
        void SetColor(Color x)
        {
            panel1.BackColor = bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleForecolor = bExit.IdleLineColor = bExit.ActiveLineColor =
            x;
        }
    }
}
