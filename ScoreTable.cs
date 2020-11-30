using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class ScoreTable
    {
        List<ScoreOfSub> lSub = new List<ScoreOfSub>();
        private int iSumOfCred;
        private double fAverage;

        public ScoreTable()
        {
            iSumOfCred = 0;
            fAverage = 0;
        }

        public int Amount
        {
            get
            {
                return lSub.Count();
            }
        }

        public int SumOfCred
        {
            get
            {
                iSumOfCred = 0;
                foreach (var s in lSub)
                    iSumOfCred += s.SUBJECT.Credit;
                return iSumOfCred;
            }
        }

        public double Average
        {
            get
            {
                if (lSub.Count > 0)
                {
                    fAverage = 0;
                    foreach (var s in lSub)
                    {
                        fAverage += s.Average * s.SUBJECT.Credit;
                    }
                    return Math.Round(fAverage / SumOfCred, 2);
                }
                return 0;
            }
        }

        public void Add(ScoreOfSub x)
        {
            lSub.Add(x);
        }

        public void Read(StreamReader rd)
        {

        }

        public void Write(StreamWriter wt)
        {

        }

        public void ShowToListView(ListView lvShow)
        {
            for (int i = 0; i < this.Amount; i++)
                lSub[i].ShowToListView(lvShow, i);

        }

        public void DeleteAllScore()
        {
            lSub.Clear();
        }

        //public int Find(string sData)
        //{
        //    for (int i = 0; i < Amount; i++)
        //        if (lSub[i].ToString() == sData)
        //            return i;
        //    return -1;
        //}

        public void ModifySub(int index, ScoreOfSub score)
        {
            // lSub[index] = score;
        }

        public void DeleteScore(int index)
        {
            //ScoreOfSub scDel = lSub[index];
            //lSub.Remove(scDel);
        }


    }
}
