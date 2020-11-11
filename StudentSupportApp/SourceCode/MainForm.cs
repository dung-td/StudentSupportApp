using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSA
{
    public partial class MainForm : Form
    {
        USER User;
        LoginForm parent;
        Connect Connection;
        Deadlines[] ListDeadline = new Deadlines[1000];
        ListSem data = new ListSem();
        public MainForm(LoginForm parent, string User)
        {
            this.User = new USER(User);
            this.User.ID = User;
            this.parent = parent;
            this.Connection = new Connect();
            ListSem data = new ListSem();
            data.Read(this.User.ID);
            InitializeComponent();
            lAverAll.Text = "Average: " + data.Average.ToString();
            lCreSum.Text = "Sum of Credits: " + data.SumOfCre.ToString();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lbHello.Text = "Hello, " + this.User.Name + "! Wish you a good day!";

            // DUNG
            string sQuery = "SELECT * FROM DEADLINE WHERE ID_USER='" + this.User.ID + "'";
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
            SqlDataReader reader = command.ExecuteReader();
            int temp = 0;
            string[] args = new string[5];
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                args[0] = reader.GetString(0);
                args[1] = reader.GetString(1);
                args[2] = reader.GetString(2);
                args[3] = reader.GetString(3);
                DateTime temp1 = reader.GetDateTime(4);
                args[4] = reader.GetString(5);
                this.ListDeadline[temp] = new Deadlines(args, temp1);
                temp++;
            }
            this.Connection.CloseConnection();
            foreach (Deadlines DL in this.ListDeadline)
            {
                if (DL == null)
                    break;
                dataDeadline.Rows.Add(DL.ID, DL.SubjectCode, DL.Subject, DL.Details, DL.TimeSubmit, DL.Status);
            }
            NearestDeadline();


            // DANH
            dataGridViewHomeTimeTB.Columns[1].HeaderText = DateTime.Today.DayOfWeek.ToString();
            string[] sRow = new string[] {"Lesson 1\n(7:30-8:15)", "Lesson 2\n(8:15-9:00)",
                "Lesson 3\n(9:00 - 9:45)" , "Lesson 4\n(10:00-10:45)", "Lesson 5\n(10:45-11:30)",
                "Lesson 6\n(13:00-13:45)", "Lesson 7\n(13:45-14:30)", "Lesson 8\n(14:30-15:15)",
                "Lesson 9\n(15:30-16:15)", "Lesson 10\n(16:15-17:00)"};
            for (int i = 0; i < sRow.Length; i++)
            {
                dataGridViewTimetable.Rows.Add(sRow[i]);
                dataGridViewHomeTimeTB.Rows.Add(sRow[i]);
            }

            List<string> sLesson = new List<string> { };
            LoadTodayTimetable(dataGridViewHomeTimeTB.Columns[1].HeaderText.ToString(), ref sLesson);
            LoadTimetableToHomeDGV(dataGridViewHomeTimeTB, sLesson);

            ReadSchedulesSemesterComboboxItems();

            LoadInformationTab();

            // LINH
            AddItemToComboBoxSemester();
            tbCredit.Enabled = tbSubID.Enabled = tbSubName.Enabled = tbProVa.Enabled = tbProWei.Enabled
                = tbMidVa.Enabled = tbMidWei.Enabled = tbFinVa.Enabled = tbFinWei.Enabled = false;
            bAddScore.Enabled = bModify.Enabled = bDel.Enabled = false;
            
        }

        // NOTIFICATION TAB -- DUC DUNG //
        private void bAdd_Click(object sender, EventArgs e)
        {
            Add ADD = new Add(this);
            ADD.addItem = new Add.AddItem(ReLoad);
            ADD.Show();
            this.Hide();
        }
        private void ReLoad(string[] temp)
        {
            this.Connection.OpenConnection();
            temp[0] = "1";
            User.GetDeadlineID(ref temp[0]);
            this.dataDeadline.Rows.Add(temp[0], temp[2], temp[1], temp[3], temp[4], temp[5]);
            string Query = "INSERT INTO DEADLINE VALUES('" + temp[0] + "', '" + temp[1] + "', '" + temp[2] + "', '" + 
                                                            temp[3] + "', '" + temp[4] + "', '" + temp[5] + "', '" + this.User.ID + "')";
            SqlCommand command = this.Connection.CreateSQLCmd(Query);
            command.ExecuteNonQuery();
            this.Connection.CloseConnection();
        }
        private void bDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(" All selected items will be delete!", "WARNING!", button);
            foreach (DataGridViewRow row in dataDeadline.SelectedRows)
            {
                this.Connection.OpenConnection();
                string Query = "DELETE FROM DEADLINE WHERE ID ='" + row.Cells[0].Value + "'";
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
                this.Connection.CloseConnection();
                dataDeadline.Rows.RemoveAt(row.Index);
            }
        }
        private void bUpdate_Click(object sender, EventArgs e)
        {

        }
        private void bExport_Click(object sender, EventArgs e)
        {

        }
        private void bEdit_Click(object sender, EventArgs e)
        {
            bAdd.Hide();
            bDelete.Hide();
            bEdit.Hide();
            bExport.Hide();
            bSave.Hide();
            bExport.Hide();
            bRefresh.Hide();
            bSave2.Show();
            bCancel.Show();
            textBoxDetail.ReadOnly = false;
            textBoxTimeRemain.ReadOnly = false;
            textBoxStatus.ReadOnly = false;
        }
        private void bSave2_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "UPDATE DEADLINE SET DETAIL='" + textBoxDetail.Text + "', DATESUBMIT='" + dateTimePickerTimeSubmit.Value.ToString() + "', STAT='" + textBoxStatus.Text
                                                              + "' WHERE ID='" + ID.Text + "'";
                Connection.OpenConnection();
                SqlCommand command = Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("SAVED!", "Notification", buttons);
                bAdd.Show();
                bDelete.Show();
                bEdit.Show();
                bExport.Show();
                //bSave.Show();
                bExport.Show();
                bRefresh.Show();
                bSave2.Hide();
                bCancel.Hide();
                textBoxDetail.ReadOnly = true;
                textBoxSubject.ReadOnly = true;
                textBoxTimeRemain.ReadOnly = true;
                textBoxStatus.ReadOnly = true;
                Connection.CloseConnection();
            }
        }
        private void bRefresh_Click(object sender, EventArgs e)
        {
            while (dataDeadline.Rows.Count > 0)
            {
                dataDeadline.Rows.RemoveAt(0);
            }
            string sQuery = "SELECT * FROM DEADLINE WHERE ID_USER='" + this.User.ID + "'";
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
            SqlDataReader reader = command.ExecuteReader();
            int temp = 0;
            string[] args = new string[5];
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                args[0] = reader.GetString(0);
                args[1] = reader.GetString(1);
                args[2] = reader.GetString(2);
                args[3] = reader.GetString(3);
                DateTime temp1 = reader.GetDateTime(4);
                args[4] = reader.GetString(5);
                this.ListDeadline[temp] = new Deadlines(args, temp1);
                temp++;
            }
            this.Connection.CloseConnection();
            foreach (Deadlines DL in this.ListDeadline)
            {
                if (DL == null)
                    break;
                dataDeadline.Rows.Add(DL.ID, DL.SubjectCode, DL.Subject, DL.Details, DL.TimeSubmit, DL.Status);
            }
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            this.Connection.OpenConnection();
            foreach (DataGridViewRow row in dataDeadline.Rows)
            {
                try
                {
                    string Query = "INSERT INTO USERS VALUES('" + row.Cells[0] + "', '" + row.Cells[1] + "', '" + row.Cells[2] + "', '" +
                                                                        row.Cells[3] + "', '" + row.Cells[4] + "')";
                    SqlCommand command = this.Connection.CreateSQLCmd(Query);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while connecting to Server");
                }
                finally
                {
                    this.Connection.CloseConnection();
                }
            }
        }
        private void dataDeadline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDeadline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataDeadline.CurrentRow.Selected = true;
                ID.Text = dataDeadline.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxSubject.Text = dataDeadline.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxDetail.Text = dataDeadline.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxTimeRemain.Text = dataDeadline.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxStatus.Text = dataDeadline.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        // TIMETABLE TAB -- CONG DANH //
        private void cbxSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoadTT.Enabled = true;
            btnSetDefault.Enabled = true;
        }
        private void btnLoadTT_Click(object sender, EventArgs e)
        {
            Timetable UserSchedules = new Timetable(this.User.ID, cbxSem.Text);
            UserSchedules.LoadUserTimetable();
            UserSchedules.LoadTimetableToDGV(dataGridViewTimetable);
            btnModify.Enabled = true;
            btnExportTT.Enabled = true;
        }
        private void btnCreNewLess_Click(object sender, EventArgs e)
        {
            AddLessonForm AddLesson = new AddLessonForm(this, this.User.ID);
            AddLesson.Show();
            this.Hide();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            ModLessonForm modifier = new ModLessonForm(this, this.User.ID, cbxSem.Text);
            modifier.Show();
            this.Hide();
        }
        private void btnSetDefault_Click(object sender, EventArgs e)
        {

        }

        public void LoadTodayTimetable(string today, ref List<string> Lesson)
        {
            Connect loadHomeTimetable = new Connect();
            loadHomeTimetable.OpenConnection();

            string sWeekDay = dataGridViewHomeTimeTB.Columns[1].HeaderText.ToString();
            for (int i = 1; i <= 10; i++)
            {
                string sLoadData = "select SUB_NAME from LESSON where ID_USER='" + this.User.ID
                                    + "' AND DAYINWEEK='" + sWeekDay + "' AND SEM_NAME='HK1'"
                                    + " AND TIMEORDER=" + i;
                SqlCommand loadDay = loadHomeTimetable.CreateSQLCmd(sLoadData);
                SqlDataReader reader = loadDay.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }
                    Lesson.Add(reader.GetString(0));
                }
                else Lesson.Add("");
                reader.Close();
            }
            loadHomeTimetable.CloseConnection();
        }

        public void LoadTimetableToHomeDGV(DataGridView obj, List<string> Lesson)
        {
            int iLessonIndex = 0;
            for (int i = 0; i < 10; i++)
            {
                obj.Rows[i].Cells[1].Value = Lesson[iLessonIndex];
                iLessonIndex++;
            }
        }

	// SCORETAB -- KHANH LINH
        public void ShowToListView(string semester)
        {
            try
            {
                bDel.Enabled = false;
                bModify.Enabled = false;
                //lvScoreBoard.Clear();
                data.SEMESTERS.Clear();
                data.Read(this.User.ID);
                data.GetSemester(data.FindSem(semester)).SCORETABLE.ShowToListView(lvScoreBoard);

                lAmountSub.Text = "Amount of subjects: " + data.GetSemester(data.FindSem(semester)).SCORETABLE.Amount.ToString();
                l_Average.Text = "Average: " + data.GetSemester(data.FindSem(semester)).SCORETABLE.Average.ToString();
                lSumCre.Text = "Sum of credits: " + data.GetSemester(data.FindSem(semester)).SCORETABLE.SumOfCred.ToString();

                tbSubID.Text = tbSubName.Text = tbCredit.Text = tbProVa.Text = tbMidVa.Text = tbPracVa.Text = tbFinVa.Text
               = tbProWei.Text = tbMidWei.Text = tbPracWei.Text = tbFinWei.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void bModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (BlankData())
                {
                    MessageBox.Show("Blank data! \nMake sure that your SUBJECT ID, SUBJECT NAME and CREDIT not null. " +
                        "\nIf your score is null, please enter '0' for VALUE and RATIO ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string message = "Are you sure that you would like to modify?";
                    string caption = "Modify";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Subject sub = new Subject(tbSubID.Text, tbSubName.Text, int.Parse(tbCredit.Text));
                        CScore s1 = new CScore(float.Parse(tbProVa.Text), float.Parse(tbProWei.Text));
                        CScore s2 = new CScore(float.Parse(tbMidVa.Text), float.Parse(tbMidWei.Text));
                        CScore s3 = new CScore(float.Parse(tbPracVa.Text), float.Parse(tbPracWei.Text));
                        CScore s4 = new CScore(float.Parse(tbFinVa.Text), float.Parse(tbFinWei.Text));

                        ScoreOfSub scTmp = new ScoreOfSub(sub, s1, s2, s3, s4);
                        MessageBox.Show("Done!", caption);

                        lvScoreBoard.Items.Clear();
                        scTmp.Modify(this.User.ID, cbSemester);

                        ShowToListView(cbSemester.SelectedItem.ToString());
                    }
                    bAdd.Enabled = true;
                    tbSubID.Enabled = tbSubName.Enabled = tbCredit.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private bool BlankData()
        {
            if (tbSubID.Text == "" || tbSubName.Text == "" || tbCredit.Text == "" ||
                tbProVa.Text == "" || tbProWei.Text == "" || tbMidVa.Text == "" || tbMidWei.Text == "" ||
                tbPracVa.Text == "" || tbPracWei.Text == "" || tbFinVa.Text == "" || tbFinWei.Text == "")
                return true;
            return false;
        }

        private void bAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (BlankData())
                {
                    MessageBox.Show("Blank data! \nMake sure that your SUBJECT ID, SUBJECT NAME and CREDIT not null." +
                        "\nIf your score is null, please enter '0' for VALUE and RATIO ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Subject sub = new Subject(tbSubID.Text, tbSubName.Text, int.Parse(tbCredit.Text));
                    CScore s1 = new CScore(float.Parse(tbProVa.Text), float.Parse(tbProWei.Text));
                    CScore s2 = new CScore(float.Parse(tbMidVa.Text), float.Parse(tbMidWei.Text));
                    CScore s3 = new CScore(float.Parse(tbPracVa.Text), float.Parse(tbPracWei.Text));
                    CScore s4 = new CScore(float.Parse(tbFinVa.Text), float.Parse(tbFinWei.Text));

                    ScoreOfSub scTmp = new ScoreOfSub(sub, s1, s2, s3, s4);
                    scTmp.Add(this.User.ID, cbSemester);
                    MessageBox.Show("Done!", "ADD NEW SCORE");

                    lvScoreBoard.Items.Clear();
                    ShowToListView(cbSemester.SelectedItem.ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
        private void bDel_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure that you would like to delete?";
                string caption = "Delete";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Connection.OpenConnection();
                    string sql = @"Delete FROM TableScore WHERE(SUB_ID= '" + tbSubID.Text + "')";

                    SqlCommand command = Connection.CreateSQLCmd(sql);
                    command.ExecuteNonQuery();
                    Connection.CloseConnection();
                    MessageBox.Show("Done!", caption);

                    lvScoreBoard.Items.Clear();
                    ShowToListView(cbSemester.SelectedItem.ToString());
                }
                bAdd.Enabled = true;
                tbSubID.Enabled = tbSubName.Enabled = tbCredit.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bSem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SemForm form = new SemForm(this, this.User.ID);
            form.Show();
        }

        private void timerTimeRemain_Tick(object sender, EventArgs e)
        {

        }

        public void AddItemToComboBoxSemester()
        {
            cbSemester.Items.Clear();
            List<string> sItem = new List<string>();

            Connection.OpenConnection();
            SqlCommand command = Connection.CreateSQLCmd("select distinct SEM_NAME from SEMESTER");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                sItem.Add(reader.GetString(0));
            }
            foreach (var sem in sItem)
                cbSemester.Items.Add(sem);

            lvScoreBoard.Items.Clear();
            Connection.CloseConnection();

            lAmountSub.Text = "Amount of subjects: ";
            l_Average.Text = "Average: ";
            lSumCre.Text = "Sum of credits:";
        }

        private void cbScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSemester = cbSemester.SelectedItem.ToString();
            data.SEMESTERS.Clear();
            data.Read(this.User.ID);
            lvScoreBoard.Items.Clear();
            ShowToListView(sSemester);

            bAddScore.Enabled = bModify.Enabled = bDel.Enabled = true;
            tbSubID.Enabled = tbSubName.Enabled = tbCredit.Enabled = true;
            tbMidVa.Enabled = tbMidWei.Enabled = true;
            tbPracVa.Enabled = tbPracWei.Enabled = true;
            tbProVa.Enabled = tbProWei.Enabled = true;
            tbFinVa.Enabled = tbFinWei.Enabled = true;
            data.SEMESTERS.Clear();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
            this.Hide();
        }

        public void NearestDeadline()
        {
            Deadlines[] temp = new Deadlines[5];
            string Top5Deadlilne = "SELECT TOP (5) * FROM DEADLINE WHERE ID_USER='" + this.User.ID + "' ORDER BY DEADLINE.DATESUBMIT ASC";
            this.Connection.OpenConnection();
            SqlCommand command = this.Connection.CreateSQLCmd(Top5Deadlilne);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false)
                {
                    break;
                }
                dataNearDead.Rows.Add(reader.GetString(1), reader.GetString(3), reader.GetDateTime(4).ToString(), reader.GetString(5));
            }
            reader.Close();
            this.Connection.CloseConnection();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            bAdd.Show();
            bDelete.Show();
            bEdit.Show();
            bExport.Show();
            bSave.Show();
            bExport.Show();
            bRefresh.Show();
            bSave2.Hide();
            bCancel.Hide();
            textBoxDetail.ReadOnly = true;
            textBoxSubject.ReadOnly = true;
            textBoxTimeRemain.ReadOnly = true;
            textBoxStatus.ReadOnly = true;
            Connection.CloseConnection();
        }

        private void btnExportTT_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetable.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Timetable.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridViewTimetable.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_MIDDLE;

                            foreach (DataGridViewColumn column in dataGridViewTimetable.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridViewTimetable.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data exported successfully!!!", "Export Timetable");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!!!", "Info");
            }
        }

        private void lvScoreBoard_Click(object sender, EventArgs e)
        {
            try
            {
                bAdd.Enabled = false;
                bDel.Enabled = true;
                bModify.Enabled = true;

                tbSubID.Text = lvScoreBoard.SelectedItems[0].SubItems[0].Text;
                tbSubName.Text = lvScoreBoard.SelectedItems[0].SubItems[1].Text;
                tbCredit.Text = lvScoreBoard.SelectedItems[0].SubItems[2].Text;

                for (int i = 3; i < 12; i++)
                    if (lvScoreBoard.SelectedItems[0].SubItems[i].Text == "")
                        lvScoreBoard.SelectedItems[0].SubItems[i].Text = "0";

                tbProVa.Text = lvScoreBoard.SelectedItems[0].SubItems[3].Text;
                tbMidVa.Text = lvScoreBoard.SelectedItems[0].SubItems[4].Text;
                tbPracVa.Text = lvScoreBoard.SelectedItems[0].SubItems[5].Text;
                tbFinVa.Text = lvScoreBoard.SelectedItems[0].SubItems[6].Text;

                tbProWei.Text = lvScoreBoard.SelectedItems[0].SubItems[8].Text;
                tbMidWei.Text = lvScoreBoard.SelectedItems[0].SubItems[9].Text;
                tbPracWei.Text = lvScoreBoard.SelectedItems[0].SubItems[10].Text;
                tbFinWei.Text = lvScoreBoard.SelectedItems[0].SubItems[11].Text;

                for (int i = 7; i < 12; i++)
                    if (lvScoreBoard.SelectedItems[0].SubItems[i].Text == "0")
                        lvScoreBoard.SelectedItems[0].SubItems[i - 5].Text = "";

                tbSubID.Enabled = tbSubName.Enabled = tbCredit.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tbCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode ==Keys.Delete || e.KeyCode==Keys.Tab))
            {
                MessageBox.Show("Enter a number");
            }
        }

        private void tbProVa_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Enter a number");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Use ',' to enter float value");

        }

        private void tbProWei_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Enter a number");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Use ',' to enter float value");
        }

        private void tbMidVa_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Enter a number");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Use ',' to enter float value");
        }

        private void tbMidWei_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Enter a number");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Use ',' to enter float value");
        }

        private void tbPracVa_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Enter a number");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Use ',' to enter float value");
        }

        private void tbPracWei_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Enter a number");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Use ',' to enter float value");
        }

        private void tbFinVa_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Enter a number");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Use ',' to enter float value");
        }

        private void tbFinWei_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Enter a number");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Use ',' to enter float value");
        }

        private void ReadSchedulesSemesterComboboxItems()
        {
            cbxSem.Items.Clear();
            List<string> sItem = new List<string>();

            Connection.OpenConnection();
            SqlCommand command = Connection.CreateSQLCmd("select distinct SEM_NAME from LESSON where ID_USER='" + this.User.ID + "'");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                sItem.Add(reader.GetString(0));
            }
            foreach (var sem in sItem)
                cbxSem.Items.Add(sem);

            Connection.CloseConnection();
        }

        private void LoadInformationTab()
        {
           
            Connect Info = new Connect();
            Info.OpenConnection();

            List<string> sData = new List<string>();

            SqlCommand command = Info.CreateSQLCmd("select * from USERS where ID_USER='" + this.User.ID + "'");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                sData.Add(reader.GetString(0));
                sData.Add(reader.GetString(1));
                sData.Add(reader.GetDateTime(2).ToString().Substring(0, 9));
                sData.Add(reader.GetString(3));
                sData.Add(reader.GetString(4));
                sData.Add(reader.GetString(5));
                sData.Add(reader.GetString(6));
            }
            Info.CloseConnection();

            ShowUserInformation(sData);
        }

        private void ShowUserInformation(List<string> data)
        {
            lbID.Text = data[0];
            lbEmail.Text = data[1];
            lbBirthday.Text = data[2];

            lbName.Text = data[4];
            lbClass.Text = data[5];
            lbGender.Text = data[6];
        }
    }
}
