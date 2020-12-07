using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentSupportApp
{
    public partial class MainForm : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton temp = new Bunifu.Framework.UI.BunifuFlatButton();
        LoginForm parent;
        Connect Connection;
        USER User = new USER();
        ListSem data = new ListSem();
        public MainForm(LoginForm parent, string User)
        {
            this.User = new USER(User);
            this.User.ID = User;
            this.parent = parent;
            this.Connection = new Connect();
            InitializeComponent();
            temp = this.btnHome;
            data.Read(this.User.ID);

            tbCredit.Enabled = tbSubID.Enabled = tbSubName.Enabled = tbProVa.Enabled = tbProWei.Enabled
                = tbMidVa.Enabled = tbMidWei.Enabled = tbFinVa.Enabled = tbFinWei.Enabled = tbPracVa.Enabled = tbPracWei.Enabled= false;
            bAddScore.Visible = bModify.Visible = bDel.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (slidemenu.Width == 55)
            {
                slidemenu.Visible = false;
                slidemenu.Width = 260;
                this.lbHello.Location = new Point(this.lbHello.Location.X - 110, this.lbHello.Location.Y);
                PanelAnimatior.ShowSync(slidemenu);
                //Dung
                this.cardDeadline.Width -= 200;
                this.cardStatus.Width -= 104;
                this.cardInfo.Location = new Point(this.cardStatus.Location.X + 280, this.cardStatus.Location.Y);
                this.cardInfo.Width -= 104;
                this.btbDetails.Width -= 100;
                this.btbSubject.Width -= 100;
                this.bdateTime.Width -= 100;
                this.btbStatus.Width -= 100;
                this.dataDeadline.Width -= 208;
                this.bunifuCards4.Width -= 100;
                this.bEditSave.Location = new Point(this.bRefresh.Location.X + 400, this.bRefresh.Location.Y);
                this.bunifuCards4.Location = new Point(this.bunifuCards4.Location.X - 100, this.bunifuCards4.Location.Y);
                this.dataHomeDeadline.Width -= 100;
                //Danh
                this.bCardTimetable.Width -= 200;
                this.dataGridViewTimetable.Width -= 200;
                this.bunifuCardUserInfo.Width -= 200;
                this.bunifuCardAcc.Width -= 200;
                btnChangeInfo.Location = new Point(btnChangeInfo.Location.X - 210, btnChangeInfo.Location.Y);
                btnSaveInfo.Location = new Point(btnSaveInfo.Location.X - 210, btnSaveInfo.Location.Y);
                btnCancelInfo.Location = new Point(btnCancelInfo.Location.X - 210, btnCancelInfo.Location.Y);
                btnChangeEmail.Location = new Point(btnChangeEmail.Location.X - 210, btnChangeEmail.Location.Y);
                this.tbxNameInfo.Width -= 210;
                this.tbxGenderInfo.Width -= 210;
                this.tbxClassInfo.Width -= 210;
                this.BirthDTPicker.Width -= 110;
                this.tbxEmailInfo.Width -= 210;
                this.lbUserInfo.Location = new Point(this.lbUserInfo.Location.X - 150, this.lbUserInfo.Location.Y);
                this.lbAccount.Location = new Point(this.lbAccount.Location.X - 150, this.lbAccount.Location.Y);
                BirthDTPicker.Location = new Point(BirthDTPicker.Location.X - 80, BirthDTPicker.Location.Y);
                this.bunifuCardTodayTT.Width -= 70;
                this.dataGridViewHomeTimeTB.Width -= 70;
                this.dataGridViewHomeTimeTB.Columns[0].Width -= 20;
                this.dataGridViewHomeTimeTB.Columns[1].Width -= 30;
                //this.bunifuCardTodayTT.Location = new Point(this.bunifuCardTodayTT.Location.X - 50, this.bunifuCardTodayTT.Location.Y);

                //Linh
                this.bunifuCards5.Width -= 100;
                this.bunifuCards5.Location = new Point(this.bunifuCards5.Location.X - 100, this.bunifuCards5.Location.Y);
                lbAvgScore.Location = new Point(this.lbAvgScore.Location.X - 25, this.lbAvgScore.Location.Y);
                lCreSum.Location = new Point(this.lCreSum.Location.X - 25, this.lCreSum.Location.Y);

                // AddScore
                this.cardAddScore.Width -= 220;
                this.cardSBoard.Width-= 220;

                lSem.Location = new Point(lSem.Location.X - 100, lSem.Location.Y);
                lAddScore.Location = new Point(lAddScore.Location.X - 100, lAddScore.Location.Y);
                bSem.Location = new Point(bSem.Location.X - 100, bSem.Location.Y);
                cbSemester.Location = new Point(cbSemester.Location.X - 100, cbSemester.Location.Y);
                tbSubID.Location = new Point(tbSubID.Location.X - 100, tbSubID.Location.Y);
                tbSubName.Location = new Point(tbSubName.Location.X - 100, tbSubName.Location.Y);
                tbCredit.Location = new Point(tbCredit.Location.X - 100, tbCredit.Location.Y);

                lPro.Location = new Point(lPro.Location.X + 100, lPro.Location.Y);
                lMid.Location = new Point(lMid.Location.X + 100, lMid.Location.Y);
                lPrac.Location = new Point(lPrac.Location.X + 100, lPrac.Location.Y);
                lFin.Location = new Point(lFin.Location.X + 100, lFin.Location.Y);

                tbProVa.Location = new Point(tbProVa.Location.X + 100, tbProVa.Location.Y);
                tbMidVa.Location = new Point(tbMidVa.Location.X + 100, tbMidVa.Location.Y);
                tbPracVa.Location = new Point(tbPracVa.Location.X + 100, tbPracVa.Location.Y);
                tbFinVa.Location = new Point(tbFinVa.Location.X + 100, tbFinVa.Location.Y);

                tbProWei.Location = new Point(tbProWei.Location.X + 100, tbProWei.Location.Y);
                tbMidWei.Location = new Point(tbMidWei.Location.X + 100, tbMidWei.Location.Y);
                tbPracWei.Location = new Point(tbPracWei.Location.X + 100, tbPracWei.Location.Y);
                tbFinWei.Location = new Point(tbFinWei.Location.X + 100, tbFinWei.Location.Y);

                bAddScore.Location = new Point(bAddScore.Location.X + 100, bAddScore.Location.Y);
                bModify.Location = new Point(bModify.Location.X + 100, bModify.Location.Y);
                bDel.Location = new Point(bDel.Location.X + 100, bDel.Location.Y);

                //ScoreBoard
               
                lSBoard.Location = new Point(lSBoard.Location.X - 100, lSBoard.Location.Y);
                lAmountSub.Location = new Point(lAmountSub.Location.X - 35, lAmountSub.Location.Y);
                lSumCre.Location = new Point(lSumCre.Location.X - 35, lSumCre.Location.Y);
                l_Average.Location = new Point(l_Average.Location.X - 28, l_Average.Location.Y);
                lvScoreBoard.Location = new Point(lvScoreBoard.Location.X - 50, lvScoreBoard.Location.Y);
                lvScoreBoard.Width += 50;

                //Setting
                cardAcc.Width -= 50;
                cardLang.Location = new Point(cardLang.Location.X - 75, cardLang.Location.Y);
                cardLang.Width -= 50;
                cardTheme.Location = new Point(cardTheme.Location.X - 150, cardTheme.Location.Y);
                cardTheme.Width -= 50;
                cardMore.Width -= 125;

                bSetData.Location = new Point(bSetData.Location.X - 25, bSetData.Location.Y);
                bChangePass.Location = new Point(bChangePass.Location.X - 25, bChangePass.Location.Y);
                bDelAcc.Location = new Point(bDelAcc.Location.X - 25, bDelAcc.Location.Y);

                bFeedSup.Location = new Point(bFeedSup.Location.X - 100, bFeedSup.Location.Y);
                bShareApp.Location = new Point(bShareApp.Location.X - 100, bShareApp.Location.Y);
                bAboutUs.Location = new Point(bAboutUs.Location.X - 100, bAboutUs.Location.Y);

                bTheme1.Location = new Point(bTheme1.Location.X - 25, bTheme1.Location.Y);
                bTheme2.Location = new Point(bTheme2.Location.X - 25, bTheme2.Location.Y);
                bTheme3.Location = new Point(bTheme3.Location.X - 25, bTheme3.Location.Y);
                bTheme4.Location = new Point(bTheme4.Location.X - 25, bTheme4.Location.Y);
            }
            else
            {
                // LogoAnimator.Hide(logo);
                slidemenu.Visible = false;
                slidemenu.Width = 55;
                this.lbHello.Location = new Point(this.lbHello.Location.X + 110, this.lbHello.Location.Y);
                PanelAnimatior.ShowSync(slidemenu);
                //Dung
                this.cardDeadline.Width += 200;
                this.cardStatus.Width += 104;
                this.cardInfo.Location = new Point(this.cardStatus.Location.X + 380, this.cardStatus.Location.Y);
                this.cardInfo.Width += 104;
                this.btbDetails.Width += 100;
                this.btbSubject.Width += 100;
                this.bdateTime.Width += 100;
                this.btbStatus.Width += 100;
                this.dataDeadline.Width += 208;
                this.bunifuCards4.Width += 100;
                this.bEditSave.Location = new Point(this.bRefresh.Location.X + 620, this.bRefresh.Location.Y);
                this.bunifuCards4.Location = new Point(this.bunifuCards4.Location.X + 100, this.bunifuCards4.Location.Y);
                this.dataHomeDeadline.Width += 100;

                //Danh
                this.bCardTimetable.Width += 200;
                this.dataGridViewTimetable.Width += 200;
                this.bunifuCardUserInfo.Width += 200;
                this.bunifuCardAcc.Width += 200;
                btnChangeInfo.Location = new Point(btnChangeInfo.Location.X + 210, btnChangeInfo.Location.Y);
                btnSaveInfo.Location = new Point(btnSaveInfo.Location.X + 210, btnSaveInfo.Location.Y);
                btnCancelInfo.Location = new Point(btnCancelInfo.Location.X + 210, btnCancelInfo.Location.Y);
                btnChangeEmail.Location = new Point(btnChangeEmail.Location.X + 210, btnChangeEmail.Location.Y);
                this.tbxNameInfo.Width += 210;
                this.tbxGenderInfo.Width += 210;
                this.tbxClassInfo.Width += 210;
                this.BirthDTPicker.Width += 110;
                this.tbxEmailInfo.Width += 210;
                this.lbUserInfo.Location = new Point(this.lbUserInfo.Location.X + 150, this.lbUserInfo.Location.Y);
                this.lbAccount.Location = new Point(this.lbAccount.Location.X + 150, this.lbAccount.Location.Y);
                BirthDTPicker.Location = new Point(BirthDTPicker.Location.X + 80, BirthDTPicker.Location.Y);
                this.bunifuCardTodayTT.Width += 70;
                this.dataGridViewHomeTimeTB.Width += 70;
                this.dataGridViewHomeTimeTB.Columns[0].Width += 20;
                this.dataGridViewHomeTimeTB.Columns[1].Width += 30;
                //this.bunifuCardTodayTT.Location = new Point(this.bunifuCardTodayTT.Location.X + 50, this.bunifuCardTodayTT.Location.Y);

                //Linh
                this.cardAddScore.Width += 220;
                this.cardSBoard.Width += 220;
                this.bunifuCards5.Width += 100;
                lbAvgScore.Location = new Point(this.lbAvgScore.Location.X + 25, this.lbAvgScore.Location.Y);
                lCreSum.Location = new Point(this.lCreSum.Location.X + 25, this.lCreSum.Location.Y);
                this.bunifuCards5.Location = new Point(this.bunifuCards5.Location.X + 100, this.bunifuCards5.Location.Y);

                //AddScore
                lSem.Location = new Point(lSem.Location.X + 100, lSem.Location.Y);
                lAddScore.Location = new Point(lAddScore.Location.X+100, lAddScore.Location.Y);
                bSem.Location = new Point(bSem.Location.X + 100, bSem.Location.Y);
                cbSemester.Location = new Point(cbSemester.Location.X + 100, cbSemester.Location.Y);
                tbSubID.Location = new Point(tbSubID.Location.X+100, tbSubID.Location.Y);
                tbSubName.Location = new Point(tbSubName.Location.X+100, tbSubName.Location.Y);
                tbCredit.Location = new Point(tbCredit.Location.X+100, tbCredit.Location.Y);

                lPro.Location = new Point(lPro.Location.X - 100, lPro.Location.Y);
                lMid.Location = new Point(lMid.Location.X - 100, lMid.Location.Y);
                lPrac.Location = new Point(lPrac.Location.X - 100, lPrac.Location.Y);
                lFin.Location = new Point(lFin.Location.X - 100, lFin.Location.Y);

                tbProVa.Location = new Point(tbProVa.Location.X - 100, tbProVa.Location.Y);
                tbMidVa.Location = new Point(tbMidVa.Location.X - 100, tbMidVa.Location.Y);
                tbPracVa.Location = new Point(tbPracVa.Location.X - 100, tbPracVa.Location.Y);
                tbFinVa.Location = new Point(tbFinVa.Location.X - 100, tbFinVa.Location.Y);

                tbProWei.Location = new Point(tbProWei.Location.X - 100, tbProWei.Location.Y);
                tbMidWei.Location = new Point(tbMidWei.Location.X - 100, tbMidWei.Location.Y);
                tbPracWei.Location = new Point(tbPracWei.Location.X - 100, tbPracWei.Location.Y);
                tbFinWei.Location = new Point(tbFinWei.Location.X - 100, tbFinWei.Location.Y);

                bAddScore.Location = new Point(bAddScore.Location.X - 100, bAddScore.Location.Y);
                bModify.Location = new Point(bModify.Location.X - 100, bModify.Location.Y);
                bDel.Location = new Point(bDel.Location.X - 100, bDel.Location.Y);

                //ScoreBoard
                
                lSBoard.Location = new Point(lSBoard.Location.X + 100, lSBoard.Location.Y);
                lAmountSub.Location = new Point(lAmountSub.Location.X + 35, lAmountSub.Location.Y);
                lSumCre.Location = new Point(lSumCre.Location.X + 35, lSumCre.Location.Y);
                l_Average.Location = new Point(l_Average.Location.X + 28, l_Average.Location.Y);
                lvScoreBoard.Location = new Point(lvScoreBoard.Location.X + 50, lvScoreBoard.Location.Y);
                lvScoreBoard.Width -= 50;

                //Setting
                cardAcc.Width += 50;
                cardLang.Location = new Point(cardLang.Location.X + 75, cardLang.Location.Y);
                cardLang.Width += 50;
                cardTheme.Location = new Point(cardTheme.Location.X + 150, cardTheme.Location.Y);
                cardTheme.Width += 50;
                cardMore.Width += 125;

                bSetData.Location = new Point(bSetData.Location.X + 25, bSetData.Location.Y);
                bChangePass.Location = new Point(bChangePass.Location.X + 25, bChangePass.Location.Y);
                bDelAcc.Location = new Point(bDelAcc.Location.X + 25, bDelAcc.Location.Y);

                bFeedSup.Location = new Point(bFeedSup.Location.X + 100, bFeedSup.Location.Y);
                bShareApp.Location = new Point(bShareApp.Location.X + 100, bShareApp.Location.Y);
                bAboutUs.Location = new Point(bAboutUs.Location.X + 100, bAboutUs.Location.Y);

                bTheme1.Location = new Point(bTheme1.Location.X + 25, bTheme1.Location.Y);
                bTheme2.Location = new Point(bTheme2.Location.X + 25, bTheme2.Location.Y);
                bTheme3.Location = new Point(bTheme3.Location.X + 25, bTheme3.Location.Y);
                bTheme4.Location = new Point(bTheme4.Location.X + 25, bTheme4.Location.Y);

            }
        }

        public void Alert(string msg)
        {
            Notifi notifi = new Notifi();
            notifi.showAlert(msg);
        }

        private void NotifiDeadline()
        {
            Deadlines[] ListDeadline = new Deadlines[1000];
            string sQuery = "SELECT * FROM DEADLINE WHERE YEAR(DATESUBMIT) = YEAR(GETDATE()) AND MONTH(DATESUBMIT) = MONTH(GETDATE()) AND DAY(DATESUBMIT) = DAY(GETDATE()) AND ID_USER = '" + this.User.ID + "'";
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
                ListDeadline[temp] = new Deadlines(args, temp1);
                temp++;
            }
            this.Connection.CloseConnection();
            foreach (Deadlines DL in ListDeadline)
            {
                if (DL == null)
                    break;
                this.Alert(DL.SubjectCode + " | " + DL.Details + " | Today: " + DL.TimeSubmit.TimeOfDay);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            this.btnHome.Normalcolor = Color.CornflowerBlue;
            panelHome.Dock = DockStyle.Fill;
            panelHome.BringToFront();
            temp = btnHome;

            lAverAll.Text = "Average: " + data.Average.ToString();
            lCreSum.Text = "Credit: " + data.SumOfCre.ToString();
        }
        private void btnScore_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            this.btnScore.Normalcolor = Color.CornflowerBlue;
            panelScore.Dock = DockStyle.Fill;
            panelScore.BringToFront();
            temp = btnScore;
        }
        private void bNofitication_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            this.btnNofitication.Normalcolor = Color.CornflowerBlue;
            temp = btnNofitication;
            this.panelNoti.Dock = DockStyle.Fill;
            panelNoti.BringToFront();
        }
        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            this.btnTimeTable.Normalcolor = Color.CornflowerBlue;
            this.panelTimetable.Dock = DockStyle.Fill;
            panelTimetable.BringToFront();
            temp = btnTimeTable;

            if (cbxSem.Items.IndexOf(Properties.Settings.Default.Text) >= 0)
            {
                cbxSem.SelectedItem = cbxSem.Items[cbxSem.Items.IndexOf(Properties.Settings.Default.Text)];
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            this.btnInformation.Normalcolor = Color.CornflowerBlue;
            this.panelInfo.Dock = DockStyle.Fill;
            panelInfo.BringToFront();
            temp = btnInformation;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            this.btnSetting.Normalcolor = Color.CornflowerBlue;
            this.panelSetting.Dock = DockStyle.Fill;
            panelSetting.BringToFront();
            temp = btnSetting;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Dung
            Deadlines[] ListDeadline = new Deadlines[1000];
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
                ListDeadline[temp] = new Deadlines(args, temp1);
                temp++;
            }
            this.Connection.CloseConnection();
            foreach (Deadlines DL in ListDeadline)
            {
                if (DL == null)
                    break;
                dataDeadline.Rows.Add(DL.ID, DL.SubjectCode, DL.Subject, DL.Details, DL.TimeSubmit, DL.Status);
            }
            NearestDeadline();
            LoadToHomeDeadline();
            NotifiDeadline();

            //Danh
            this.lbHello.Text += " " + this.User.Name + "! Have a nice day!";
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
            if (cbxSem.Items.IndexOf(Properties.Settings.Default.Text) >= 0)
            {
                LoadTimetableToHomeDGV(dataGridViewHomeTimeTB, sLesson);
            }

            ReadSchedulesSemesterComboboxItems();
            dataGridViewTimetable.CurrentCell.Selected = !dataGridViewTimetable.CurrentCell.Selected;

            btnHome_Click(sender, e);
            LoadInformationTab();
        }

        private void panelScore_Paint(object sender, PaintEventArgs e)
        {

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
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parent.Show();
        }
    }

}

//Dung
namespace StudentSupportApp
{
    public partial class MainForm
    {
        private void bEdit_Click(object sender, EventArgs e)
        {
            this.bEditSave.Visible = true;
            this.btbDetails.Enabled = true;
            this.btbStatus.Enabled = true;
            this.btbSubject.Enabled = true;
        }
        private void LoadToHomeDeadline()
        {
            Deadlines[] temp = new Deadlines[5];
            string Top5Deadlilne = "SELECT TOP (5) * FROM DEADLINE WHERE ID_USER='" + this.User.ID + "' ORDER BY DEADLINE.DATESUBMIT ASC";
            try
            {
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Top5Deadlilne);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }
                    dataHomeDeadline.Rows.Add(reader.GetString(1), reader.GetDateTime(4).ToString(), false);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        private void bRefresh_Click(object sender, EventArgs e)
        {
            Deadlines[] ListDeadline = new Deadlines[1000];
            while (dataDeadline.Rows.Count > 1)
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
                ListDeadline[temp] = new Deadlines(args, temp1);
                temp++;
            }
            this.Connection.CloseConnection();
            foreach (Deadlines DL in ListDeadline)
            {
                if (DL == null)
                    break;
                dataDeadline.Rows.Add(DL.ID, DL.SubjectCode, DL.Subject, DL.Details, DL.TimeSubmit, DL.Status);
            }
        }
        private void bDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(" All selected items will be delete!", "WARNING!", button);
            foreach (DataGridViewRow row in dataDeadline.SelectedRows)
            {
                try
                {
                    this.Connection.OpenConnection();
                    string Query = "DELETE FROM DEADLINE WHERE ID ='" + row.Cells[0].Value + "'";
                    SqlCommand command = this.Connection.CreateSQLCmd(Query);
                    dataDeadline.Rows.RemoveAt(row.Index);
                    command.ExecuteNonQuery();
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Connection.CloseConnection();
                    NearestDeadline();
                }
            }
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            AddDeadline add = new AddDeadline(this);
            add.addItem = new AddDeadline.AddItem(addDeadline);
            this.Hide();
            add.Show();
        }
        private void addDeadline(string[] temp)
        {
            try
            {
                this.Connection.OpenConnection();
                temp[0] = "1";
                User.GetDeadlineID(ref temp[0]);
                this.dataDeadline.Rows.Add(temp[0], temp[2], temp[1], temp[3], temp[4], temp[5]);
                string Query = "INSERT INTO DEADLINE VALUES('" + temp[0] + "', '" + temp[1] + "', '" + temp[2] + "', '" +
                                                                temp[3] + "', '" + temp[4] + "', '" + temp[5] + "', '" + this.User.ID + "')";
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
                MessageBox.Show(" ADDED SUCCESSFULLY!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        private void dataDeadline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDeadline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataDeadline.CurrentRow.Selected = true;
                labelID.Text = dataDeadline.Rows[e.RowIndex].Cells[0].Value.ToString();
                btbSubject.Text = dataDeadline.Rows[e.RowIndex].Cells[2].Value.ToString();
                btbDetails.Text = dataDeadline.Rows[e.RowIndex].Cells[3].Value.ToString();
                bdateTime.Value = DateTime.Parse(dataDeadline.Rows[e.RowIndex].Cells[4].Value.ToString());
                btbStatus.Text = dataDeadline.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void bEditSave_Click(object sender, EventArgs e)
        {
            this.btbDetails.Enabled = false;
            this.btbStatus.Enabled = false;
            this.btbSubject.Enabled = false;
            this.bEditSave.Hide();
            try
            {
                string Query = "UPDATE DEADLINE SET DETAIL='" + btbDetails.Text + "', DATESUBMIT='" + bdateTime.Value.ToString() + "', STAT='" + btbStatus.Text + "', SUB_NAME='" + btbSubject.Text
                                                              + "' WHERE ID='" + labelID.Text + "'";
                Connection.OpenConnection();
                SqlCommand command = Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("SAVED!", "Notification", buttons);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                Connection.CloseConnection();
                bRefresh_Click(sender, e);    
            }
        }

        private void NearestDeadline()
        {
            try
            {
                this.Connection.OpenConnection();
                string Query = "SELECT COUNT(ID) FROM DEADLINE WHERE GETDATE() <= DATESUBMIT AND ID_USER ='" + this.User.ID + "'";
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.labelNum.Text = reader.GetInt32(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Connection.CloseConnection();
            }

            try
            {
                this.Connection.OpenConnection();
                string Query = "SELECT TOP 1 DATESUBMIT FROM DEADLINE WHERE GETDATE() <= DATESUBMIT AND ID_USER ='" + this.User.ID + "'" + "ORDER BY DATESUBMIT DESC";
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.labelDate.Text = reader.GetDateTime(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Connection.CloseConnection();
            }

        }
    }
}

//Danh
namespace StudentSupportApp
{
    public partial class MainForm
    {
        string Semester;

        private void btnCreNewLess_Click(object sender, EventArgs e)
        {
            try
            {
                AddLessonForm AddLesson = new AddLessonForm(this, this.User.ID);
                AddLesson.Show();
                this.Hide();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void ReadSchedulesSemesterComboboxItems()
        {
            try
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
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnLoadTT_Click(object sender, EventArgs e)
        {
            try
            {
                Timetable UserSchedules = new Timetable(this.User.ID, cbxSem.Text);
                UserSchedules.LoadUserTimetable();
                UserSchedules.LoadTimetableToDGV(dataGridViewTimetable);
                btnSetDefault.Visible = true;
                btnModifyLess.Visible = true;
                btnExportTT.Visible = true;
                this.Semester = cbxSem.Text;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
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

        private void btnModifyLess_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewTimetable.CurrentCell.Selected == true)
                {
                    int iSubID = this.dataGridViewTimetable.CurrentCell.Value.ToString().IndexOf("\n");
                    int iCellValueLength = this.dataGridViewTimetable.CurrentCell.Value.ToString().Length;
                    List<string> sLessonData = new List<string> { cbxSem.Text, this.dataGridViewTimetable.Columns[this.dataGridViewTimetable.CurrentCell.ColumnIndex].Name,
                                                                  this.dataGridViewTimetable.CurrentCell.Value.ToString().Substring(0, iSubID),
                                                                  this.dataGridViewTimetable.CurrentCell.Value.ToString().Substring(iSubID, iCellValueLength - iSubID),
                                                                  (this.dataGridViewTimetable.CurrentCell.RowIndex + 1).ToString() };
                    ModLessonForm modLessonForm = new ModLessonForm(this, sLessonData, this.User.ID);
                    modLessonForm.Show();
                    this.Hide();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void AddLessonTimeToDataGridView()
        {
            try
            {
                //dataGridViewHomeTimetable.Columns[1].HeaderText = DateTime.Today.DayOfWeek.ToString();
                string[] sRow = new string[] {"Lesson 1\n(7:30-8:15)", "Lesson 2\n(8:15-9:00)",
                "Lesson 3\n(9:00 - 9:45)" , "Lesson 4\n(10:00-10:45)", "Lesson 5\n(10:45-11:30)",
                "Lesson 6\n(13:00-13:45)", "Lesson 7\n(13:45-14:30)", "Lesson 8\n(14:30-15:15)",
                "Lesson 9\n(15:30-16:15)", "Lesson 10\n(16:15-17:00)"};
                for (int i = 0; i < sRow.Length; i++)
                {
                    dataGridViewTimetable.Rows.Add(sRow[i]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void cbxSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoadTT.Visible = true;
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            ReadSchedulesSemesterComboboxItems();
            cbxSem.Text = this.Semester;
            LoadInformationTab();
        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Text = cbxSem.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Saved!", "Set Default Semester");
        }

        private void LoadInformationTab()
        {
            try
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
                    sData.Add(reader.GetDateTime(2).ToString().Substring(0, 10));
                    sData.Add(reader.GetString(3));
                    sData.Add(reader.GetString(4));
                    sData.Add(reader.GetString(5));
                    sData.Add(reader.GetString(6));
                }
                Info.CloseConnection();

                ShowUserInformation(sData);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void ShowUserInformation(List<string> data)
        {
            lbAccID.Text = data[0];
            tbxEmailInfo.Text = data[1];
            lbBirthdayInfo.Text = data[2];

            tbxNameInfo.Text = data[4];
            tbxClassInfo.Text = data[5];
            tbxGenderInfo.Text = data[6];
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            tbxNameInfo.Enabled = !tbxNameInfo.Enabled;
            tbxClassInfo.Enabled = !tbxClassInfo.Enabled;
            tbxGenderInfo.Enabled = !tbxGenderInfo.Enabled;
            BirthDTPicker.Enabled = !BirthDTPicker.Enabled;

            btnCancelInfo.Visible = !btnCancelInfo.Visible;
            btnSaveInfo.Visible = !btnSaveInfo.Visible;
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNameInfo.Text == "" && tbxGenderInfo.Text == "" && tbxClassInfo.Text == "")
                {
                    const string message = "Your information is now empty? Are you sure to continue?";
                    const string caption = "Change Information";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] sInfo = new string[] { tbxNameInfo.Text, BirthDTPicker.Value.ToString(),
                                                            tbxGenderInfo.Text, tbxClassInfo.Text };
                        if (this.User.UpdateUserInfo(this.User.ID, sInfo) == 1)
                        {
                            MessageBox.Show("Changed your information successfully!", "Change Information");
                        }
                        else MessageBox.Show("Failed to change your information! Try again.", "Change Information");
                    }
                }
                else
                {
                    string[] sInfo = new string[] { tbxNameInfo.Text, BirthDTPicker.Value.ToString(),
                                                            tbxGenderInfo.Text, tbxClassInfo.Text };
                    if (this.User.UpdateUserInfo(this.User.ID, sInfo) == 1)
                    {
                        MessageBox.Show("Changed your information successfully!", "Change Information");
                    }
                    else MessageBox.Show("Failed to change your information! Try again.", "Change Information");
                }

                btnChangeInfo_Click(sender, e);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnCancelInfo_Click(object sender, EventArgs e)
        {
            const string message = "Your changes will not be saved? Are you sure to continue?";
            const string caption = "Cancel Changing Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadInformationTab();
                btnChangeInfo_Click(sender, e);
            }
        }

        private void tbxNameInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar) == false && (e.KeyChar != (char)Keys.Space) && e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
                BirthDTPicker.Focus();
        }

        private void tbxGenderInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar) == false && (e.KeyChar != (char)Keys.Space) && e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
                tbxClassInfo.Focus();
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            ChangeEmailForm changeMail = new ChangeEmailForm(this, this.User.ID);
            changeMail.Show();
            this.Hide();
        }

        public void LoadTodayTimetable(string today, ref List<string> Lesson)
        {
            Connect loadHomeTimetable = new Connect();
            try
            {
                loadHomeTimetable.OpenConnection();

                string sWeekDay = dataGridViewHomeTimeTB.Columns[1].HeaderText.ToString();
                for (int i = 1; i <= 10; i++)
                {
                    string sLoadData = "select SUB_NAME from LESSON where ID_USER='" + this.User.ID
                                        + "' AND DAYINWEEK='" + sWeekDay + "' AND SEM_NAME='" + Properties.Settings.Default.Text + "'"
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
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                loadHomeTimetable.CloseConnection();
            }
        }
    }
}


//Linh
namespace StudentSupportApp
{
    public partial class MainForm
    {
        public void ShowToListView(string semester)
        {
            try
            {
                bDel.Visible = false;
                bModify.Visible = false;
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

        private void ResetTextbox()
        {
            this.tbCredit.Text = "Credit";
            this.tbSubID.Text = "Subject ID";
            this.tbSubName.Text = "Subject Name";

            tbProVa.Text = tbMidVa.Text = tbPracVa.Text = tbFinVa.Text = "Value";
            tbProWei.Text = tbMidWei.Text = tbPracWei.Text = tbFinWei.Text = "Ratio";
        }
        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSemester = cbSemester.SelectedItem.ToString();
            data.SEMESTERS.Clear();
            data.Read(this.User.ID);
            lvScoreBoard.Items.Clear();
            ShowToListView(sSemester);

            bAddScore.Visible = bModify.Visible = bDel.Visible = true;
            tbSubID.Enabled = tbSubName.Enabled = tbCredit.Enabled = true;
            tbMidVa.Enabled = tbMidWei.Enabled = true;
            tbPracVa.Enabled = tbPracWei.Enabled = true;
            tbProVa.Enabled = tbProWei.Enabled = true;
            tbFinVa.Enabled = tbFinWei.Enabled = true;

            bModify.Visible = bDel.Visible = false;
            data.SEMESTERS.Clear();

            //ResetTextbox();
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
                    bAddScore.Visible = true;
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
                    sql += @"Delete From Subjects where(SUB_ID= '" + tbSubID.Text + "' and ID ='" + this.User.ID + "')";
                    SqlCommand command = Connection.CreateSQLCmd(sql);
                    command.ExecuteNonQuery();
                    Connection.CloseConnection();
                    MessageBox.Show("Done!", caption);

                    lvScoreBoard.Items.Clear();
                    ShowToListView(cbSemester.SelectedItem.ToString());
                }
                bAddScore.Enabled = true;
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

        public void AddItemToComboBoxSemester()
        {
            try
            {
                cbSemester.Items.Clear();
                List<string> sItem = new List<string>();

                Connection.OpenConnection();
                SqlCommand command = Connection.CreateSQLCmd("select distinct SEM_NAME from SEMESTER where ID = '" + this.User.ID + "'");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    sItem.Add(reader.GetString(0));
                }
                foreach (var sem in sItem)
                    cbSemester.Items.Add(sem);

                lvScoreBoard.Items.Clear();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                Connection.CloseConnection();
            }

            lAmountSub.Text = "Amount of subjects: ";
            l_Average.Text = "Average: ";
            lSumCre.Text = "Sum of credits:";
        }

        private void lvScoreBoard_Click(object sender, EventArgs e)
        {
            try
            {
                bAddScore.Visible = true;
                bDel.Visible = true;
                bModify.Visible = true;

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
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab))
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

        private void bSetData_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to reset your data? Your data will be deleted!", "Set default", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    User.SetDataDefault();
                    MessageBox.Show("Done!", "Set default", MessageBoxButtons.OK);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void bChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePass form = new ChangePass(this, this.User.ID, this.User.Password);
            form.Show();
        }

        private void bDelAcc_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to remove your account? All your data will be deleted!", "Delete your account", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                if (result == DialogResult.OK)
                {
                    this.Close();
                    User.DeleteUser();
                    MessageBox.Show("Done!", "Delete your account", MessageBoxButtons.OK);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
