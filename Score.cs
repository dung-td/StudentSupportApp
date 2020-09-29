using System;
using System.Collections.Generic;
using System.Text;


namespace Project
{
    class Score
    {
        private float fValue;
        private float fWeight;

        public Score()
        {
            fValue = fWeight = 0;
        }

        public Score(float a, float b)
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

        public void ImportValue()
        {
            
        }

        public void ImportWeight()
        {
            
        }     


    }
}
