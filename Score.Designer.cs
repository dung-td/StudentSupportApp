namespace StudentSupportApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader cID;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabScores = new System.Windows.Forms.TabPage();
            this.gbScoreTable = new System.Windows.Forms.GroupBox();
            this.lvScoreBoard = new System.Windows.Forms.ListView();
            this.cSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPrac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cW1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cW2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cW3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cW4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAddScore = new System.Windows.Forms.GroupBox();
            this.tbFinWei = new System.Windows.Forms.TextBox();
            this.tbFinVa = new System.Windows.Forms.TextBox();
            this.tbPracWei = new System.Windows.Forms.TextBox();
            this.tbPracVa = new System.Windows.Forms.TextBox();
            this.tbMidWei = new System.Windows.Forms.TextBox();
            this.tbMidVa = new System.Windows.Forms.TextBox();
            this.tbProWei = new System.Windows.Forms.TextBox();
            this.tbProVa = new System.Windows.Forms.TextBox();
            this.lFin = new System.Windows.Forms.Label();
            this.lPract = new System.Windows.Forms.Label();
            this.lMid = new System.Windows.Forms.Label();
            this.lPro = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.lWei = new System.Windows.Forms.Label();
            this.bModify = new System.Windows.Forms.Button();
            this.lCre = new System.Windows.Forms.Label();
            this.lSubName = new System.Windows.Forms.Label();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.tbSubName = new System.Windows.Forms.TextBox();
            this.tbSubID = new System.Windows.Forms.TextBox();
            this.bDel = new System.Windows.Forms.Button();
            this.lSubID = new System.Windows.Forms.Label();
            this.bAddScore = new System.Windows.Forms.Button();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.tabNoti = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabGSettings = new System.Windows.Forms.TabPage();
            this.labelVer = new System.Windows.Forms.Label();
            cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabScores.SuspendLayout();
            this.gbScoreTable.SuspendLayout();
            this.gbAddScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // cID
            // 
            cID.Tag = "";
            cID.Text = "ID";
            cID.Width = 80;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabScores);
            this.tabControl1.Controls.Add(this.tabTimetable);
            this.tabControl1.Controls.Add(this.tabNoti);
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabGSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(791, 394);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "HOME";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabScores
            // 
            this.tabScores.Controls.Add(this.gbScoreTable);
            this.tabScores.Controls.Add(this.gbAddScore);
            this.tabScores.Location = new System.Drawing.Point(4, 22);
            this.tabScores.Name = "tabScores";
            this.tabScores.Padding = new System.Windows.Forms.Padding(3);
            this.tabScores.Size = new System.Drawing.Size(791, 394);
            this.tabScores.TabIndex = 1;
            this.tabScores.Text = "SCORES";
            this.tabScores.UseVisualStyleBackColor = true;
            this.tabScores.Click += new System.EventHandler(this.tabScores_Click);
            // 
            // gbScoreTable
            // 
            this.gbScoreTable.Controls.Add(this.lvScoreBoard);
            this.gbScoreTable.Location = new System.Drawing.Point(8, 195);
            this.gbScoreTable.Name = "gbScoreTable";
            this.gbScoreTable.Size = new System.Drawing.Size(778, 193);
            this.gbScoreTable.TabIndex = 12;
            this.gbScoreTable.TabStop = false;
            this.gbScoreTable.Text = "SCORE TABLE";
            // 
            // lvScoreBoard
            // 
            this.lvScoreBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            cID,
            this.cSub,
            this.cCre,
            this.cProc,
            this.cMid,
            this.cPrac,
            this.cFin,
            this.cW1,
            this.cW2,
            this.cW3,
            this.cW4,
            this.cAver});
            this.lvScoreBoard.HideSelection = false;
            this.lvScoreBoard.Location = new System.Drawing.Point(6, 19);
            this.lvScoreBoard.Name = "lvScoreBoard";
            this.lvScoreBoard.Size = new System.Drawing.Size(771, 197);
            this.lvScoreBoard.TabIndex = 0;
            this.lvScoreBoard.TileSize = new System.Drawing.Size(100, 25);
            this.lvScoreBoard.UseCompatibleStateImageBehavior = false;
            this.lvScoreBoard.View = System.Windows.Forms.View.Details;
            this.lvScoreBoard.Click += new System.EventHandler(this.lvScoreBoard_Click);
            // 
            // cSub
            // 
            this.cSub.Text = "SUBJECT";
            this.cSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cSub.Width = 200;
            // 
            // cCre
            // 
            this.cCre.Text = "CREDIT";
            this.cCre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cCre.Width = 80;
            // 
            // cProc
            // 
            this.cProc.Text = "PROCESS";
            this.cProc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cProc.Width = 100;
            // 
            // cMid
            // 
            this.cMid.Text = "MID";
            this.cMid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cMid.Width = 100;
            // 
            // cPrac
            // 
            this.cPrac.Text = "PRAC";
            this.cPrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cPrac.Width = 100;
            // 
            // cFin
            // 
            this.cFin.Text = "FINAL";
            this.cFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cFin.Width = 100;
            // 
            // cW1
            // 
            this.cW1.Text = "W1";
            this.cW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cW2
            // 
            this.cW2.Text = "W2";
            this.cW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cW3
            // 
            this.cW3.Text = "W3";
            this.cW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cW4
            // 
            this.cW4.Text = "W4";
            this.cW4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cAver
            // 
            this.cAver.Text = "AVERAGE";
            this.cAver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cAver.Width = 100;
            // 
            // gbAddScore
            // 
            this.gbAddScore.Controls.Add(this.tbFinWei);
            this.gbAddScore.Controls.Add(this.tbFinVa);
            this.gbAddScore.Controls.Add(this.tbPracWei);
            this.gbAddScore.Controls.Add(this.tbPracVa);
            this.gbAddScore.Controls.Add(this.tbMidWei);
            this.gbAddScore.Controls.Add(this.tbMidVa);
            this.gbAddScore.Controls.Add(this.tbProWei);
            this.gbAddScore.Controls.Add(this.tbProVa);
            this.gbAddScore.Controls.Add(this.lFin);
            this.gbAddScore.Controls.Add(this.lPract);
            this.gbAddScore.Controls.Add(this.lMid);
            this.gbAddScore.Controls.Add(this.lPro);
            this.gbAddScore.Controls.Add(this.lValue);
            this.gbAddScore.Controls.Add(this.lWei);
            this.gbAddScore.Controls.Add(this.bModify);
            this.gbAddScore.Controls.Add(this.lCre);
            this.gbAddScore.Controls.Add(this.lSubName);
            this.gbAddScore.Controls.Add(this.tbCredit);
            this.gbAddScore.Controls.Add(this.tbSubName);
            this.gbAddScore.Controls.Add(this.tbSubID);
            this.gbAddScore.Controls.Add(this.bDel);
            this.gbAddScore.Controls.Add(this.lSubID);
            this.gbAddScore.Controls.Add(this.bAddScore);
            this.gbAddScore.Location = new System.Drawing.Point(10, 12);
            this.gbAddScore.Name = "gbAddScore";
            this.gbAddScore.Size = new System.Drawing.Size(776, 196);
            this.gbAddScore.TabIndex = 11;
            this.gbAddScore.TabStop = false;
            this.gbAddScore.Text = "INFORMATION";
            // 
            // tbFinWei
            // 
            this.tbFinWei.Location = new System.Drawing.Point(584, 117);
            this.tbFinWei.Name = "tbFinWei";
            this.tbFinWei.Size = new System.Drawing.Size(100, 20);
            this.tbFinWei.TabIndex = 34;
            // 
            // tbFinVa
            // 
            this.tbFinVa.Location = new System.Drawing.Point(469, 118);
            this.tbFinVa.Name = "tbFinVa";
            this.tbFinVa.Size = new System.Drawing.Size(100, 20);
            this.tbFinVa.TabIndex = 33;
            // 
            // tbPracWei
            // 
            this.tbPracWei.Location = new System.Drawing.Point(584, 91);
            this.tbPracWei.Name = "tbPracWei";
            this.tbPracWei.Size = new System.Drawing.Size(100, 20);
            this.tbPracWei.TabIndex = 32;
            // 
            // tbPracVa
            // 
            this.tbPracVa.Location = new System.Drawing.Point(469, 91);
            this.tbPracVa.Name = "tbPracVa";
            this.tbPracVa.Size = new System.Drawing.Size(100, 20);
            this.tbPracVa.TabIndex = 31;
            // 
            // tbMidWei
            // 
            this.tbMidWei.Location = new System.Drawing.Point(584, 62);
            this.tbMidWei.Name = "tbMidWei";
            this.tbMidWei.Size = new System.Drawing.Size(100, 20);
            this.tbMidWei.TabIndex = 30;
            // 
            // tbMidVa
            // 
            this.tbMidVa.Location = new System.Drawing.Point(469, 62);
            this.tbMidVa.Name = "tbMidVa";
            this.tbMidVa.Size = new System.Drawing.Size(100, 20);
            this.tbMidVa.TabIndex = 29;
            // 
            // tbProWei
            // 
            this.tbProWei.Location = new System.Drawing.Point(584, 31);
            this.tbProWei.Name = "tbProWei";
            this.tbProWei.Size = new System.Drawing.Size(100, 20);
            this.tbProWei.TabIndex = 28;
            // 
            // tbProVa
            // 
            this.tbProVa.Location = new System.Drawing.Point(469, 31);
            this.tbProVa.Name = "tbProVa";
            this.tbProVa.Size = new System.Drawing.Size(100, 20);
            this.tbProVa.TabIndex = 27;
            // 
            // lFin
            // 
            this.lFin.AutoSize = true;
            this.lFin.Location = new System.Drawing.Point(409, 121);
            this.lFin.Name = "lFin";
            this.lFin.Size = new System.Drawing.Size(61, 13);
            this.lFin.TabIndex = 26;
            this.lFin.Text = "FinalExam: ";
            // 
            // lPract
            // 
            this.lPract.AutoSize = true;
            this.lPract.Location = new System.Drawing.Point(410, 94);
            this.lPract.Name = "lPract";
            this.lPract.Size = new System.Drawing.Size(60, 13);
            this.lPract.TabIndex = 25;
            this.lPract.Text = "Practicing: ";
            // 
            // lMid
            // 
            this.lMid.AutoSize = true;
            this.lMid.Location = new System.Drawing.Point(410, 66);
            this.lMid.Name = "lMid";
            this.lMid.Size = new System.Drawing.Size(53, 13);
            this.lMid.TabIndex = 24;
            this.lMid.Text = "MidExam:";
            // 
            // lPro
            // 
            this.lPro.AutoSize = true;
            this.lPro.Location = new System.Drawing.Point(409, 35);
            this.lPro.Name = "lPro";
            this.lPro.Size = new System.Drawing.Size(51, 13);
            this.lPro.TabIndex = 23;
            this.lPro.Text = "Process: ";
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Location = new System.Drawing.Point(498, 11);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(34, 13);
            this.lValue.TabIndex = 22;
            this.lValue.Text = "Value";
            // 
            // lWei
            // 
            this.lWei.AutoSize = true;
            this.lWei.Location = new System.Drawing.Point(614, 11);
            this.lWei.Name = "lWei";
            this.lWei.Size = new System.Drawing.Size(41, 13);
            this.lWei.TabIndex = 21;
            this.lWei.Text = "Weight";
            // 
            // bModify
            // 
            this.bModify.Location = new System.Drawing.Point(540, 148);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(75, 23);
            this.bModify.TabIndex = 20;
            this.bModify.Text = "Modify...";
            this.bModify.UseVisualStyleBackColor = true;
            this.bModify.Click += new System.EventHandler(this.button2_Click);
            // 
            // lCre
            // 
            this.lCre.AutoSize = true;
            this.lCre.Location = new System.Drawing.Point(28, 113);
            this.lCre.Name = "lCre";
            this.lCre.Size = new System.Drawing.Size(40, 13);
            this.lCre.TabIndex = 19;
            this.lCre.Text = "Credit: ";
            // 
            // lSubName
            // 
            this.lSubName.AutoSize = true;
            this.lSubName.Location = new System.Drawing.Point(28, 81);
            this.lSubName.Name = "lSubName";
            this.lSubName.Size = new System.Drawing.Size(77, 13);
            this.lSubName.TabIndex = 18;
            this.lSubName.Text = "Subject Name:";
            // 
            // tbCredit
            // 
            this.tbCredit.Location = new System.Drawing.Point(114, 109);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(214, 20);
            this.tbCredit.TabIndex = 17;
            // 
            // tbSubName
            // 
            this.tbSubName.Location = new System.Drawing.Point(112, 74);
            this.tbSubName.Name = "tbSubName";
            this.tbSubName.Size = new System.Drawing.Size(216, 20);
            this.tbSubName.TabIndex = 16;
            // 
            // tbSubID
            // 
            this.tbSubID.Location = new System.Drawing.Point(112, 43);
            this.tbSubID.Name = "tbSubID";
            this.tbSubID.Size = new System.Drawing.Size(216, 20);
            this.tbSubID.TabIndex = 15;
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(642, 148);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(96, 23);
            this.bDel.TabIndex = 10;
            this.bDel.Text = "Delete...";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lSubID
            // 
            this.lSubID.AutoSize = true;
            this.lSubID.Location = new System.Drawing.Point(29, 48);
            this.lSubID.Name = "lSubID";
            this.lSubID.Size = new System.Drawing.Size(63, 13);
            this.lSubID.TabIndex = 0;
            this.lSubID.Text = "Subject ID: ";
            // 
            // bAddScore
            // 
            this.bAddScore.Location = new System.Drawing.Point(364, 149);
            this.bAddScore.Name = "bAddScore";
            this.bAddScore.Size = new System.Drawing.Size(170, 23);
            this.bAddScore.TabIndex = 9;
            this.bAddScore.Text = "Add to ScoreTable";
            this.bAddScore.UseVisualStyleBackColor = true;
            this.bAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // tabTimetable
            // 
            this.tabTimetable.Location = new System.Drawing.Point(4, 22);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimetable.Size = new System.Drawing.Size(791, 394);
            this.tabTimetable.TabIndex = 2;
            this.tabTimetable.Text = "SCHEDULES";
            this.tabTimetable.UseVisualStyleBackColor = true;
            // 
            // tabNoti
            // 
            this.tabNoti.Location = new System.Drawing.Point(4, 22);
            this.tabNoti.Name = "tabNoti";
            this.tabNoti.Padding = new System.Windows.Forms.Padding(3);
            this.tabNoti.Size = new System.Drawing.Size(791, 394);
            this.tabNoti.TabIndex = 3;
            this.tabNoti.Text = "NOTIFICATIONS";
            this.tabNoti.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(791, 394);
            this.tabInfo.TabIndex = 4;
            this.tabInfo.Text = "INFORMATION";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tabGSettings
            // 
            this.tabGSettings.Location = new System.Drawing.Point(4, 22);
            this.tabGSettings.Name = "tabGSettings";
            this.tabGSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabGSettings.Size = new System.Drawing.Size(791, 394);
            this.tabGSettings.TabIndex = 5;
            this.tabGSettings.Text = "GENERAL SETTINGS";
            this.tabGSettings.UseVisualStyleBackColor = true;
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(667, 428);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(42, 13);
            this.labelVer.TabIndex = 1;
            this.labelVer.Text = "Version";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 448);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "StudentSupportApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabScores.ResumeLayout(false);
            this.gbScoreTable.ResumeLayout(false);
            this.gbAddScore.ResumeLayout(false);
            this.gbAddScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabScores;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.TabPage tabNoti;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabGSettings;
        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.Label lSubID;
        private System.Windows.Forms.Button bAddScore;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.GroupBox gbAddScore;
        private System.Windows.Forms.GroupBox gbScoreTable;
        private System.Windows.Forms.ListView lvScoreBoard;
        private System.Windows.Forms.ColumnHeader cSub;
        private System.Windows.Forms.ColumnHeader cCre;
        private System.Windows.Forms.ColumnHeader cProc;
        private System.Windows.Forms.ColumnHeader cMid;
        private System.Windows.Forms.ColumnHeader cPrac;
        private System.Windows.Forms.ColumnHeader cFin;
        private System.Windows.Forms.ColumnHeader cW1;
        private System.Windows.Forms.ColumnHeader cW2;
        private System.Windows.Forms.ColumnHeader cW3;
        private System.Windows.Forms.ColumnHeader cW4;
        private System.Windows.Forms.ColumnHeader cAver;
        private System.Windows.Forms.TextBox tbCredit;
        private System.Windows.Forms.TextBox tbSubName;
        private System.Windows.Forms.TextBox tbSubID;
        private System.Windows.Forms.Label lCre;
        private System.Windows.Forms.Label lSubName;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Label lFin;
        private System.Windows.Forms.Label lPract;
        private System.Windows.Forms.Label lMid;
        private System.Windows.Forms.Label lPro;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Label lWei;
        private System.Windows.Forms.TextBox tbFinWei;
        private System.Windows.Forms.TextBox tbFinVa;
        private System.Windows.Forms.TextBox tbPracWei;
        private System.Windows.Forms.TextBox tbPracVa;
        private System.Windows.Forms.TextBox tbMidWei;
        private System.Windows.Forms.TextBox tbMidVa;
        private System.Windows.Forms.TextBox tbProWei;
        private System.Windows.Forms.TextBox tbProVa;
    }
}

