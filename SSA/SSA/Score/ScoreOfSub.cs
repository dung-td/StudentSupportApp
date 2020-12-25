using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace StudentSupportApp
{
    class ScoreOfSub
    {
        private Subject sSubject;
        private CScore[] lScore = new CScore[4];
        private double fAverage;
        Connect CONNECT;

        public ScoreOfSub()
        {
            sSubject = new Subject();
            fAverage = 0;
            for (int i = 0; i < 4; i++)
                lScore[i] = new CScore();
            CONNECT = new Connect();
        }
        public ScoreOfSub(Subject subject, CScore s1, CScore s2, CScore s3, CScore s4)
        {
            CONNECT = new Connect();
            this.sSubject = subject;
            lScore[0] = s1;
            lScore[1] = s2;
            lScore[2] = s3;
            lScore[3] = s4;

            fAverage = ((s1.Value * s1.Weight + s2.Value * s2.Weight + s3.Value * s3.Weight + s4.Value * s4.Weight)
                / (s1.Weight + s2.Weight + s3.Weight + s4.Weight));
            fAverage = Math.Round(fAverage, 1);

            CONNECT.OpenConnection();
            CONNECT.CloseConnection();

        }
        public ScoreOfSub(ScoreOfSub l)
        {

            this.fAverage = l.fAverage;
            this.lScore = l.lScore;
            this.sSubject = l.sSubject;
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
        public Subject SUBJECT
        {
            get
            {
                return this.sSubject;
            }
        }
        public void ShowToListView(ListView lvShow, int index)
        {

            this.sSubject.ShowToListView(lvShow, index);

            for (int i = 0; i < 4; i++)
            {
                if (this.lScore[i].Weight == 0)
                    lvShow.Items[index].SubItems.Add("");
                else
                    lvShow.Items[index].SubItems.Add(this.lScore[i].Value.ToString());
            }

            lvShow.Items[index].SubItems.Add(this.Average.ToString());

            for (int i = 0; i < 4; i++)
            {
                if (this.lScore[i].Weight == 0)
                    lvShow.Items[index].SubItems.Add("");
                else
                    lvShow.Items[index].SubItems.Add(this.lScore[i].Weight.ToString());
            }
        }
   
        public void Modify(string id, ComboBox x)
        {
            try
            {

                CONNECT.OpenConnection();

                string sql = @"DECLARE @value1 AS VARCHAR(5)" +
                    " SET @value1 = '" + this.lScore[0].Value.ToString() + "'" +
                    "set @value1=REPLACE(@value1,',','.')" +
                    " SELECT cast (@value1 as float)" +
                    "DECLARE @value2 AS VARCHAR(5) " +
                    "SET @value2 = '" + this.lScore[1].Value.ToString() + "'" +
                    "set @value2=REPLACE(@value2,',','.')" +
                    "SELECT cast (@value2 as float) " +
                    " DECLARE @value3 AS VARCHAR(5) " +
                    "SET @value3 = '" + this.lScore[2].Value.ToString() + "'" +
                    "set @value3=REPLACE(@value3,',','.')" +
                     " SELECT cast (@value3 as float) " +
                    " DECLARE @value4 AS VARCHAR(5) " +
                    "SET @value4 = '" + this.lScore[3].Value.ToString() + "'" +
                    "set @value4=REPLACE(@value4,',','.')" +
                    " SELECT cast (@value4 as float) " +
                    "DECLARE @value6 AS VARCHAR(5) " +
                    "SET @value6 = '" + this.lScore[0].Weight.ToString() + "'" +
                    "set @value6=REPLACE(@value6,',','.')" +
                    " SELECT cast (@value6 as float) " +
                    " DECLARE @value7 AS VARCHAR(5)" +
                    " SET @value7 = '" + this.lScore[1].Weight.ToString() + "'" +
                    "set @value7=REPLACE(@value7,',','.')" +
                    " SELECT cast (@value7 as float) " +
                    "DECLARE @value8 AS VARCHAR(5)" +
                    "SET @value8 = '" + this.lScore[2].Weight.ToString() + "'" +
                    "set @value8=REPLACE(@value8,',','.')" +
                    " SELECT cast (@value8 as float) " +
                    "DECLARE @value9 AS VARCHAR(5) " +
                    "SET @value9 = '" + this.lScore[3].Weight.ToString() + "'" +
                    "set @value9=REPLACE(@value9,',','.')" +
                    " SELECT cast(@value9 as float) ";

                sql += "UPDATE TableScore SET PRO = @value1, MID = @value2 " +
                           ",  PRAC = @value3,  FIN = @value4, W1 = @value6" +
                           ", W2 = @value7,  W3 = @value8,  W4 = @value9 WHERE(SUB_ID = N'" + this.SUBJECT.ID + "')";

                SqlCommand command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                CONNECT.CloseConnection();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Delete(string id)
        {
            CONNECT.OpenConnection();
            string sql = @"Delete FROM TableScore WHERE(SUB_ID= '" + this.SUBJECT.ID + "')";
            sql += @"Delete From Subjects where(SUB_ID= '" + this.SUBJECT.ID + "' and ID ='" + id + "')";
            SqlCommand command = CONNECT.CreateSQLCmd(sql);
            command.ExecuteNonQuery();
            CONNECT.CloseConnection();
        }

        public void Add(string id, ComboBox x)
        {
            try
            {
                CONNECT.OpenConnection();
                //List<string> sem=new List<string>();

                //string sql = "select distinct SUB_ID from subjects";
                //SqlCommand command = CONNECT.CreateSQLCmd(sql);
                //SqlDataReader reader = command.ExecuteReader();
                //while (reader.HasRows)
                //{
                //    if (reader.Read() == false) break;
                //    sem.Add(reader.GetString(0));
                //}
                //CONNECT.CloseConnection();

                //bool flag = false;
                //foreach (var s in sem)
                //{
                //    if (s == this.SUBJECT.ID)
                //    {
                //        flag = true;
                //        break;
                //    }

                //}

                //if (!flag)
                //{
                string sql = "insert into subjects(ID, SUB_ID, SUB_NAME, CREDIT) values ('" + id + "', '" + this.SUBJECT.ID + "', N'" + this.SUBJECT.Name + "'," +
                  "'" + this.sSubject.Credit + "')";
                // CONNECT.OpenConnection();
                SqlCommand command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                CONNECT.CloseConnection();
                //}

                sql = @"DECLARE @value1 AS VARCHAR(5)" +
                    " SET @value1 = '" + this.lScore[0].Value.ToString() + "'" +
                    "set @value1=REPLACE(@value1,',','.')" +
                    " SELECT cast (@value1 as float)" +
                    "DECLARE @value2 AS VARCHAR(5) " +
                    "SET @value2 = '" + this.lScore[1].Value.ToString() + "'" +
                    "set @value2=REPLACE(@value2,',','.')" +
                    "SELECT cast (@value2 as float) " +
                    " DECLARE @value3 AS VARCHAR(5) " +
                    "SET @value3 = '" + this.lScore[2].Value.ToString() + "'" +
                    "set @value3=REPLACE(@value3,',','.')" +
                     " SELECT cast (@value3 as float) " +
                    " DECLARE @value4 AS VARCHAR(5) " +
                    "SET @value4 = '" + this.lScore[3].Value.ToString() + "'" +
                    "set @value4=REPLACE(@value4,',','.')" +
                    " SELECT cast (@value4 as float) " +
                    "DECLARE @value6 AS VARCHAR(5) " +
                    "SET @value6 = '" + this.lScore[0].Weight.ToString() + "'" +
                    "set @value6=REPLACE(@value6,',','.')" +
                    " SELECT cast (@value6 as float) " +
                    " DECLARE @value7 AS VARCHAR(5)" +
                    " SET @value7 = '" + this.lScore[1].Weight.ToString() + "'" +
                    "set @value7=REPLACE(@value7,',','.')" +
                    " SELECT cast (@value7 as float) " +
                    "DECLARE @value8 AS VARCHAR(5)" +
                    "SET @value8 = '" + this.lScore[2].Weight.ToString() + "'" +
                    "set @value8=REPLACE(@value8,',','.')" +
                    " SELECT cast (@value8 as float) " +
                    "DECLARE @value9 AS VARCHAR(5) " +
                    "SET @value9 = '" + this.lScore[3].Weight.ToString() + "'" +
                    "set @value9=REPLACE(@value9,',','.')" +
                    " SELECT cast(@value9 as float) ";

                sql += @"Insert Into TableScore(ID_USER, SEM_NAME, SUB_ID, SUB_NAME,  CREDIT, PRO, MID,PRAC,FIN, W1, W2, W3, W4)
                VALUES ('" + id + "',N'" + x.SelectedItem.ToString() + "','" + this.SUBJECT.ID + "', N'" + this.SUBJECT.Name + "'," +
                    "'" + this.sSubject.Credit + "', @value1, @value2, @value3 ,  @value4,  @value6 ,  @value7 , @value8 , @value9)";
                CONNECT.OpenConnection();
                command = CONNECT.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                CONNECT.CloseConnection();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}