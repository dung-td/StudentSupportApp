using System.IO;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class Semester
    {
        private string sName;
        ScoreTable sctb;


        public Semester()
        {
            sName = "";
            sctb = new ScoreTable();
        }

        public Semester(string s)
        {
            sName = s;
            sctb = new ScoreTable();
        }
        public ScoreTable SCORETABLE
        {
            get
            {
                return this.sctb;
            }
        }

        public string Name
        {
            set
            {
                sName = value;
            }

            get
            {
                return sName;
            }
        }
        public Semester(string sName, ScoreTable sc)
        {
            this.sName = sName;
            this.sctb = sc;
        }

        public void Read(StreamReader rd)
        {
            string sSep = rd.ReadLine();
            sName = rd.ReadLine();
            sctb.Read(rd);
        }

        public void Write(StreamWriter wt)
        {
            wt.WriteLine("|");
            wt.WriteLine(sName);
            sctb.Write(wt);
        }

        public void DeleteScore()
        {
            sctb.DeleteAllScore();
        }

        public void Add(DataGridView dt)
        {
            dt.Rows.Add(sName, this.sctb.SumOfCred.ToString(), this.sctb.Average.ToString());
        }

        public void ShowSemToGridView(DataGridView dt)
        {
            dt.Rows.Add(this.sName, this.SCORETABLE.SumOfCred.ToString(), this.SCORETABLE.Average.ToString());
        }

        public bool IsSimilar(string s)
        {
            if (s == this.sName)
                return true;
            return false;
        }

    }
}
