using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentSupportApp
{
    class CScore
    {
        private float fValue;
        private float fWeight;

        public CScore()
        {
            fValue = fWeight = 0;
        }

        public CScore(float a, float b)
        {
            fValue = a;
            fWeight = b;
        }

        public bool InvalidScore()
        {
            if (fValue < 0 || fValue > 10 || fWeight < 0)
                return false;
            return true;
        }

        public float Value
        {
            get
            {
                return this.fValue;
            }

            set
            {
                this.fValue = value;
            }
        }

        public float Weight
        {
            get
            {
                return this.fWeight;
            }

            set
            {
                this.fWeight = value;
            }
        }

        public void Read(StreamReader rd)
        {
            fValue = float.Parse(rd.ReadLine());
            fWeight = float.Parse(rd.ReadLine());
        }

        public void Write(StreamWriter wt)
        {
            wt.WriteLine(fValue.ToString());
            wt.WriteLine(fWeight.ToString());
        }

        public string ToString()
        {
            string sScore = this.fValue.ToString() + "\t" + this.fWeight.ToString();
            return sScore;
        }
    }
}
