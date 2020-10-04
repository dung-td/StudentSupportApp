using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentSupportApp
{
    class TXT
    {
        private ScoreTable tbScore;
        string sPath;
        public ScoreTable SCORETABLE
        {
            get
            {
                return tbScore;

            }
        }

        public TXT()
        {
            tbScore = new ScoreTable();

        }
        public void Read()
        {
            FileStream ftScore = new FileStream("Score.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamReader rd = new StreamReader(ftScore);

            tbScore.Read(rd);
            rd.Close();
            ftScore.Close();
        }

        public void Write()
        {

            sPath = Path.Combine(Directory.GetCurrentDirectory(), "Score.txt");
            StreamWriter wt = new StreamWriter(sPath, true);

            tbScore.Write(wt, sPath);
            wt.Close();
        }

        public void DeleteAllData()
        {
            sPath = Path.Combine(Directory.GetCurrentDirectory(), "Score.txt");
            File.WriteAllText(sPath, "");
        }
    }
}
