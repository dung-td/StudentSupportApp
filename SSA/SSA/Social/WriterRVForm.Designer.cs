
namespace StudentSupportApp
{
    partial class WriterRVForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriterRVForm));
            this.header = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.label7 = new System.Windows.Forms.Label();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.cardRVSetting = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cardRVDetail = new Bunifu.Framework.UI.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDetails = new System.Windows.Forms.RichTextBox();
            this.btnUpload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardRVInfo = new Bunifu.Framework.UI.BunifuCards();
            this.tbxSubID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxSubName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.cardRVSetting.SuspendLayout();
            this.cardRVDetail.SuspendLayout();
            this.cardRVInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.btnExit);
            this.header.Controls.Add(this.bunifuCards2);
            this.header.Controls.Add(this.label7);
            this.header.Controls.Add(this.pLogo);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1017, 38);
            this.header.TabIndex = 21;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(933, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 39);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 25;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(970, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 39);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 24;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 20;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(300, 44);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(290, 160);
            this.bunifuCards2.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(30, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Student Support App";
            // 
            // pLogo
            // 
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(4, 3);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(21, 26);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogo.TabIndex = 2;
            this.pLogo.TabStop = false;
            // 
            // cardRVSetting
            // 
            this.cardRVSetting.BackColor = System.Drawing.Color.White;
            this.cardRVSetting.BorderRadius = 5;
            this.cardRVSetting.BottomSahddow = true;
            this.cardRVSetting.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cardRVSetting.Controls.Add(this.label3);
            this.cardRVSetting.Controls.Add(this.label6);
            this.cardRVSetting.LeftSahddow = false;
            this.cardRVSetting.Location = new System.Drawing.Point(383, 44);
            this.cardRVSetting.Name = "cardRVSetting";
            this.cardRVSetting.RightSahddow = true;
            this.cardRVSetting.ShadowDepth = 20;
            this.cardRVSetting.Size = new System.Drawing.Size(502, 199);
            this.cardRVSetting.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 133);
            this.label3.TabIndex = 14;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "NGUYÊN TẮC";
            // 
            // cardRVDetail
            // 
            this.cardRVDetail.BackColor = System.Drawing.Color.White;
            this.cardRVDetail.BorderRadius = 5;
            this.cardRVDetail.BottomSahddow = true;
            this.cardRVDetail.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cardRVDetail.Controls.Add(this.label2);
            this.cardRVDetail.Controls.Add(this.tbxDetails);
            this.cardRVDetail.LeftSahddow = false;
            this.cardRVDetail.Location = new System.Drawing.Point(0, 249);
            this.cardRVDetail.Name = "cardRVDetail";
            this.cardRVDetail.RightSahddow = true;
            this.cardRVDetail.ShadowDepth = 20;
            this.cardRVDetail.Size = new System.Drawing.Size(1017, 304);
            this.cardRVDetail.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "NỘI DUNG BÀI VIẾT";
            // 
            // tbxDetails
            // 
            this.tbxDetails.AcceptsTab = true;
            this.tbxDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDetails.Location = new System.Drawing.Point(0, 35);
            this.tbxDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDetails.Name = "tbxDetails";
            this.tbxDetails.Size = new System.Drawing.Size(1017, 267);
            this.tbxDetails.TabIndex = 4;
            this.tbxDetails.Text = "";
            // 
            // btnUpload
            // 
            this.btnUpload.Activecolor = System.Drawing.Color.Transparent;
            this.btnUpload.BackColor = System.Drawing.Color.Silver;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpload.BorderRadius = 0;
            this.btnUpload.ButtonText = "Đăng tải";
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpload.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpload.Iconimage")));
            this.btnUpload.Iconimage_right = null;
            this.btnUpload.Iconimage_right_Selected = null;
            this.btnUpload.Iconimage_Selected = null;
            this.btnUpload.IconMarginLeft = 0;
            this.btnUpload.IconMarginRight = 0;
            this.btnUpload.IconRightVisible = true;
            this.btnUpload.IconRightZoom = 0D;
            this.btnUpload.IconVisible = true;
            this.btnUpload.IconZoom = 80D;
            this.btnUpload.IsTab = false;
            this.btnUpload.Location = new System.Drawing.Point(892, 96);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Normalcolor = System.Drawing.Color.Silver;
            this.btnUpload.OnHovercolor = System.Drawing.Color.Silver;
            this.btnUpload.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnUpload.selected = false;
            this.btnUpload.Size = new System.Drawing.Size(112, 39);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Đăng tải";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Textcolor = System.Drawing.Color.Black;
            this.btnUpload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Hủy";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 80D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(892, 162);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.Silver;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Silver;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(112, 38);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.Black;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cardRVInfo
            // 
            this.cardRVInfo.BackColor = System.Drawing.Color.White;
            this.cardRVInfo.BorderRadius = 5;
            this.cardRVInfo.BottomSahddow = true;
            this.cardRVInfo.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cardRVInfo.Controls.Add(this.tbxSubID);
            this.cardRVInfo.Controls.Add(this.tbxSubName);
            this.cardRVInfo.Controls.Add(this.label1);
            this.cardRVInfo.LeftSahddow = false;
            this.cardRVInfo.Location = new System.Drawing.Point(2, 44);
            this.cardRVInfo.Name = "cardRVInfo";
            this.cardRVInfo.RightSahddow = true;
            this.cardRVInfo.ShadowDepth = 20;
            this.cardRVInfo.Size = new System.Drawing.Size(375, 199);
            this.cardRVInfo.TabIndex = 24;
            // 
            // tbxSubID
            // 
            this.tbxSubID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSubID.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxSubID.HintForeColor = System.Drawing.Color.Empty;
            this.tbxSubID.HintText = "ID Môn học/ Chủ đề";
            this.tbxSubID.isPassword = false;
            this.tbxSubID.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbxSubID.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxSubID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbxSubID.LineThickness = 3;
            this.tbxSubID.Location = new System.Drawing.Point(20, 52);
            this.tbxSubID.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSubID.Name = "tbxSubID";
            this.tbxSubID.Size = new System.Drawing.Size(342, 42);
            this.tbxSubID.TabIndex = 14;
            this.tbxSubID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxSubName
            // 
            this.tbxSubName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSubName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxSubName.HintForeColor = System.Drawing.Color.Empty;
            this.tbxSubName.HintText = "Môn học/ Tiêu đề";
            this.tbxSubName.isPassword = false;
            this.tbxSubName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbxSubName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxSubName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbxSubName.LineThickness = 3;
            this.tbxSubName.Location = new System.Drawing.Point(20, 120);
            this.tbxSubName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSubName.Name = "tbxSubName";
            this.tbxSubName.Size = new System.Drawing.Size(342, 36);
            this.tbxSubName.TabIndex = 13;
            this.tbxSubName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN BÀI VIẾT";
            // 
            // WriterRVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 551);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.cardRVSetting);
            this.Controls.Add(this.header);
            this.Controls.Add(this.cardRVInfo);
            this.Controls.Add(this.cardRVDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WriterRVForm";
            this.Text = "WriterRVForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WriterRVForm_FormClosing);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.cardRVSetting.ResumeLayout(false);
            this.cardRVSetting.PerformLayout();
            this.cardRVDetail.ResumeLayout(false);
            this.cardRVDetail.PerformLayout();
            this.cardRVInfo.ResumeLayout(false);
            this.cardRVInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pLogo;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards cardRVSetting;
        private Bunifu.Framework.UI.BunifuCards cardRVDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tbxDetails;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpload;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuCards cardRVInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxSubID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxSubName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label label3;
    }
}