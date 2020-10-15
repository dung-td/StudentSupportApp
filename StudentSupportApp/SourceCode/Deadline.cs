using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SSA
{
    class Deadlines
    {
        string sID;
        string sTimeSubmit;
        string sSubject;
        string sSubjectCode;
        string sDetails;
        string bStatus;
        public Deadlines()
        {
            sID = "00000";
            sTimeSubmit = DateTime.Today.ToString();
            sSubject = "Nhap Mon Lap Trinh";
            sSubjectCode = "IT001.K15";
            sDetails = "Nop bai NMLT!";
            bStatus = "Da nop bai";
        }
        public Deadlines(string[] args)
        {
            sID = args[0];
            sSubject = args[1];
            sSubjectCode = args[2];
            sDetails = args[3];
            sTimeSubmit = args[4];
            bStatus = args[5];
        }
        public string TimeRemain
        {
            get
            {
                return sTimeSubmit;
            }
            set
            {
                this.sTimeSubmit = value;
            }
        }
        public string Subject
        {
            get
            {
                return sSubject;
            }
            set
            {
                this.sSubject = value;
            }
        }
        public string SubjectCode
        {
            get
            {
                return sSubjectCode;
            }
            set
            {
                this.sSubjectCode = value;
            }
        }
        public string Details
        {
            get
            {
                return sDetails;
            }
            set
            {
                this.sDetails = value;
            }
        }
        public string Status
        {
            get
            {
                return bStatus;
            }
            set
            {
                this.bStatus = value;
            }
        }
        public void Swap(ref Deadlines DL)
        {
            string temp;
            temp = this.Subject;
            this.Subject = DL.Subject;
            DL.Subject = temp;

            temp = this.SubjectCode;
            this.SubjectCode = DL.SubjectCode;
            DL.SubjectCode = temp;

            temp = this.Details;
            this.Details = DL.Details;
            DL.Details = temp;

            temp = this.Status;
            this.Status = DL.Status;
            DL.Status = temp;

            temp = this.TimeRemain;
            this.TimeRemain = DL.TimeRemain;
            DL.TimeRemain = temp;
        }
    }
}
