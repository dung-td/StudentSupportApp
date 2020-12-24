using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows;

namespace StudentSupportApp
{
    public partial class MainForm : Form
    {
        [DllImport("user32")]
        private static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        Bunifu.Framework.UI.BunifuFlatButton temp = new Bunifu.Framework.UI.BunifuFlatButton();
        LoginForm parent;
        Connect Connection;
        USER User = new USER();
        ListSem data = new ListSem();
        ListWeb listWeb;

        Color theme = new Color();
        public MainForm(LoginForm parent, string User)
        {
            this.User = new USER(User);
            this.User.ID = User;
            this.parent = parent;
            this.Connection = new Connect();
            this.listWeb = new ListWeb(this.User.ID);
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            temp = this.btnHome;
            data.Read(this.User.ID);
            listWeb.ShowToListView(lvWeb);

            this.theme = Properties.Settings.Default.Color;
            SetColorAll(this.theme);

            animation1.AnimationType = new AnimatorNS.AnimationType();
            animation1.AnimationType = AnimatorNS.AnimationType.Particles;
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
                slidemenu.Width = 246;
                this.lbHello.Location = new Point(this.lbHello.Location.X - 110, this.lbHello.Location.Y);
                animation1.ShowSync(slidemenu);
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
                this.bunifuCards4.Width -= 105;
                this.bEditSave.Location = new Point(this.bRefresh.Location.X + 400, this.bRefresh.Location.Y);
                this.bunifuCards4.Location = new Point(this.bunifuCards4.Location.X - 80, this.bunifuCards4.Location.Y);
                this.dataHomeDeadline.Width -= 100;

                this.cardCommunity.Width -= 104;
                cardProfile.Location = new Point(this.cardCommunity.Location.X + this.cardCommunity.Width - 60, this.cardCommunity.Location.Y);
                this.cardProfile.Width -= 90;
                cardSubRV.Location = new Point(this.cardCommunity.Location.X + this.cardCommunity.Width - 60, this.cardProfile.Location.Y + this.cardProfile.Height - 1);
                this.cardSubRV.Width -= 90;

                this.tbxFind.Width -= 80;
                this.tbxID.Width -= 80;
                this.tbxName.Width -= 80;
                this.tbxEmail.Width -= 80;
                this.listViewProfile.Width -= 70;
                this.btnFind.Location = new Point(this.btnFind.Location.X - 80, this.btnFind.Location.Y);

                this.labelFinish.Location = new Point(this.btbStatus.Location.X + 155, this.labelFinish.Location.Y);
                this.sliderProgress.Location = new Point(this.labelFinish.Location.X + 90, this.sliderProgress.Location.Y);
                this.sliderProgress.Width -= 50;

                //Danh
                this.bCardTimetable.Width -= 200;
                this.dataGridViewTimetable.Width -= 200;
                this.bunifuCardUserInfo.Width -= 200;
                this.bunifuCardAcc.Width -= 200;
                this.lbTimetable.Location = new Point(lbTimetable.Location.X - 40, lbTimetable.Location.Y);
                btnChangeInfo.Location = new Point(btnChangeInfo.Location.X - 210, btnChangeInfo.Location.Y);
                btnSaveInfo.Location = new Point(btnSaveInfo.Location.X - 210, btnSaveInfo.Location.Y);
                btnCancelInfo.Location = new Point(btnCancelInfo.Location.X - 210, btnCancelInfo.Location.Y);
                btnChangeEmail.Location = new Point(btnChangeEmail.Location.X - 210, btnChangeEmail.Location.Y);
                bChangePassword.Location = new Point(bChangePassword.Location.X - 210, bChangePassword.Location.Y);
                this.tbxNameInfo.Width -= 210;
                this.tbxGenderInfo.Width -= 210;
                this.tbxClassInfo.Width -= 210;
                this.BirthDTPicker.Width -= 110;
                this.tbxEmailInfo.Width -= 210;
                this.bunifuCardsNote.Location = new Point(bunifuCardsNote.Location.X - 190, bunifuCardsNote.Location.Y);
                this.lbUserInfo.Location = new Point(this.lbUserInfo.Location.X - 150, this.lbUserInfo.Location.Y);
                this.lbAccount.Location = new Point(this.lbAccount.Location.X - 150, this.lbAccount.Location.Y);
                BirthDTPicker.Location = new Point(BirthDTPicker.Location.X - 80, BirthDTPicker.Location.Y);
                this.bunifuCardTodayTT.Width -= 70;
                this.dataGridViewHomeTimeTB.Width -= 70;
                this.dataGridViewHomeTimeTB.Columns[0].Width -= 20;
                this.dataGridViewHomeTimeTB.Columns[1].Width -= 30;
                this.lbTodayTT.Location = new Point(this.lbTodayTT.Location.X - 50, this.lbTodayTT.Location.Y);
                //this.bunifuCardTodayTT.Location = new Point(this.bunifuCardTodayTT.Location.X - 50, this.bunifuCardTodayTT.Location.Y);

                //Linh
                //this.bunifuCards5.Width -= 50;
                this.bunifuCards5.Location = new Point(this.bunifuCards5.Location.X - 190, this.bunifuCards5.Location.Y);
                //lbAvgScore.Location = new Point(this.lbAvgScore.Location.X - 25, this.lbAvgScore.Location.Y);
                //lCreSum.Location = new Point(this.lCreSum.Location.X - 25, this.lCreSum.Location.Y);
                cardWeb.Width -= 105;
                this.cardWeb.Location = new Point(this.cardWeb.Location.X - 80, this.cardWeb.Location.Y);
                this.lvWeb.Width -= 105;
                this.bAddWeb.Location = new Point(this.bAddWeb.Location.X - 50, this.bAddWeb.Location.Y);
                this.lWeb.Location = new Point(this.lWeb.Location.X - 40, this.lWeb.Location.Y);

                // AddScore
                this.cardAddScore.Width -= 200;
                this.cardSBoard.Width -= 200;

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
                cardAcc.Width -= 125;

                cardTheme.Location = new Point(cardTheme.Location.X - 150, cardTheme.Location.Y);
                cardTheme.Width -= 50;
                cardMore.Width -= 125;

                bSetData.Location = new Point(bSetData.Location.X - 25, bSetData.Location.Y);

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
                animation1.ShowSync(slidemenu);
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
                this.bunifuCards4.Width += 105;
                this.bEditSave.Location = new Point(this.bRefresh.Location.X + 620, this.bRefresh.Location.Y);
                this.bunifuCards4.Location = new Point(this.bunifuCards4.Location.X + 80, this.bunifuCards4.Location.Y);
                this.dataHomeDeadline.Width += 100;

                this.cardCommunity.Width += 104;
                cardProfile.Location = new Point(this.cardCommunity.Location.X + this.cardCommunity.Width - 1, this.cardCommunity.Location.Y);
                this.cardProfile.Width += 90;
                cardSubRV.Location = new Point(this.cardCommunity.Location.X + this.cardCommunity.Width - 1, this.cardProfile.Location.Y + this.cardProfile.Height - 1);
                this.cardSubRV.Width += 90;

                this.tbxFind.Width += 80;
                this.tbxID.Width += 80;
                this.tbxName.Width += 80;
                this.tbxEmail.Width += 80;
                this.listViewProfile.Width += 70;
                this.btnFind.Location = new Point(this.btnFind.Location.X + 80, this.btnFind.Location.Y);

                this.labelFinish.Location = new Point(this.btbStatus.Location.X + 210, this.labelFinish.Location.Y);
                this.sliderProgress.Location = new Point(this.labelFinish.Location.X + 90, this.sliderProgress.Location.Y);
                this.sliderProgress.Width += 50;

                //Danh
                this.bCardTimetable.Width += 200;
                this.dataGridViewTimetable.Width += 200;
                this.bunifuCardUserInfo.Width += 200;
                this.bunifuCardAcc.Width += 200;
                this.lbTimetable.Location = new Point(lbTimetable.Location.X + 40, lbTimetable.Location.Y);
                btnChangeInfo.Location = new Point(btnChangeInfo.Location.X + 210, btnChangeInfo.Location.Y);
                btnSaveInfo.Location = new Point(btnSaveInfo.Location.X + 210, btnSaveInfo.Location.Y);
                btnCancelInfo.Location = new Point(btnCancelInfo.Location.X + 210, btnCancelInfo.Location.Y);
                btnChangeEmail.Location = new Point(btnChangeEmail.Location.X + 210, btnChangeEmail.Location.Y);
                bChangePassword.Location = new Point(bChangePassword.Location.X + 210, bChangePassword.Location.Y);
                this.tbxNameInfo.Width += 210;
                this.tbxGenderInfo.Width += 210;
                this.tbxClassInfo.Width += 210;
                this.BirthDTPicker.Width += 110;
                this.tbxEmailInfo.Width += 210;
                this.bunifuCardsNote.Location = new Point(bunifuCardsNote.Location.X + 190, bunifuCardsNote.Location.Y);
                this.lbUserInfo.Location = new Point(this.lbUserInfo.Location.X + 150, this.lbUserInfo.Location.Y);
                this.lbAccount.Location = new Point(this.lbAccount.Location.X + 150, this.lbAccount.Location.Y);
                BirthDTPicker.Location = new Point(BirthDTPicker.Location.X + 80, BirthDTPicker.Location.Y);
                this.bunifuCardTodayTT.Width += 70;
                this.dataGridViewHomeTimeTB.Width += 70;
                this.dataGridViewHomeTimeTB.Columns[0].Width += 20;
                this.dataGridViewHomeTimeTB.Columns[1].Width += 30;
                this.lbTodayTT.Location = new Point(this.lbTodayTT.Location.X + 50, this.lbTodayTT.Location.Y);
                //this.bunifuCardTodayTT.Location = new Point(this.bunifuCardTodayTT.Location.X + 50, this.bunifuCardTodayTT.Location.Y);

                //Linh
                this.cardAddScore.Width += 200;
                this.cardSBoard.Width += 200;
                //this.bunifuCards5.Width += 50;
                //lbAvgScore.Location = new Point(this.lbAvgScore.Location.X + 25, this.lbAvgScore.Location.Y);
                //lCreSum.Location = new Point(this.lCreSum.Location.X + 25, this.lCreSum.Location.Y);
                this.bunifuCards5.Location = new Point(this.bunifuCards5.Location.X + 190, this.bunifuCards5.Location.Y);
                cardWeb.Width += 105;
                this.cardWeb.Location = new Point(this.cardWeb.Location.X + 80, this.cardWeb.Location.Y);
                this.lvWeb.Width += 105;
                this.bAddWeb.Location = new Point(this.bAddWeb.Location.X + 50, this.bAddWeb.Location.Y);
                this.lWeb.Location = new Point(this.lWeb.Location.X + 40, this.lWeb.Location.Y);

                //AddScore
                lSem.Location = new Point(lSem.Location.X + 100, lSem.Location.Y);
                lAddScore.Location = new Point(lAddScore.Location.X + 100, lAddScore.Location.Y);
                bSem.Location = new Point(bSem.Location.X + 100, bSem.Location.Y);
                cbSemester.Location = new Point(cbSemester.Location.X + 100, cbSemester.Location.Y);
                tbSubID.Location = new Point(tbSubID.Location.X + 100, tbSubID.Location.Y);
                tbSubName.Location = new Point(tbSubName.Location.X + 100, tbSubName.Location.Y);
                tbCredit.Location = new Point(tbCredit.Location.X + 100, tbCredit.Location.Y);

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
                cardAcc.Width += 125;

                cardTheme.Location = new Point(cardTheme.Location.X + 150, cardTheme.Location.Y);
                cardTheme.Width += 50;
                cardMore.Width += 125;

                bSetData.Location = new Point(bSetData.Location.X + 25, bSetData.Location.Y);
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            //this.btnHome.Normalcolor = Color.CornflowerBlue;
            //temp.Normalcolor = Properties.Settings.Default.Color;
            this.btnHome.Normalcolor = Properties.Settings.Default.Color;
            panelHome.Dock = DockStyle.Fill;
            panelHome.BringToFront();
            temp = btnHome;

            lAverAll.Text = "Điểm trung bình: " + data.Average.ToString();
            lCreSum.Text = "Tín chỉ tích luỹ: " + data.SumOfCre.ToString();
        }
        private void btnScore_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            //this.btnScore.Normalcolor = Color.CornflowerBlue;
            //temp.Normalcolor = Properties.Settings.Default.Color;
            this.btnScore.Normalcolor = Properties.Settings.Default.Color;
            panelScore.Dock = DockStyle.Fill;
            panelScore.BringToFront();
            temp = btnScore;
        }
        private void bNofitication_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            //this.btnNofitication.Normalcolor = Color.CornflowerBlue
            //temp.Normalcolor = Properties.Settings.Default.Color;
            this.btnNofitication.Normalcolor = Properties.Settings.Default.Color;
            temp = btnNofitication;
            this.panelNoti.Dock = DockStyle.Fill;
            panelNoti.BringToFront();
        }
        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            //this.btnTimeTable.Normalcolor = Color.CornflowerBlue;
            //temp.Normalcolor = Properties.Settings.Default.Color;
            this.btnTimeTable.Normalcolor = Properties.Settings.Default.Color;
            this.panelTimetable.Dock = DockStyle.Fill;
            panelTimetable.BringToFront();
            temp = btnTimeTable;

            if (cbxSem.Items.IndexOf(Properties.Settings.Default.Text) >= 0)
            {
                cbxSem.SelectedItem = cbxSem.Items[cbxSem.Items.IndexOf(Properties.Settings.Default.Text)];
                btnLoadTT_Click(sender, e);
            }
        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            //this.btnInformation.Normalcolor = Color.CornflowerBlue;
            //temp.Normalcolor = Properties.Settings.Default.Color;
            this.btnInformation.Normalcolor = Properties.Settings.Default.Color;
            this.panelInfo.Dock = DockStyle.Fill;
            panelInfo.BringToFront();
            temp = btnInformation;
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            //this.btnSetting.Normalcolor = Color.CornflowerBlue;
            //temp.Normalcolor = Properties.Settings.Default.Color;
            this.btnSetting.Normalcolor = Properties.Settings.Default.Color;
            this.panelSetting.Dock = DockStyle.Fill;
            panelSetting.BringToFront();
            temp = btnSetting;
        }
        private void btnSocial_Click(object sender, EventArgs e)
        {
            temp.Normalcolor = Color.FromArgb(26, 32, 40);
            this.btnSocial.Normalcolor = Properties.Settings.Default.Color;
            this.panelSocial.Dock = DockStyle.Fill;
            panelSocial.BringToFront();
            temp = btnSocial;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Dung
                GetDeadline("SELECT * FROM DEADLINE WHERE ID_USER='" + User.ID + "'");
                NearestDeadline();
                LoadToHomeDeadline();
                NotifiDeadline();

                //Danh
                this.lbHello.Text += " " + this.User.Name + "! \nChúc một ngày tốt lành!";
                dataGridViewHomeTimeTB.Columns[1].HeaderText = SwitchTodayToVNese(DateTime.Today.DayOfWeek.ToString());

                AddRowsToTimetableDataGridViews();
                ReadSchedulesSemesterComboboxItems();
                if (cbxSem.Items.IndexOf(Properties.Settings.Default.Text) >= 0)
                {
                    LoadTodayTimetable();
                }
                dataGridViewTimetable.CurrentCell.Selected = !dataGridViewTimetable.CurrentCell.Selected;
                btnHome_Click(sender, e);
                LoadInformationTab();
                LoadNotes();

                //Linh
                tbCredit.Enabled = tbSubID.Enabled = tbSubName.Enabled = tbProVa.Enabled = tbProWei.Enabled
                = tbMidVa.Enabled = tbMidWei.Enabled = tbFinVa.Enabled = tbFinWei.Enabled = tbPracVa.Enabled = tbPracWei.Enabled = false;
                bAddScore.Visible = bModify.Visible = bDel.Visible = false;

                bExportScore.Visible = bstatisticsScore.Visible = false;

                bExitScore.Visible = false;

                AddItemToComboBoxSemester();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parent.Show();
        }
        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Restart()
        {
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
            Info.WindowStyle = ProcessWindowStyle.Hidden;
            Info.CreateNoWindow = true;
            Info.FileName = "cmd.exe";
            Process.Start(Info);
            Application.Exit();
        }
        private void MainForm_Move(object sender, EventArgs e)
        {
            this.Size = new Size(1600, 900);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ReviewForm ReviewForm = new ReviewForm(this.User.ID);
            this.Hide();
            ReviewForm.Show();
        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://mail.google.com/mail/u/0/#inbox?compose=new");
            Process.Start(sInfo);
        }

        private void dataDeadline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 7)
                    bEdit_Click(sender, e);
                if (e.ColumnIndex == 8)
                    bDelete_Click(sender, e);
            }
        }
    }
}

//Dung
namespace StudentSupportApp
{
    public partial class MainForm
    {
        #region Notification
        public void Alert(string msg)
        {
            Notifi notifi = new Notifi();
            notifi.showAlert(msg);
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
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
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
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        private void GetDeadline(string sQuery)
        {
            try
            {
                Deadlines[] ListDeadline = new Deadlines[1000];
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
                SqlDataReader reader = command.ExecuteReader();
                int temp = 0;
                string[] args = new string[6];
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    args[0] = reader.GetString(0);
                    args[1] = reader.GetString(1);
                    args[2] = reader.GetString(2);
                    args[3] = reader.GetString(3);
                    DateTime temp1 = reader.GetDateTime(4);
                    args[4] = reader.GetString(5);
                    args[5] = reader.GetInt32(7).ToString();
                    ListDeadline[temp] = new Deadlines(args, temp1);
                    temp++;
                }
                foreach (Deadlines DL in ListDeadline)
                {
                    if (DL == null)
                        break;
                    dataDeadline.Rows.Add(DL.ID, DL.SubjectCode, DL.Subject, DL.Details, DL.TimeSubmit, DL.Status, DL.Progress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        private void NotifiDeadline()
        {
            try
            {
                Deadlines[] ListDeadline = new Deadlines[1000];
                string sQuery = "SELECT * FROM DEADLINE WHERE YEAR(DATESUBMIT) = YEAR(GETDATE()) AND MONTH(DATESUBMIT) = MONTH(GETDATE()) AND DAY(DATESUBMIT) = DAY(GETDATE()) AND STATU='1' AND ID_USER = '" + this.User.ID + "'";
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
                foreach (Deadlines DL in ListDeadline)
                {
                    if (DL == null)
                        break;
                    this.Alert(DL.SubjectCode + " | " + DL.Details + " | Today: " + DL.TimeSubmit.TimeOfDay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        private void LoadToHomeDeadline()
        {
            Deadlines[] temp = new Deadlines[5];
            string Top5Deadlilne = "SELECT TOP (5) * FROM DEADLINE WHERE ID_USER='" + this.User.ID + "' AND STATU < 100 ORDER BY DEADLINE.DATESUBMIT ASC";
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
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        private void addDeadline(string[] temp)
        {
            try
            {
                this.Connection.OpenConnection();
                temp[0] = "1";
                User.GetDeadlineID(ref temp[0]);
                temp[6] = "0";
                this.dataDeadline.Rows.Add(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6]);
                string Query = "INSERT INTO DEADLINE VALUES('" + temp[0] + "', N'" + temp[1] + "', '" + temp[2] + "', N'" +
                                                                temp[3] + "', '" + temp[4] + "', N'" + temp[5] + "', '" + this.User.ID + "', " + temp[6] + ")";
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
                MessageBox.Show(" ADDED SUCCESSFULLY!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        #region EventHandler
        private void bEdit_Click(object sender, EventArgs e)
        {
            this.bEditSave.Visible = true;
            this.btbDetails.Enabled = true;
            this.btbStatus.Enabled = true;
            this.btbSubject.Enabled = true;
            this.sliderProgress.Enabled = true;
        }
        private void bRefresh_Click(object sender, EventArgs e)
        {
            Deadlines[] ListDeadline = new Deadlines[1000];
            try
            {
                while (dataDeadline.Rows.Count > 1)
                {
                    dataDeadline.Rows.RemoveAt(0);
                }
                string sQuery = "SELECT * FROM DEADLINE WHERE ID_USER='" + this.User.ID + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
                SqlDataReader reader = command.ExecuteReader();
                int temp = 0;
                string[] args = new string[6];
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    args[0] = reader.GetString(0);
                    args[1] = reader.GetString(1);
                    args[2] = reader.GetString(2);
                    args[3] = reader.GetString(3);
                    DateTime temp1 = reader.GetDateTime(4);
                    args[4] = reader.GetString(5);
                    args[5] = reader.GetInt32(7).ToString();
                    ListDeadline[temp] = new Deadlines(args, temp1);
                    temp++;
                }
                foreach (Deadlines DL in ListDeadline)
                {
                    if (DL == null)
                        break;
                    dataDeadline.Rows.Add(DL.ID, DL.SubjectCode, DL.Subject, DL.Details, DL.TimeSubmit, DL.Status, DL.Progress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
            finally
            {
                this.Connection.CloseConnection();
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
                    MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                    ReportError rp = new ReportError(this, ex);
                    rp.Show();
                    this.Hide();
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
        private void dataDeadline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            try
            {
                if (dataDeadline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataDeadline.CurrentRow.Selected = true;
                    labelID.Text = dataDeadline.Rows[e.RowIndex].Cells[0].Value.ToString();
                    btbSubject.Text = dataDeadline.Rows[e.RowIndex].Cells[2].Value.ToString();
                    btbDetails.Text = dataDeadline.Rows[e.RowIndex].Cells[3].Value.ToString();
                    bdateTime.Value = DateTime.Parse(dataDeadline.Rows[e.RowIndex].Cells[4].Value.ToString());
                    btbStatus.Text = dataDeadline.Rows[e.RowIndex].Cells[5].Value.ToString();
                    sliderProgress.Value = int.Parse(dataDeadline.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
        }
        private void bEditSave_Click(object sender, EventArgs e)
        {
            if (dataDeadline.Rows.Count <= 1)
                return;
            this.btbDetails.Enabled = false;
            this.btbStatus.Enabled = false;
            this.btbSubject.Enabled = false;
            this.bEditSave.Hide();
            try
            {
                string Query = "UPDATE DEADLINE SET DETAIL=N'" + btbDetails.Text + "', DATESUBMIT='" + bdateTime.Value.ToString() + "', STAT=N'" + btbStatus.Text + "', SUB_NAME=N'" + btbSubject.Text + "' STATU=N" + sliderProgress.Value.ToString()
                                                              + "' WHERE ID='" + labelID.Text + "'";
                Connection.OpenConnection();
                SqlCommand command = Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("SAVED!", "Notification", buttons);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
            finally
            {
                Connection.CloseConnection();
                bRefresh_Click(sender, e);
            }
        }
        private void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataDeadline.Rows.Count > 1)
            {
                dataDeadline.Rows.RemoveAt(0);
            }
            string sQuery = "";
            switch (cbView.Text)
            {
                case "Đã hoàn thành":
                    sQuery = "SELECT * FROM DEADLINE WHERE STATU = 100 AND ID_USER='" + User.ID + "'";
                    break;
                case "Chưa hoàn thành (Mặc định)":
                    sQuery = "SELECT * FROM DEADLINE WHERE STATU < 100 AND ID_USER='" + User.ID + "'";
                    break;
                case "Đã quá hạn":
                    sQuery = "SELECT * FROM DEADLINE WHERE GETDATE() > DATESUBMIT AND ID_USER='" + User.ID + "'"; ;
                    break;
                case "Chưa đến hạn":
                    sQuery = "SELECT * FROM DEADLINE WHERE GETDATE() <= DATESUBMIT AND ID_USER='" + User.ID + "'"; ;
                    break;
                default:
                    sQuery = "SELECT * FROM DEADLINE WHERE ID_USER='" + User.ID + "'";
                    break;
            }
            GetDeadline(sQuery);
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            DeadlineStatistic deadlineStatistic = new DeadlineStatistic(this, User.ID);
            deadlineStatistic.Show();
        }
        #endregion
        #endregion

        #region Community
        private void AddToListView(USER[] temp)
        {
            foreach (USER user in temp)
            {
                if (user == null)
                    break;
                listViewProfile.Items.Add(new ListViewItem(new string[] { user.ID, user.Name, user.Email }));
            }
        }
        #region EventHandler
        private void tbxFind_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                USER[] temp = new USER[100];
                int i = 0;
                Connection.OpenConnection();
                string Query = "SELECT * FROM USERS WHERE ID_USER LIKE '%" + tbxFind.Text + "%' OR FULLNAME LIKE '%" + tbxFind.Text + "%'";
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                        break;
                    temp[i] = new USER();
                    temp[i].ID = reader.GetString(0);
                    temp[i].Name = reader.GetString(4);
                    temp[i].Email = reader.GetString(1);
                    i++;
                }
                listViewProfile.Items.Clear();
                AddToListView(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
                this.Hide();
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        private void listViewProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxID.Text = listViewProfile.SelectedItems[0].SubItems[0].Text;
            tbxName.Text = listViewProfile.SelectedItems[0].SubItems[1].Text;
            tbxEmail.Text = listViewProfile.SelectedItems[0].SubItems[2].Text;
        }
        private void btnReview_Click(object sender, EventArgs e)
        {
            ReviewForm ReviewForm = new ReviewForm(this.User.ID);
            ReviewForm.Show();
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriterRVForm Writer = new WriterRVForm(this, User.ID);
            Writer.Show();
        }
        #endregion
        #endregion
    }
}

//Danh
#region Danh
namespace StudentSupportApp
{
    public partial class MainForm
    {
        #region Timetable
        string Semester;

        private void AddRowsToTimetableDataGridViews()
        {
            string[] sRow = new string[] {"Tiết 1\n(7:30-8:15)", "Tiết 2\n(8:15-9:00)",
                "Tiết 3\n(9:00 - 9:45)" , "Tiết 4\n(10:00-10:45)", "Tiết 5\n(10:45-11:30)",
                "Tiết 6\n(13:00-13:45)", "Tiết 7\n(13:45-14:30)", "Tiết 8\n(14:30-15:15)",
                "Tiết 9\n(15:30-16:15)", "Tiết 10\n(16:15-17:00)"};
            for (int i = 0; i < sRow.Length; i++)
            {
                dataGridViewTimetable.Rows.Add(sRow[i]);
                dataGridViewHomeTimeTB.Rows.Add(sRow[i]);
            }
        }

        private string SwitchTodayToVNese(string today)
        {
            if (today == "Monday")
                return "Thứ hai";
            else if (today == "Tuesday")
                return "Thứ ba";
            else if (today == "Wednesday")
                return "Thứ tư";
            else if (today == "Thursday")
                return "Thứ năm";
            else if (today == "Friday")
                return "Thứ sáu";
            else if (today == "Saturday")
                return "Thứ bảy";
            else return "Chủ nhật";
        }

        private void btnCreNewLess_Click(object sender, EventArgs e)
        {
            try
            {
                AddLessonForm AddLesson = new AddLessonForm(this, this.User.ID, cbxSem.Text);
                AddLesson.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
            finally
            {
                Connection.CloseConnection();
            }
        }

        public void LoadTodayTimetable()
        {
            Timetable TodaySchedules = new Timetable(this.User.ID, Properties.Settings.Default.Text);
            TodaySchedules.LoadTodayTimetable(this.dataGridViewHomeTimeTB.Columns[1].HeaderText);
            TodaySchedules.LoadTimetableToHomeDGV(this.dataGridViewHomeTimeTB);
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
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        private void btnExportTT_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetable.Rows.Count > 0)
            {
                var fontPath = Path.Combine(Directory.GetCurrentDirectory(), "vuTimes.ttf");
                BaseFont vuTimes = iTextSharp.text.pdf.BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(vuTimes, 12, iTextSharp.text.Font.NORMAL);
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
                        catch (Exception ex)
                        {
                            fileError = true;
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                            ReportError rp = new ReportError(this, ex);
                            rp.Show();
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
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontNormal));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridViewTimetable.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(new iTextSharp.text.Phrase(cell.Value.ToString(), fontNormal));
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

                            MessageBox.Show("Xuất thời khóa biểu thành công!", "Xuất TKB");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                            ReportError rp = new ReportError(this, ex);
                            rp.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu để xuất trống!", "Cảnh Báo");
            }
        }

        private void btnModifyLess_Click(object sender, EventArgs e)
        {
            try
            {
                Timetable ti = new Timetable();
                if (this.dataGridViewTimetable.CurrentCell.Selected == true && this.dataGridViewTimetable.CurrentCell.Value.ToString() != "")
                {
                    int iSubID = this.dataGridViewTimetable.CurrentCell.Value.ToString().IndexOf("\n");
                    int iCellValueLength = this.dataGridViewTimetable.CurrentCell.Value.ToString().Length;
                    List<string> sLessonData = new List<string> { cbxSem.Text, ti.SwitchDayWithNumberToNumber(this.dataGridViewTimetable.Columns[this.dataGridViewTimetable.CurrentCell.ColumnIndex].HeaderText).ToString(),
                                                                  this.dataGridViewTimetable.CurrentCell.Value.ToString().Substring(0, iSubID),
                                                                  this.dataGridViewTimetable.CurrentCell.Value.ToString().Substring(iSubID, iCellValueLength - iSubID),
                                                                  (this.dataGridViewTimetable.CurrentCell.RowIndex + 1).ToString() };
                    ModLessonForm modLessonForm = new ModLessonForm(this, sLessonData, this.User.ID);
                    modLessonForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        private void btnRemoveLess_Click(object sender, EventArgs e)
        {
            try
            {
                Timetable ti = new Timetable();
                if (this.dataGridViewTimetable.CurrentCell.Selected == true && this.dataGridViewTimetable.CurrentCell.Value.ToString() != "")
                {
                    int iSubID = this.dataGridViewTimetable.CurrentCell.Value.ToString().IndexOf("\n");
                    int iCellValueLength = this.dataGridViewTimetable.CurrentCell.Value.ToString().Length;
                    List<string> sLessonData = new List<string> { cbxSem.Text, ti.SwitchDayWithNumberToNumber(this.dataGridViewTimetable.Columns[this.dataGridViewTimetable.CurrentCell.ColumnIndex].HeaderText).ToString(),
                                                                  this.dataGridViewTimetable.CurrentCell.Value.ToString().Substring(0, iSubID),
                                                                  this.dataGridViewTimetable.CurrentCell.Value.ToString().Substring(iSubID, iCellValueLength - iSubID),
                                                                  (this.dataGridViewTimetable.CurrentCell.RowIndex + 1).ToString(), this.User.ID };
                    Timetable Lesson = new Timetable(this.User.ID);
                    if (Lesson.RemoveLesson(sLessonData) == 1)
                    {
                        MessageBox.Show("Xóa tiết học thành công!", "Xóa tiết học");
                        this.dataGridViewTimetable.CurrentCell.Value = "";
                    }
                    else MessageBox.Show("Xóa tiết học thất bại!", "Xóa tiết học");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        private void btnDeleteTT_Click(object sender, EventArgs e)
        {
            Timetable ti = new Timetable(this.User.ID, this.cbxSem.Text);
            if (ti.RemoveTimetable() == 1)
            {
                this.dataGridViewTimetable.Rows.Clear();
                if (Properties.Settings.Default.Text == cbxSem.Text)
                {
                    this.dataGridViewHomeTimeTB.Rows.Clear();
                    Properties.Settings.Default.Text = "";
                    Properties.Settings.Default.Save();
                }
                this.cbxSem.Items.Clear();
                AddRowsToTimetableDataGridViews();
                ReadSchedulesSemesterComboboxItems();
                MessageBox.Show("Xóa TKB thành công", "Xóa TKB");

            }
            else MessageBox.Show("Xóa TKB thất bại", "Xóa TKB");
        }

        private void cbxSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoadTT.Visible = true;
        }
        //private void MainForm_VisibleChanged(object sender, EventArgs e)
        //{
        //    ReadSchedulesSemesterComboboxItems();
        //    cbxSem.Text = this.Semester;
        //    LoadInformationTab();
        //}
        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Text = cbxSem.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Đã lưu!", "Đặt học kỳ mặc định");
        }
        #endregion

        #region Information Tab
        private void LoadInformationTab()
        {
            Connect Info = new Connect();
            try
            {
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

                ShowUserInformation(sData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
            finally
            {
                Info.CloseConnection();
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
                    const string message = "Thông tin của bạn đang trống. Bạn chắc chắn muốn tiếp tục?";
                    const string caption = "Chỉnh sửa thông tin";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] sInfo = new string[] { tbxNameInfo.Text, BirthDTPicker.Value.ToString(),
                                                            tbxGenderInfo.Text, tbxClassInfo.Text };
                        if (this.User.UpdateUserInfo(this.User.ID, sInfo) == 1)
                        {
                            MessageBox.Show("Chỉnh sửa thông tin thành công!", "Chỉnh sửa thông tin");
                        }
                        else MessageBox.Show("Chỉnh sửa thất bại. Vui lòng kiểm tra và thử lại!", "Chỉnh sửa thông tin");
                    }
                }
                else
                {
                    string[] sInfo = new string[] { tbxNameInfo.Text, BirthDTPicker.Value.ToString(),
                                                            tbxGenderInfo.Text, tbxClassInfo.Text };
                    if (this.User.UpdateUserInfo(this.User.ID, sInfo) == 1)
                    {
                        MessageBox.Show("Chỉnh sửa thông tin thành công!", "Chỉnh sửa thông tin");
                    }
                    else MessageBox.Show("Chỉnh sửa thất bại. Vui lòng kiểm tra và thử lại!", "Chỉnh sửa thông tin");
                }

                btnChangeInfo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }

        private void btnCancelInfo_Click(object sender, EventArgs e)
        {
            const string message = "Thay đổi của bạn sẽ không được lưu lại. Bạn chắc chắn muốn tiếp tục?";
            const string caption = "Hủy bỏ thay đổi";
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
        #endregion

        #region Documents
        private void dataGridViewTimetable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex > 0 && e.RowIndex >= 0)
                {
                    if (dataGridViewTimetable.CurrentCell.Value.ToString() != "")
                    {
                        int iSubID = this.dataGridViewTimetable.CurrentCell.Value.ToString().IndexOf("\n");
                        int iCellValueLength = this.dataGridViewTimetable.CurrentCell.Value.ToString().Length;
                        List<string> sLessonData = new List<string> { cbxSem.Text, this.dataGridViewTimetable.Columns[this.dataGridViewTimetable.CurrentCell.ColumnIndex].Name,
                                                                  this.dataGridViewTimetable.CurrentCell.Value.ToString().Substring(0, iSubID),
                                                                  this.dataGridViewTimetable.CurrentCell.Value.ToString().Substring(iSubID, iCellValueLength - iSubID),
                                                                  (this.dataGridViewTimetable.CurrentCell.RowIndex + 1).ToString(), this.User.ID };
                        Documents doc = new Documents(this, sLessonData);
                        doc.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }
        #endregion

        #region Note
        private void btnDelNote_Click(object sender, EventArgs e)
        {
            if (dataGridViewNote.SelectedCells.Count > 0)
            {
                DeleleNoteFromDatabase(dataGridViewNote.SelectedCells[0].Value.ToString());
            }

            dataGridViewNote.Rows.Clear();
            LoadNotes();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm(this.User.ID);
            noteForm.Show();
        }

        private void dataGridViewNote_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Note note = new Note(this.User.ID);
            note.Name = dataGridViewNote.Rows[e.RowIndex].Cells[0].Value.ToString();
            note.UserID = this.User.ID;
            note.LoadNoteData();

            NoteForm noteForm = new NoteForm(this.User.ID, note.Name, note.Detail);
            noteForm.Width = note.Width;
            noteForm.Height = note.Height;

            noteForm.Show();
        }

        private void LoadNotes()
        {
            try
            {
                string Query = "SELECT NOTE_NAME FROM NOTE WHERE ID_USER='" + this.User.ID + "'";
                this.Connection.OpenConnection();

                SqlCommand loadName = Connection.CreateSQLCmd(Query);
                SqlDataReader reader = loadName.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        string name = reader.GetString(0);
                        dataGridViewNote.Rows.Add(name);
                    }
                    else break;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }

        private void DeleleNoteFromDatabase(string name)
        {
            try
            {
                string sQuery = "DELETE NOTE WHERE NOTE_NAME=N'" + name + "' AND ID_USER='" + this.User.ID + "'";
                Connection.OpenConnection();

                SqlCommand Command = Connection.CreateSQLCmd(sQuery);
                Command.ExecuteNonQuery();
                MessageBox.Show("Xóa ghi chú thành công!", "Xóa ghi chú");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(ex);
                rp.Show();
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        #endregion
    }
}
#endregion

//Linh
#region Linh
namespace StudentSupportApp
{
    public partial class MainForm
    {
        #region Score
        public void ShowScoresToListView(string semester)
        {
            try
            {
                bDel.Visible = false;
                bModify.Visible = false;
                //lvScoreBoard.Clear();
                data.SEMESTERS.Clear();
                data.Read(this.User.ID);
                data.GetSemester(data.FindSem(semester)).SCORETABLE.ShowToListView(lvScoreBoard);

                lAmountSub.Text = "Số lượng môn học: " + data.GetSemester(data.FindSem(semester)).SCORETABLE.Amount.ToString();
                l_Average.Text = "Điểm trung bình: " + data.GetSemester(data.FindSem(semester)).SCORETABLE.Average.ToString();
                lSumCre.Text = "Tổng tín chỉ: " + data.GetSemester(data.FindSem(semester)).SCORETABLE.SumOfCred.ToString();

                tbSubID.Text = tbSubName.Text = tbCredit.Text = tbProVa.Text = tbMidVa.Text = tbPracVa.Text = tbFinVa.Text
               = tbProWei.Text = tbMidWei.Text = tbPracWei.Text = tbFinWei.Text = "";
            }
            catch (Exception err)
            {

                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();

            }
        }
        private void ResetTextbox()
        {
            this.tbCredit.Text = "Số tín chỉ";
            this.tbSubID.Text = "ID môn học";
            this.tbSubName.Text = "Tên môn học";

            tbProVa.Text = tbMidVa.Text = tbPracVa.Text = tbFinVa.Text = "Điểm";
            tbProWei.Text = tbMidWei.Text = tbPracWei.Text = tbFinWei.Text = "Tỉ lệ";
        }
        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sSemester = cbSemester.SelectedItem.ToString();
                data.SEMESTERS.Clear();
                data.Read(this.User.ID);
                lvScoreBoard.Items.Clear();
                ShowScoresToListView(sSemester);

                bAddScore.Visible = bModify.Visible = bDel.Visible = true;
                tbSubID.Enabled = tbSubName.Enabled = tbCredit.Enabled = true;
                tbMidVa.Enabled = tbMidWei.Enabled = true;
                tbPracVa.Enabled = tbPracWei.Enabled = true;
                tbProVa.Enabled = tbProWei.Enabled = true;
                tbFinVa.Enabled = tbFinWei.Enabled = true;

                bModify.Visible = bDel.Visible = false;
                bExportScore.Visible = bstatisticsScore.Visible = true;
                data.SEMESTERS.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
            }

            //ResetTextbox();
        }
        private void bModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (BlankData())
                {
                    MessageBox.Show("Dữ liệu trống! \nChắc chắn rằng ID MÔN HỌC, TÊN MÔN HỌC và SỐ TÍN CHỈ không được bỏ trống. " +
                        "\nNếu có cột điểm trống, hãy điền '0' cho ĐIỂM và TỈ LỆ", "CHỈNH SỬA ĐIỂM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string message = "Bạn có muốn chỉnh sửa?";
                    string caption = "Chỉnh sửa";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Subject sub = new Subject(tbSubID.Text, tbSubName.Text, int.Parse(tbCredit.Text));
                        CScore s1 = new CScore(float.Parse(tbProVa.Text), float.Parse(tbProWei.Text));
                        CScore s2 = new CScore(float.Parse(tbMidVa.Text), float.Parse(tbMidWei.Text));
                        CScore s3 = new CScore(float.Parse(tbPracVa.Text), float.Parse(tbPracWei.Text));
                        CScore s4 = new CScore(float.Parse(tbFinVa.Text), float.Parse(tbFinWei.Text));

                        ScoreOfSub scTmp = new ScoreOfSub(sub, s1, s2, s3, s4);
                        MessageBox.Show("Đã chỉnh sửa!", caption);

                        lvScoreBoard.Items.Clear();
                        scTmp.Modify(this.User.ID, cbSemester);

                        ShowScoresToListView(cbSemester.SelectedItem.ToString());
                    }
                    bAddScore.Visible = true;
                    tbSubID.Enabled = tbSubName.Enabled = tbCredit.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
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
                    MessageBox.Show("Dữ liệu trống! \nChắc chắn rằng ID MÔN HỌC, TÊN MÔN HỌC và SỐ TÍN CHỈ không được bỏ trống. " +
                        "\nNếu có cột điểm trống, hãy điền '0' cho ĐIỂM và TỈ LỆ", "THÊM ĐIỂM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Đã thêm!", "THÊM ĐIỂM SỐ");

                    lvScoreBoard.Items.Clear();
                    ShowScoresToListView(cbSemester.SelectedItem.ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
            }
        }
        private void bDel_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Bạn có muốn xoá?";
                string caption = "XOÁ";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Connection.OpenConnection();
                    string sql = @"Delete FROM TableScore WHERE(SUB_ID= '" + tbSubID.Text + "')";
                    sql += @"Delete From Subjects where(SUB_ID= '" + tbSubID.Text + "' and ID ='" + this.User.ID + "')";
                    SqlCommand command = Connection.CreateSQLCmd(sql);
                    command.ExecuteNonQuery();
                    Connection.CloseConnection();
                    MessageBox.Show("Đã xoá!", caption);

                    lvScoreBoard.Items.Clear();
                    ShowScoresToListView(cbSemester.SelectedItem.ToString());
                }
                bAddScore.Enabled = true;
                tbSubID.Enabled = tbSubName.Enabled = tbCredit.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
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
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, a);
                rp.Show();
                this.Hide();
            }
            finally
            {
                Connection.CloseConnection();
            }

            lAmountSub.Text = "Số môn học: ";
            l_Average.Text = "Điểm trung bình: ";
            lSumCre.Text = "Số tín chỉ:";
        }
        private void lvScoreBoard_Click(object sender, EventArgs e)
        {
            try
            {
                bAddScore.Visible = false;
                bDel.Visible = true;
                bModify.Visible = true;
                bExitScore.Visible = true;

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
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
            }
        }
        private void tbCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab))
            {
                MessageBox.Show("Hãy nhập số");
            }
        }
        private void tbProVa_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Hãy nhập số");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Sử dụng ',' để nhập giá trị số thực");

        }
        private void tbProWei_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Hãy nhập số");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Sử dụng ',' để nhập giá trị số thực");

        }
        private void tbMidVa_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Hãy nhập số");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Sử dụng ',' để nhập giá trị số thực");

        }
        private void tbMidWei_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Hãy nhập số");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Sử dụng ',' để nhập giá trị số thực");

        }
        private void tbPracVa_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Hãy nhập số");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Sử dụng ',' để nhập giá trị số thực");

        }
        private void tbPracWei_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Hãy nhập số");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Sử dụng ',' để nhập giá trị số thực");

        }
        private void tbFinVa_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Hãy nhập số");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Sử dụng ',' để nhập giá trị số thực");

        }
        private void tbFinWei_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
            {
                MessageBox.Show("Hãy nhập số");
            }
            if (e.KeyCode == Keys.OemPeriod)
                MessageBox.Show("Sử dụng ',' để nhập giá trị số thực");

        }

        private void bExportScore_Click(object sender, EventArgs e)
        {
            if (lvScoreBoard.Items.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                var fontPath = Path.Combine(Directory.GetCurrentDirectory(), "vuTimes.ttf");
                BaseFont vuTimes = iTextSharp.text.pdf.BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(vuTimes, 12, iTextSharp.text.Font.NORMAL);
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Bảng điểm " + this.cbSemester.Text + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            fileError = true;
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                            ReportError rp = new ReportError(this, ex);
                            rp.Show();
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(this.lvScoreBoard.Columns.Count - 4);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_MIDDLE;

                            for (int i = 0; i < lvScoreBoard.Columns.Count - 4; i++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(lvScoreBoard.Columns[i].Text, fontNormal));
                                pdfTable.AddCell(cell);

                            }

                            for (int i = 0; i < lvScoreBoard.Items.Count; i++)
                            {
                                for (int j = 0; j < lvScoreBoard.Columns.Count - 4; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(lvScoreBoard.Items[i].SubItems[j].Text, fontNormal));
                                    pdfTable.AddCell(cell);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);

                                pdfDoc.Open();

                                pdfDoc.Add(new Paragraph("Họ và tên: " + User.Name.ToString(), fontNormal));
                                pdfDoc.Add(new Paragraph(l_Average.Text.ToString(), fontNormal));
                                pdfDoc.Add(new Paragraph(lSumCre.Text.ToString(), fontNormal));
                                pdfDoc.Add(new Paragraph(lAmountSub.Text.ToString(), fontNormal));
                                pdfDoc.Add(new Paragraph("\n\n"));
                                pdfDoc.Add(new Paragraph("Bảng điểm " + this.cbSemester.Text.ToUpper(), fontNormal));
                                pdfDoc.Add(new Paragraph("\n\n"));

                                pdfDoc.Add(pdfTable);

                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Xuất bảng điểm thành công!", "Xuất bảng điểm");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                            ReportError rp = new ReportError(this, ex);
                            rp.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu để xuất trống!", "Cảnh Báo");
            }
        }

        private void bStatiticsScore_Click(object sender, EventArgs e)
        {
            ScoreStatistics form = new ScoreStatistics(this, this.User.ID, this.cbSemester.Text);
            this.Hide();
            form.Show();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            ResetTextbox();
            bAddScore.Visible = true;
            bExitScore.Visible = bModify.Visible = bDel.Visible = false;
        }
        #endregion

        #region Settings
        private void bSetData_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn cài đặt về mặc định? Dữ liệu của bạn sẽ bị xoá!", "CÀI ĐẶT MẶC ĐỊNH", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    User.SetDataDefault();
                    MessageBox.Show("Đã xong!", "CÀI ĐẶT MẶC ĐỊNH", MessageBoxButtons.OK);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
            }

        }
        private void bChangePass_Click(object sender, EventArgs e)
        {

        }
        private void bDelAcc_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xoá tài khoản này? Tất cả dữ liệu của bạn sẽ bị xoá!", "XOÁ TÀI KHOẢN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                if (result == DialogResult.OK)
                {
                    this.Close();
                    User.DeleteUser();
                    MessageBox.Show("Đã xong!", "XOÁ TÀI KHOẢN", MessageBoxButtons.OK);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, err);
                rp.Show();
                this.Hide();
            }
            finally
            {
                Application.Exit();
            }
        }

        private void bAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs form = new AboutUs(this);
            this.Hide();
            form.Show();
        }

        private void bFeedSup_Click(object sender, EventArgs e)
        {
            Feedback form = new Feedback(this, User.Email, this.User.ID);
            this.Hide();
            form.Show();
        }
        #endregion

        #region ChangePass
        private void bChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePass form = new ChangePass(this, this.User.ID, this.User.Password);
            form.Show();
        }
        #endregion

        #region Themes
        void SetColorTabHome(Color x)
        {
            lbHello.ForeColor =
            lbTodayTT.ForeColor =
            lbNearDeadline.ForeColor =
            lbAvgScore.ForeColor =
            lbNote.ForeColor =
            btnAddNote.ActiveFillColor = btnAddNote.ActiveLineColor = btnAddNote.IdleLineColor = btnAddNote.IdleForecolor =
            btnDelNote.ActiveFillColor = btnDelNote.ActiveLineColor = btnDelNote.IdleLineColor = btnDelNote.IdleForecolor =
            bunifuCardsNote.color =
            dataGridViewNote.HeaderBgColor =
            dataGridViewHomeTimeTB.HeaderBgColor =
            dataHomeDeadline.HeaderBgColor =
            bunifuCardTodayTT.color = bunifuCards4.color =
            bunifuCards5.color = cardWeb.color =
             bAddWeb.ActiveFillColor = bAddWeb.ForeColor = bAddWeb.IdleForecolor = bAddWeb.IdleLineColor =
             lWeb.ForeColor =
            x;
        }

        void SetColorTabScore(Color x)
        {
            lAddScore.ForeColor =
                lSBoard.ForeColor =
                cardAddScore.color = cardSBoard.color = x;

            tbCredit.LineFocusedColor = tbCredit.LineMouseHoverColor =
                tbSubID.LineMouseHoverColor = tbSubID.LineFocusedColor =
                tbSubName.LineFocusedColor = tbSubName.LineMouseHoverColor =

            tbProVa.LineMouseHoverColor = tbProVa.LineFocusedColor =
            tbProWei.LineMouseHoverColor = tbProWei.LineFocusedColor =
            tbPracVa.LineMouseHoverColor = tbPracVa.LineFocusedColor =
            tbPracWei.LineFocusedColor = tbPracWei.LineMouseHoverColor =
            tbMidVa.LineMouseHoverColor = tbMidVa.LineFocusedColor =
            tbMidWei.LineMouseHoverColor = tbMidWei.LineFocusedColor =
            tbFinVa.LineMouseHoverColor = tbFinVa.LineFocusedColor =
            tbFinWei.LineFocusedColor = tbFinWei.LineMouseHoverColor =

             bExitScore.ActiveFillColor = bExitScore.ForeColor = bExitScore.IdleLineColor = bExitScore.IdleForecolor = bExitScore.ActiveLineColor = x;
           

        }

        void SetColorTabNoti(Color x)
        {
            bunifuCustomLabel1.ForeColor =
                labelNum.ForeColor =
                bunifuSeparator2.ForeColor = bunifuSeparator2.LineColor =
                labelDate.ForeColor =
                cardStatus.color =

            cardInfo.color =
            bunifuCustomLabel4.ForeColor =
            //bdateTime.ForeColor = 
            bdateTime.BackColor =
            btbSubject.LineMouseHoverColor = btbSubject.LineFocusedColor =
            btbStatus.LineMouseHoverColor = btbStatus.LineFocusedColor =
            btbDetails.LineMouseHoverColor = btbDetails.LineFocusedColor =

            cardDeadline.color =
            labelDeadline.ForeColor =
            dataDeadline.HeaderBgColor = x;

            bAdd.ActiveFillColor = bAdd.ActiveLineColor = bAdd.IdleLineColor = bAdd.IdleForecolor =
            bEdit.ActiveFillColor = bEdit.ActiveLineColor = bEdit.IdleLineColor = bEdit.IdleForecolor =
            bDelete.ActiveFillColor = bDelete.ActiveLineColor = bDelete.IdleLineColor = bDelete.IdleForecolor =
            bEditSave.ActiveFillColor = bEditSave.ActiveLineColor = bEditSave.IdleLineColor = bEditSave.IdleForecolor =
            bRefresh.ActiveFillColor = bRefresh.ActiveLineColor = bRefresh.IdleLineColor = bRefresh.IdleForecolor = 
            btnStatistic.ActiveFillColor = btnStatistic.ActiveLineColor = btnStatistic.IdleLineColor = btnStatistic.IdleForecolor = x;
        }

        void SetColorTabTimeTable(Color x)
        {
            bCardTimeline.color =
                lbTimeline.ForeColor =
                btnLoadTT.ActiveFillColor = btnLoadTT.ActiveLineColor = btnLoadTT.IdleLineColor = btnLoadTT.IdleForecolor =
                btnSetDefault.ActiveFillColor = btnSetDefault.ActiveLineColor = btnSetDefault.IdleLineColor = btnSetDefault.IdleForecolor =

            bCardFunc.color =
            lbFunc.ForeColor =
            btnCreNewLess.ActiveFillColor = btnCreNewLess.ActiveLineColor = btnCreNewLess.IdleLineColor = btnCreNewLess.IdleForecolor =
            btnModifyLess.ActiveFillColor = btnModifyLess.ActiveLineColor = btnModifyLess.IdleLineColor = btnModifyLess.IdleForecolor =
            btnExportTT.ActiveFillColor = btnExportTT.ActiveLineColor = btnExportTT.IdleLineColor = btnExportTT.IdleForecolor =
            btnRemoveLess.ActiveFillColor = btnRemoveLess.ActiveLineColor = btnRemoveLess.IdleLineColor = btnRemoveLess.IdleForecolor =
            btnDeleteTT.ActiveFillColor = btnDeleteTT.ActiveLineColor = btnDeleteTT.IdleLineColor = btnDeleteTT.IdleForecolor =

            bCardTimetable.color = lbTimetable.ForeColor = x;
        }

        void SetColorTabInfo(Color x)
        {
            bunifuCardUserInfo.color = lbUserInfo.ForeColor = BirthDTPicker.BackColor =
                 btnChangeInfo.ActiveFillColor = btnChangeInfo.ActiveLineColor = btnChangeInfo.IdleLineColor = btnChangeInfo.IdleForecolor =
                  btnSaveInfo.ActiveFillColor = btnSaveInfo.ActiveLineColor = btnSaveInfo.IdleLineColor = btnSaveInfo.IdleForecolor =
                   btnCancelInfo.ActiveFillColor = btnCancelInfo.ActiveLineColor = btnCancelInfo.IdleLineColor = btnCancelInfo.IdleForecolor =

                   bunifuCardAcc.color = lbAccount.ForeColor =
                    btnChangeEmail.ActiveFillColor = btnChangeEmail.ActiveLineColor = btnChangeEmail.IdleLineColor = btnChangeEmail.IdleForecolor =
                     bChangePassword.ActiveFillColor = bChangePassword.ActiveLineColor = bChangePassword.IdleLineColor = bChangePassword.IdleForecolor =
                    tbxClassInfo.LineFocusedColor = tbxClassInfo.LineMouseHoverColor =
                     tbxEmailInfo.LineFocusedColor = tbxEmailInfo.LineMouseHoverColor =
                      tbxGenderInfo.LineFocusedColor = tbxGenderInfo.LineMouseHoverColor =
                       tbxNameInfo.LineFocusedColor = tbxNameInfo.LineMouseHoverColor =
                    x;
        }

        void SetColorTabSetting(Color x)
        {
            cardAcc.color = lAccHead.BackColor =
                 bSetData.Textcolor = bDelAcc.Textcolor =

                cardTheme.color = lThemeHead.BackColor = bSetTheme.Textcolor =

                cardMore.color = lMoreHead.BackColor =
                bFeedSup.Textcolor = bShareApp.Textcolor = bAboutUs.Textcolor = x;
        }
        void SetColorTabCommunity(Color x)
        {
            cardCommunity.color = cardProfile.color = cardSubRV.color =
                tbxFind.LineFocusedColor = tbxFind.LineMouseHoverColor =
                tbxID.LineFocusedColor = tbxID.LineMouseHoverColor =
                tbxName.LineFocusedColor = tbxName.LineMouseHoverColor =
                tbxEmail.LineFocusedColor = tbxEmail.LineMouseHoverColor = x;
        }

        void SetColorGUI(Color x)
        {
            header.BackColor =
                pLogo.BackColor =

            btnHome.BackColor = btnHome.Activecolor = btnHome.Normalcolor = btnHome.OnHovercolor = x;
            //btnScore.BackColor = btnScore.Activecolor = btnScore.Normalcolor = 
            btnScore.OnHovercolor = //btnScore.OnHoverTextColor =
            //btnNofitication.BackColor = btnNofitication.Activecolor = btnNofitication.Normalcolor = 
            btnNofitication.OnHovercolor = //btnNofitication.OnHoverTextColor =
            //btnInformation.BackColor = btnInformation.Activecolor = btnInformation.Normalcolor = 
            btnInformation.OnHovercolor = //btnInformation.OnHoverTextColor =
            //btnTimeTable.BackColor = btnTimeTable.Activecolor = btnTimeTable.Normalcolor = 
            btnTimeTable.OnHovercolor = //btnTimeTable.OnHoverTextColor =
            //btnSetting.BackColor = btnSetting.Activecolor = btnSetting.Normalcolor = 
            btnSetting.OnHovercolor = //btnSetting.OnHoverTextColor =
            //btnLogOut.BackColor = btnLogOut.Activecolor = btnLogOut.Normalcolor = 
            btnLogOut.OnHovercolor = //= btnLogOut.OnHoverTextColor
            btnSocial.OnHovercolor =
            btnCollapse.BackColor = x;
        }

        public void SetColorAll(Color x)
        {
            SetColorTabHome(x);
            SetColorTabScore(x);
            SetColorTabNoti(x);
            SetColorTabInfo(x);
            SetColorTabSetting(x);
            SetColorTabTimeTable(x);
            SetColorTabCommunity(x);
            SetColorGUI(x);
        }
        private void bSetTheme_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Color = Color.FromArgb(0, 102, 204);
            Properties.Settings.Default.Save();
            MessageBox.Show("Ứng dụng sẽ khởi động lại để thay đổi được áp dụng!");
            Restart();
        }
        private void bTheme1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Color = Color.HotPink;
            Properties.Settings.Default.Save();
            MessageBox.Show("Ứng dụng sẽ khởi động lại để thay đổi được áp dụng!");
            Restart();
        }
        private void bTheme2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Color = Color.Black;
            Properties.Settings.Default.Save();
            MessageBox.Show("Ứng dụng sẽ khởi động lại để thay đổi được áp dụng!");
            Restart();
        }
        private void bTheme3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Color = Color.Tomato;
            Properties.Settings.Default.Save();
            MessageBox.Show("Ứng dụng sẽ khởi động lại để thay đổi được áp dụng!");
            Restart();
        }
        private void bTheme4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Color = Color.Green;
            Properties.Settings.Default.Save();
            MessageBox.Show("Ứng dụng sẽ khởi động lại để thay đổi được áp dụng!");
            Restart();
        }
        #endregion

        #region Web
        public void ShowWebsToListView()
        {
            
            this.listWeb.ShowToListView(lvWeb);
        }

        private void bAddWeb_Click(object sender, EventArgs e)
        {
            DiaWeb form = new DiaWeb(this, this.User.ID, "add");
            this.Hide();
            form.Show();
        }

       private void lvWeb_MouseClick(object sender, MouseEventArgs e)
        {

            Web modWeb = new Web(this.User.ID, lvWeb.SelectedItems[0].SubItems[0].Text, lvWeb.SelectedItems[0].SubItems[1].Text);
            DiaWeb form = new DiaWeb(this, this.User.ID, modWeb, "modify");
            this.Hide();
            form.Show();
        }

        #endregion
    }
}
#endregion