using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class ScoreOfSub
    {
        private string sNameOfSub;
        private string sID;
        private int iCredit;
        private CScore[] lScore = new CScore[4];
        private double fAverage;

        public ScoreOfSub()
        {
            sNameOfSub = "";
            fAverage = 0;
            sID = "";
            fAverage = 0;

            for (int i = 0; i < 4; i++)
                lScore[i] = new CScore();

        }
        public ScoreOfSub(string ID, string name, int cred, CScore s1, CScore s2, CScore s3, CScore s4)
        {
            this.sID = ID;
            this.sNameOfSub = name;
            this.iCredit = cred;
            lScore[0] = s1;
            lScore[1] = s2;
            lScore[2] = s3;
            lScore[3] = s4;

            fAverage = ((s1.Value * s1.Weight + s2.Value * s2.Weight + s3.Value * s3.Weight + s4.Value * s4.Weight)
                / (s1.Weight + s2.Weight + s3.Weight + s4.Weight));
            fAverage = Math.Round(fAverage, 2);

        }
        public ScoreOfSub(ScoreOfSub l)
        {

            this.fAverage = l.fAverage;
            this.lScore = l.lScore;
            this.sNameOfSub = l.sNameOfSub;
        }
        public string Name
        {
            get
            {
                return sNameOfSub;
            }
            set
            {
                sNameOfSub = value;
            }
        }
        public string ID
        {
            get
            {
                return sID;
            }
            set
            {
                sID = value;
            }

        }
        public double Average
        {
            get
            {
                return fAverage;
            }
            set
            {
                fAverage = value;
            }
        }
        public int Credit
        {
            get
            {
                return iCredit;
            }
        }
        public void Show(ListView lvShow, int index)
        {
            lvShow.Items.Add(this.ID);
            lvShow.Items[index].SubItems.Add(this.sNameOfSub);
            lvShow.Items[index].SubItems.Add(this.iCredit.ToString());
            lvShow.Items[index].SubItems.Add(this.lScore[0].Value.ToString());
            lvShow.Items[index].SubItems.Add(this.lScore[1].Value.ToString());
            lvShow.Items[index].SubItems.Add(this.lScore[2].Value.ToString());
            lvShow.Items[index].SubItems.Add(this.lScore[3].Value.ToString());

            lvShow.Items[index].SubItems.Add(this.lScore[0].Weight.ToString());
            lvShow.Items[index].SubItems.Add(this.lScore[1].Weight.ToString());
            lvShow.Items[index].SubItems.Add(this.lScore[2].Weight.ToString());
            lvShow.Items[index].SubItems.Add(this.lScore[3].Weight.ToString());

            lvShow.Items[index].SubItems.Add(this.fAverage.ToString());
        }
        public void Read(StreamReader rd)
        {
            sID = rd.ReadLine();
            sNameOfSub = rd.ReadLine();
            iCredit = int.Parse(rd.ReadLine());

            for (int i = 0; i < 4; i++)
                lScore[i].Read(rd);

        }

        public void Write(StreamWriter wt)
        {
            wt.WriteLine(sID);
            wt.WriteLine(sNameOfSub);
            wt.WriteLine(iCredit);
            for (int i = 0; i < 4; i++)
                lScore[i].Write(wt);
        }
        public string ToString()
        {
            string sInfo;
            sInfo = this.sID + "\t" + this.sNameOfSub + "\t" + this.iCredit.ToString() + "\t";

            for (int i = 0; i < 4; i++)
                sInfo += this.lScore[i].ToString() + "\t";

            return sInfo;
        }
    }
}
