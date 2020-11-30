using System;

namespace StudentSupportApp
{
    class Deadlines
    {
        string sID;
        DateTime dtTimeSubmit;
        string sSubject;
        string sSubjectCode;
        string sDetails;
        string bStatus;
        public Deadlines()
        {
            sID = "00000";
            dtTimeSubmit = DateTime.Today;
            sSubject = "Nhap Mon Lap Trinh";
            sSubjectCode = "IT001.K15";
            sDetails = "Nop bai NMLT!";
            bStatus = "Da nop bai";
        }
        public Deadlines(string[] args, DateTime DT)
        {
            sID = args[0];
            sSubject = args[1];
            sSubjectCode = args[2];
            sDetails = args[3];
            bStatus = args[4];
            dtTimeSubmit = DT;
        }
        public string ID
        {
            get
            {
                return sID;
            }
            set
            {
                this.sID = value;
            }
        }
        public DateTime TimeSubmit
        {
            get
            {
                return dtTimeSubmit;
            }
            set
            {
                dtTimeSubmit = value;
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

            DateTime temp1 = this.dtTimeSubmit;
            this.dtTimeSubmit = DL.dtTimeSubmit;
            DL.dtTimeSubmit = temp1;
        }
    }
}
