
namespace StudentSupportApp
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bSend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbTitle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbFeed = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.bExit.Location = new System.Drawing.Point(700, 446);
            this.bExit.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(148, 77);
            this.bExit.TabIndex = 43;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 545);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 64);
            this.label1.TabIndex = 22;
            this.label1.Text = "Phản hồi\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(243, 45);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(356, 27);
            this.bunifuCustomLabel1.TabIndex = 75;
            this.bunifuCustomLabel1.Text = "Nhập phản hồi vào khung dưới đây:";
            // 
            // bSend
            // 
            this.bSend.ActiveBorderThickness = 1;
            this.bSend.ActiveCornerRadius = 20;
            this.bSend.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bSend.ActiveForecolor = System.Drawing.Color.White;
            this.bSend.ActiveLineColor = System.Drawing.Color.Empty;
            this.bSend.BackColor = System.Drawing.SystemColors.Control;
            this.bSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSend.BackgroundImage")));
            this.bSend.ButtonText = "Gửi";
            this.bSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSend.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.IdleBorderThickness = 1;
            this.bSend.IdleCornerRadius = 20;
            this.bSend.IdleFillColor = System.Drawing.Color.Transparent;
            this.bSend.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.Location = new System.Drawing.Point(454, 446);
            this.bSend.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(148, 77);
            this.bSend.TabIndex = 76;
            this.bSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTitle.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbTitle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTitle.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbTitle.BorderThickness = 1;
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.Black;
            this.tbTitle.isPassword = false;
            this.tbTitle.Location = new System.Drawing.Point(248, 78);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(618, 57);
            this.tbTitle.TabIndex = 77;
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbFeed
            // 
            this.tbFeed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFeed.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFeed.Location = new System.Drawing.Point(248, 151);
            this.tbFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFeed.Name = "tbFeed";
            this.tbFeed.Size = new System.Drawing.Size(616, 281);
            this.tbFeed.TabIndex = 78;
            this.tbFeed.Text = "";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 545);
            this.Controls.Add(this.tbFeed);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Feedback_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bSend;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbTitle;
        private System.Windows.Forms.RichTextBox tbFeed;
    }
}