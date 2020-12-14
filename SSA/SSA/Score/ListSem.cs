using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class ListSem
    {
        private List<Semester> listSem;
        Connect CONNECT;
        public ListSem()
        {
            listSem = new List<Semester>();
            CONNECT = new Connect();
        }
        public List<Semester> SEMESTERS
        {
            get
            {
                return this.listSem;
            }
        }

        public int Amount
        {
            get
            {
                return this.listSem.Count;
            }
        }
        public int FindSem(string sem)
        {
            for (int i = 0; i < this.listSem.Count(); i++)
                if (sem == listSem[i].Name)
                    return i;
            return -1;
        }

        public Semester GetSemester(int index)
        {
            return listSem[index];
        }

        public void Read(string x)
        {

            this.SEMESTERS.Clear();

            CONNECT.OpenConnection();
            SqlCommand command = CONNECT.CreateSQLCmd(@"select distinct SEM_NAME from SEMESTER where ID = '" + x + "'");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                Semester sem = new Semester(reader.GetString(0));
                listSem.Add(sem);
            }
            CONNECT.CloseConnection();

            CONNECT.OpenConnection();
            command = CONNECT.CreateSQLCmd(@"select * from TABLESCORE where ID_USER = '" + x + "'");
            reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false)
                    break;

                string sNameOfSem = reader.GetString(1);
                string sID = reader.GetString(2);
                string sName = reader.GetString(3);
                int iCredit = reader.GetByte(4);

                Subject sub = new Subject(sID, sName, iCredit);
                CScore s1 = new CScore((float)reader.GetSqlDouble(5), (float)reader.GetSqlDouble(9));
                CScore s2 = new CScore((float)reader.GetSqlDouble(6), (float)reader.GetSqlDouble(10));
                CScore s3 = new CScore((float)reader.GetSqlDouble(7), (float)reader.GetSqlDouble(11));
                CScore s4 = new CScore((float)reader.GetSqlDouble(8), (float)reader.GetSqlDouble(12));

                ScoreOfSub score = new ScoreOfSub(sub, s1, s2, s3, s4);

                foreach (var sem in listSem)
                    if (sem.Name == sNameOfSem)
                        sem.SCORETABLE.Add(score);
            }

            CONNECT.CloseConnection();

        }
        public void ShowSemToGridView(DataGridView dt)
        {
            foreach (var sem in listSem)
                sem.ShowSemToGridView(dt);
        }

        public int SumOfCre
        {
            get
            {
                int iSumOfCre = 0;
                foreach (var sem in listSem)
                    iSumOfCre += sem.SCORETABLE.SumOfCred;
                return iSumOfCre;
            }
        }

        public double Average
        {
            get
            {
                double fAverage = 0;

                foreach (var sem in listSem)
                    fAverage += sem.SCORETABLE.SumOfCred * sem.SCORETABLE.Average;

                if (fAverage == 0 || SumOfCre == 0)
                    return 0;

                return Math.Round(fAverage / SumOfCre, 2);
            }
        }

    }
}