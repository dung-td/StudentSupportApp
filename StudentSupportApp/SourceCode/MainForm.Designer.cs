namespace SSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.groupBoxTool = new System.Windows.Forms.GroupBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave2 = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxTimeRemain = new System.Windows.Forms.TextBox();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDeadline = new System.Windows.Forms.GroupBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dataDeadline = new System.Windows.Forms.DataGridView();
            this.SubjectCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSubmitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBoxTool.SuspendLayout();
            this.groupBoxDetail.SuspendLayout();
            this.groupBoxDeadline.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDeadline)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1578, 844);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1570, 811);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOME";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SCORES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1250, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SCHEDULES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bunifuGradientPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1250, 631);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "NOTIFICATIONS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.groupBoxTool);
            this.bunifuGradientPanel1.Controls.Add(this.groupBoxDetail);
            this.bunifuGradientPanel1.Controls.Add(this.groupBoxDeadline);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(213)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.WindowText;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1250, 631);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.Controls.Add(this.bRefresh);
            this.groupBoxTool.Controls.Add(this.bSave);
            this.groupBoxTool.Controls.Add(this.bExport);
            this.groupBoxTool.Controls.Add(this.bDelete);
            this.groupBoxTool.Controls.Add(this.bEdit);
            this.groupBoxTool.Controls.Add(this.bAdd);
            this.groupBoxTool.Controls.Add(this.checkedListBox1);
            this.groupBoxTool.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxTool.Location = new System.Drawing.Point(775, 400);
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.Size = new System.Drawing.Size(464, 191);
            this.groupBoxTool.TabIndex = 1;
            this.groupBoxTool.TabStop = false;
            this.groupBoxTool.Text = "TOOLS";
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.White;
            this.bRefresh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bRefresh.Location = new System.Drawing.Point(280, 25);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(84, 63);
            this.bRefresh.TabIndex = 14;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.White;
            this.bSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bSave.Location = new System.Drawing.Point(280, 112);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(84, 63);
            this.bSave.TabIndex = 13;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bExport
            // 
            this.bExport.BackColor = System.Drawing.Color.White;
            this.bExport.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bExport.Location = new System.Drawing.Point(370, 112);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(84, 63);
            this.bExport.TabIndex = 12;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = false;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.White;
            this.bDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bDelete.Location = new System.Drawing.Point(190, 25);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(84, 63);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.White;
            this.bEdit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bEdit.Location = new System.Drawing.Point(100, 25);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(84, 63);
            this.bEdit.TabIndex = 9;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.White;
            this.bAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bAdd.Location = new System.Drawing.Point(10, 25);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(84, 63);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "View older deadlines",
            "View finished deadlines",
            "View non-finished deadlines"});
            this.checkedListBox1.Location = new System.Drawing.Point(10, 112);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(239, 73);
            this.checkedListBox1.TabIndex = 7;
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Controls.Add(this.dateTimePicker1);
            this.groupBoxDetail.Controls.Add(this.label5);
            this.groupBoxDetail.Controls.Add(this.bCancel);
            this.groupBoxDetail.Controls.Add(this.bSave2);
            this.groupBoxDetail.Controls.Add(this.textBoxStatus);
            this.groupBoxDetail.Controls.Add(this.textBoxTimeRemain);
            this.groupBoxDetail.Controls.Add(this.textBoxDetail);
            this.groupBoxDetail.Controls.Add(this.textBoxSubject);
            this.groupBoxDetail.Controls.Add(this.label4);
            this.groupBoxDetail.Controls.Add(this.label3);
            this.groupBoxDetail.Controls.Add(this.label2);
            this.groupBoxDetail.Controls.Add(this.label1);
            this.groupBoxDetail.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxDetail.Location = new System.Drawing.Point(775, 23);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(467, 371);
            this.groupBoxDetail.TabIndex = 0;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "DETAILS";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 26);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Time Submit";
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.White;
            this.bCancel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bCancel.Location = new System.Drawing.Point(225, 329);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(84, 36);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // bSave2
            // 
            this.bSave2.BackColor = System.Drawing.Color.White;
            this.bSave2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bSave2.Location = new System.Drawing.Point(135, 329);
            this.bSave2.Name = "bSave2";
            this.bSave2.Size = new System.Drawing.Size(84, 36);
            this.bSave2.TabIndex = 14;
            this.bSave2.Text = "Save";
            this.bSave2.UseVisualStyleBackColor = false;
            this.bSave2.Click += new System.EventHandler(this.bSave2_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(135, 291);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(235, 26);
            this.textBoxStatus.TabIndex = 7;
            // 
            // textBoxTimeRemain
            // 
            this.textBoxTimeRemain.Location = new System.Drawing.Point(135, 258);
            this.textBoxTimeRemain.Name = "textBoxTimeRemain";
            this.textBoxTimeRemain.ReadOnly = true;
            this.textBoxTimeRemain.Size = new System.Drawing.Size(235, 26);
            this.textBoxTimeRemain.TabIndex = 6;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Location = new System.Drawing.Point(135, 63);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.ReadOnly = true;
            this.textBoxDetail.Size = new System.Drawing.Size(326, 149);
            this.textBoxDetail.TabIndex = 5;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(135, 29);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.ReadOnly = true;
            this.textBoxSubject.Size = new System.Drawing.Size(326, 26);
            this.textBoxSubject.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Remain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // groupBoxDeadline
            // 
            this.groupBoxDeadline.Controls.Add(this.bunifuGradientPanel2);
            this.groupBoxDeadline.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxDeadline.Location = new System.Drawing.Point(26, 23);
            this.groupBoxDeadline.Name = "groupBoxDeadline";
            this.groupBoxDeadline.Size = new System.Drawing.Size(743, 568);
            this.groupBoxDeadline.TabIndex = 0;
            this.groupBoxDeadline.TabStop = false;
            this.groupBoxDeadline.Text = "DEADLINES";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.dataDeadline);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(213)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.SystemColors.WindowText;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(3, 22);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(737, 543);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // dataDeadline
            // 
            this.dataDeadline.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataDeadline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDeadline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCodeCol,
            this.SubjectCol,
            this.DetailCol,
            this.TimeSubmitCol,
            this.StatusCol});
            this.dataDeadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDeadline.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataDeadline.Location = new System.Drawing.Point(0, 0);
            this.dataDeadline.Name = "dataDeadline";
            this.dataDeadline.ReadOnly = true;
            this.dataDeadline.RowHeadersWidth = 62;
            this.dataDeadline.RowTemplate.Height = 28;
            this.dataDeadline.Size = new System.Drawing.Size(737, 543);
            this.dataDeadline.TabIndex = 0;
            // 
            // SubjectCodeCol
            // 
            this.SubjectCodeCol.HeaderText = "Subject Code";
            this.SubjectCodeCol.MinimumWidth = 8;
            this.SubjectCodeCol.Name = "SubjectCodeCol";
            this.SubjectCodeCol.ReadOnly = true;
            this.SubjectCodeCol.Width = 50;
            // 
            // SubjectCol
            // 
            this.SubjectCol.HeaderText = "Subject";
            this.SubjectCol.MinimumWidth = 8;
            this.SubjectCol.Name = "SubjectCol";
            this.SubjectCol.ReadOnly = true;
            this.SubjectCol.Width = 150;
            // 
            // DetailCol
            // 
            this.DetailCol.HeaderText = "Details";
            this.DetailCol.MinimumWidth = 8;
            this.DetailCol.Name = "DetailCol";
            this.DetailCol.ReadOnly = true;
            this.DetailCol.Width = 150;
            // 
            // TimeSubmitCol
            // 
            this.TimeSubmitCol.HeaderText = "Time Submit";
            this.TimeSubmitCol.MinimumWidth = 8;
            this.TimeSubmitCol.Name = "TimeSubmitCol";
            this.TimeSubmitCol.ReadOnly = true;
            this.TimeSubmitCol.Width = 150;
            // 
            // StatusCol
            // 
            this.StatusCol.HeaderText = "Status";
            this.StatusCol.MinimumWidth = 8;
            this.StatusCol.Name = "StatusCol";
            this.StatusCol.ReadOnly = true;
            this.StatusCol.Width = 80;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1250, 631);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "INFORMATION";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1250, 631);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "GENERAL SETTINGS";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "MainForm";
            this.Text = "STUDENT SUPPORT APP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.groupBoxTool.ResumeLayout(false);
            this.groupBoxDetail.ResumeLayout(false);
            this.groupBoxDetail.PerformLayout();
            this.groupBoxDeadline.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDeadline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox groupBoxDeadline;
        private System.Windows.Forms.GroupBox groupBoxTool;
        private System.Windows.Forms.GroupBox groupBoxDetail;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.DataGridView dataDeadline;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxTimeRemain;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSubmitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCol;
        private System.Windows.Forms.Button bRefresh;
    }
}

