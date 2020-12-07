using System.Windows.Forms;

namespace StudentSupportApp
{
    class Subject
    {
        string sID;
        string sName;
        int iCredit;

        public string ID
        {
            get
            {
                return this.sID;
            }
            set
            {
                this.sID = value;
            }
        }

        public string Name
        {
            get
            {
                return this.sName;
            }
            set
            {
                sName = value;
            }
        }

        public int Credit
        {
            get
            {
                return this.iCredit;
            }

            set
            {
                this.iCredit = value;
            }
        }

        public Subject()
        {
            sID = sName = "";
            iCredit = 0;
        }
        public Subject(string sID, string sName, int iCre)
        {
            this.sID = sID;
            this.sName = sName;
            this.iCredit = iCre;
        }

        public void Read()
        {

        }


        public void Write()
        {

        }

        public void ShowToListView(ListView lvShow, int index)
        {
            lvShow.Items.Add(this.sID);
            lvShow.Items[index].SubItems.Add(this.sName.ToString());
            lvShow.Items[index].SubItems.Add(this.iCredit.ToString());
        }
    }


}