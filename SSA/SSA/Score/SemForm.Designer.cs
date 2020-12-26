
namespace StudentSupportApp
{
    partial class SemForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SemFormPanel = new System.Windows.Forms.Panel();
            this.bDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lAver = new System.Windows.Forms.Label();
            this.bMod = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lSum = new System.Windows.Forms.Label();
            this.bAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtgvSem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bStatistic = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SemFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSem)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SemFormPanel
            // 
            this.SemFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SemFormPanel.Controls.Add(this.bDel);
            this.SemFormPanel.Controls.Add(this.lAver);
            this.SemFormPanel.Controls.Add(this.bMod);
            this.SemFormPanel.Controls.Add(this.lSum);
            this.SemFormPanel.Controls.Add(this.bAdd);
            this.SemFormPanel.Location = new System.Drawing.Point(0, -7);
            this.SemFormPanel.Name = "SemFormPanel";
            this.SemFormPanel.Size = new System.Drawing.Size(148, 395);
            this.SemFormPanel.TabIndex = 41;
            // 
            // bDel
            // 
            this.bDel.ActiveBorderThickness = 1;
            this.bDel.ActiveCornerRadius = 20;
            this.bDel.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bDel.ActiveForecolor = System.Drawing.Color.White;
            this.bDel.ActiveLineColor = System.Drawing.Color.Empty;
            this.bDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDel.BackgroundImage")));
            this.bDel.ButtonText = "Xoá";
            this.bDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bDel.IdleBorderThickness = 1;
            this.bDel.IdleCornerRadius = 20;
            this.bDel.IdleFillColor = System.Drawing.Color.White;
            this.bDel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bDel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bDel.Location = new System.Drawing.Point(14, 287);
            this.bDel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(126, 62);
            this.bDel.TabIndex = 40;
            this.bDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // lAver
            // 
            this.lAver.AutoSize = true;
            this.lAver.BackColor = System.Drawing.Color.Transparent;
            this.lAver.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAver.ForeColor = System.Drawing.Color.White;
            this.lAver.Location = new System.Drawing.Point(11, 96);
            this.lAver.Name = "lAver";
            this.lAver.Size = new System.Drawing.Size(111, 50);
            this.lAver.TabIndex = 29;
            this.lAver.Text = "Điểm \r\ntrung bình: ";
            // 
            // bMod
            // 
            this.bMod.ActiveBorderThickness = 1;
            this.bMod.ActiveCornerRadius = 20;
            this.bMod.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bMod.ActiveForecolor = System.Drawing.Color.White;
            this.bMod.ActiveLineColor = System.Drawing.Color.Empty;
            this.bMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bMod.BackgroundImage")));
            this.bMod.ButtonText = "Sửa";
            this.bMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMod.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bMod.IdleBorderThickness = 1;
            this.bMod.IdleCornerRadius = 20;
            this.bMod.IdleFillColor = System.Drawing.Color.White;
            this.bMod.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bMod.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bMod.Location = new System.Drawing.Point(14, 215);
            this.bMod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bMod.Name = "bMod";
            this.bMod.Size = new System.Drawing.Size(126, 62);
            this.bMod.TabIndex = 39;
            this.bMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bMod.Click += new System.EventHandler(this.bMod_Click);
            // 
            // lSum
            // 
            this.lSum.AutoSize = true;
            this.lSum.BackColor = System.Drawing.Color.Transparent;
            this.lSum.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSum.ForeColor = System.Drawing.Color.White;
            this.lSum.Location = new System.Drawing.Point(11, 59);
            this.lSum.Name = "lSum";
            this.lSum.Size = new System.Drawing.Size(101, 25);
            this.lSum.TabIndex = 30;
            this.lSum.Text = "Số tín chỉ:";
            // 
            // bAdd
            // 
            this.bAdd.ActiveBorderThickness = 1;
            this.bAdd.ActiveCornerRadius = 20;
            this.bAdd.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bAdd.ActiveForecolor = System.Drawing.Color.White;
            this.bAdd.ActiveLineColor = System.Drawing.Color.Empty;
            this.bAdd.AutoSize = true;
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAdd.BackgroundImage")));
            this.bAdd.ButtonText = "Thêm";
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bAdd.IdleBorderThickness = 1;
            this.bAdd.IdleCornerRadius = 20;
            this.bAdd.IdleFillColor = System.Drawing.Color.White;
            this.bAdd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bAdd.Location = new System.Drawing.Point(14, 143);
            this.bAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(126, 62);
            this.bAdd.TabIndex = 38;
            this.bAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dtgvSem
            // 
            this.dtgvSem.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvSem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvSem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvSem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvSem.DoubleBuffered = true;
            this.dtgvSem.EnableHeadersVisualStyles = false;
            this.dtgvSem.HeaderBgColor = System.Drawing.Color.SeaShell;
            this.dtgvSem.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dtgvSem.Location = new System.Drawing.Point(207, 41);
            this.dtgvSem.Name = "dtgvSem";
            this.dtgvSem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvSem.RowHeadersWidth = 62;
            this.dtgvSem.Size = new System.Drawing.Size(442, 274);
            this.dtgvSem.TabIndex = 40;
            this.dtgvSem.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvSem_RowHeaderMouseClick);
            // 
            // NAME
            // 
            this.NAME.HeaderText = "TÊN HỌC KÌ";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SỐ TÍN CHỈ";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ĐIỂM TRUNG BÌNH";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(297, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "THÔNG TIN CÁC HỌC KÌ";
            // 
            // bExit
            // 
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bExit.ActiveForecolor = System.Drawing.Color.White;
            this.bExit.ActiveLineColor = System.Drawing.Color.Empty;
            this.bExit.BackColor = System.Drawing.SystemColors.Control;
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.ButtonText = "Thoát";
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleBorderThickness = 1;
            this.bExit.IdleCornerRadius = 20;
            this.bExit.IdleFillColor = System.Drawing.Color.Transparent;
            this.bExit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.Location = new System.Drawing.Point(586, 323);
            this.bExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(99, 50);
            this.bExit.TabIndex = 42;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bStatistic
            // 
            this.bStatistic.ActiveBorderThickness = 1;
            this.bStatistic.ActiveCornerRadius = 20;
            this.bStatistic.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bStatistic.ActiveForecolor = System.Drawing.Color.White;
            this.bStatistic.ActiveLineColor = System.Drawing.Color.Empty;
            this.bStatistic.BackColor = System.Drawing.SystemColors.Control;
            this.bStatistic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bStatistic.BackgroundImage")));
            this.bStatistic.ButtonText = "Thống kê";
            this.bStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStatistic.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bStatistic.IdleBorderThickness = 1;
            this.bStatistic.IdleCornerRadius = 20;
            this.bStatistic.IdleFillColor = System.Drawing.Color.Transparent;
            this.bStatistic.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bStatistic.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bStatistic.Location = new System.Drawing.Point(460, 323);
            this.bStatistic.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bStatistic.Name = "bStatistic";
            this.bStatistic.Size = new System.Drawing.Size(99, 50);
            this.bStatistic.TabIndex = 43;
            this.bStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bStatistic.Click += new System.EventHandler(this.bStatistic_Click);
            // 
            // SemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 381);
            this.Controls.Add(this.bStatistic);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.SemFormPanel);
            this.Controls.Add(this.dtgvSem);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SemForm";
            this.Text = "SemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SemForm_FormClosed);
            this.SemFormPanel.ResumeLayout(false);
            this.SemFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
        private System.Windows.Forms.Panel SemFormPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 bDel;
        private System.Windows.Forms.Label lAver;
        private Bunifu.Framework.UI.BunifuThinButton2 bMod;
        private Bunifu.Framework.UI.BunifuThinButton2 bAdd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvSem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuThinButton2 bStatistic;
        private System.Windows.Forms.Label lSum;
    }
}