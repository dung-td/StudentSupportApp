using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class ScoreTable
    {
        private int iAmount;
        List<ScoreOfSub> lSub = new List<ScoreOfSub>();
        private int iSumOfCred;
        private float fAverage;

        public ScoreTable()
        {
            iAmount = iSumOfCred = 0;
            fAverage = 0;
        }

        public int Amount
        {
            get
            {
                return iAmount;
            }
        }

        public int SumOfCred
        {
            get
            {
                return iSumOfCred;
            }
        }

        public float Average
        {
            get
            {
                return fAverage;
            }
        }

        public void Add(ScoreOfSub x)
        {
            lSub.Add(x);
            iAmount++;
        }

        public void Read(StreamReader rd)
        {
            while (rd.Peek() >= 0)
            {
                ScoreOfSub scTmp = new ScoreOfSub();
                scTmp.Read(rd);
                this.Add(scTmp);
            }
        }

        public void Write(StreamWriter wt, string sPath)
        {
            wt.Close();
            using (wt = new StreamWriter(sPath, true))
            {
                for (int i = 0; i < this.iAmount; i++)
                    lSub[i].Write(wt);

            }
        }

        public void Show(ListView lvShow)
        {

            for (int i = 0; i < this.Amount; i++)
                lSub[i].Show(lvShow, i);
        }

        public int Find(string sData)
        {
            for (int i = 0; i < iAmount; i++)
                if (lSub[i].ToString() == sData)
                    return i;
            return -1;
        }

        public void ModifySub(int index, ScoreOfSub score)
        {
            lSub[index] = score;
        }

        public void DeleteScore(int index)
        {
            ScoreOfSub scDel = lSub[index];
            lSub.Remove(scDel);
            iAmount--;
        }
    }
}
