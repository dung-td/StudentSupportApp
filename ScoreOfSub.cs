using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Project
{
    class ScoreOfSub
    {
        private string sNameOfSub;
        private string sID;
        private int iCredit;
        private Score[] list = new Score[4];
        private double fAverage;

        public ScoreOfSub()
        {
            sNameOfSub = "";
            fAverage = 0;
            sID = "";
            fAverage = 0;
        }

        public ScoreOfSub(string ID, string name, int cred, Score s1, Score s2, Score s3, Score s4)
        {
            this.sID = ID;
            this.sNameOfSub = name;
            this.iCredit = cred;
            list[0] = s1;
            list[1] = s2;
            list[2] = s3;
            list[3] = s4;

            fAverage = ((s1.Value * s1.Weight + s2.Value * s2.Weight + s3.Value * s3.Weight + s4.Value * s4.Weight)
                / (s1.Weight + s2.Weight + s3.Weight + s4.Weight));
            fAverage = Math.Round(fAverage,2);
           
        }
        public ScoreOfSub(ScoreOfSub l)
        {
           
            this.fAverage = l.fAverage;
            this.list = l.list;
            this.sNameOfSub = l.sNameOfSub;
        }
        

        public void WriteData()
        {
           
        }
       
        public string ID
        {
            get 
            {
                return sID;
            }

        }
        public double Average
        {
            get
            {
                return fAverage;
            }
        }

        public int Credit
        {
            get
            {
                return iCredit;
            }
        }
    }
}
