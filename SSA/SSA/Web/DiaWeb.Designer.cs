
namespace StudentSupportApp
{
    partial class DiaWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaWeb));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWeb = new System.Windows.Forms.Label();
            this.tbURL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbTitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bDelWeb = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bAccess = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bAccess);
            this.panel1.Controls.Add(this.lbWeb);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 284);
            this.panel1.TabIndex = 71;
            // 
            // lbWeb
            // 
            this.lbWeb.AutoSize = true;
            this.lbWeb.BackColor = System.Drawing.Color.Transparent;
            this.lbWeb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeb.ForeColor = System.Drawing.Color.White;
            this.lbWeb.Location = new System.Drawing.Point(32, 127);
            this.lbWeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWeb.Name = "lbWeb";
            this.lbWeb.Size = new System.Drawing.Size(68, 30);
            this.lbWeb.TabIndex = 21;
            this.lbWeb.Text = "Web";
            this.lbWeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbURL
            // 
            this.tbURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbURL.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbURL.HintForeColor = System.Drawing.Color.Empty;
            this.tbURL.HintText = "Dán URL";
            this.tbURL.isPassword = false;
            this.tbURL.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbURL.LineIdleColor = System.Drawing.Color.Gray;
            this.tbURL.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbURL.LineThickness = 3;
            this.tbURL.Location = new System.Drawing.Point(197, 137);
            this.tbURL.Margin = new System.Windows.Forms.Padding(4);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(370, 44);
            this.tbURL.TabIndex = 73;
            this.tbURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbTitle
            // 
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTitle.HintForeColor = System.Drawing.Color.Empty;
            this.tbTitle.HintText = "Nhập tên";
            this.tbTitle.isPassword = false;
            this.tbTitle.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbTitle.LineIdleColor = System.Drawing.Color.Gray;
            this.tbTitle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbTitle.LineThickness = 3;
            this.tbTitle.Location = new System.Drawing.Point(197, 45);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(370, 44);
            this.tbTitle.TabIndex = 72;
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bOK
            // 
            this.bOK.ActiveBorderThickness = 1;
            this.bOK.ActiveCornerRadius = 20;
            this.bOK.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bOK.ActiveForecolor = System.Drawing.Color.White;
            this.bOK.ActiveLineColor = System.Drawing.Color.Empty;
            this.bOK.BackColor = System.Drawing.SystemColors.Control;
            this.bOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bOK.BackgroundImage")));
            this.bOK.ButtonText = "OK";
            this.bOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bOK.IdleBorderThickness = 1;
            this.bOK.IdleCornerRadius = 20;
            this.bOK.IdleFillColor = System.Drawing.Color.Transparent;
            this.bOK.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bOK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bOK.Location = new System.Drawing.Point(232, 207);
            this.bOK.Margin = new System.Windows.Forms.Padding(5);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(99, 50);
            this.bOK.TabIndex = 75;
            this.bOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
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
            this.bExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleBorderThickness = 1;
            this.bExit.IdleCornerRadius = 20;
            this.bExit.IdleFillColor = System.Drawing.Color.Transparent;
            this.bExit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.Location = new System.Drawing.Point(448, 207);
            this.bExit.Margin = new System.Windows.Forms.Padding(5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(99, 50);
            this.bExit.TabIndex = 74;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bDelWeb
            // 
            this.bDelWeb.ActiveBorderThickness = 1;
            this.bDelWeb.ActiveCornerRadius = 20;
            this.bDelWeb.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bDelWeb.ActiveForecolor = System.Drawing.Color.White;
            this.bDelWeb.ActiveLineColor = System.Drawing.Color.Empty;
            this.bDelWeb.BackColor = System.Drawing.SystemColors.Control;
            this.bDelWeb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDelWeb.BackgroundImage")));
            this.bDelWeb.ButtonText = "Xoá";
            this.bDelWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelWeb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bDelWeb.IdleBorderThickness = 1;
            this.bDelWeb.IdleCornerRadius = 20;
            this.bDelWeb.IdleFillColor = System.Drawing.Color.Transparent;
            this.bDelWeb.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bDelWeb.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bDelWeb.Location = new System.Drawing.Point(339, 207);
            this.bDelWeb.Margin = new System.Windows.Forms.Padding(5);
            this.bDelWeb.Name = "bDelWeb";
            this.bDelWeb.Size = new System.Drawing.Size(99, 50);
            this.bDelWeb.TabIndex = 76;
            this.bDelWeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bDelWeb.Click += new System.EventHandler(this.bDelWeb_Click);
            // 
            // bAccess
            // 
            this.bAccess.ActiveBorderThickness = 1;
            this.bAccess.ActiveCornerRadius = 20;
            this.bAccess.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bAccess.ActiveForecolor = System.Drawing.Color.White;
            this.bAccess.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bAccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAccess.BackgroundImage")));
            this.bAccess.ButtonText = "Truy cập";
            this.bAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAccess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccess.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bAccess.IdleBorderThickness = 1;
            this.bAccess.IdleCornerRadius = 20;
            this.bAccess.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bAccess.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.bAccess.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.bAccess.Location = new System.Drawing.Point(31, 179);
            this.bAccess.Margin = new System.Windows.Forms.Padding(5);
            this.bAccess.Name = "bAccess";
            this.bAccess.Size = new System.Drawing.Size(105, 40);
            this.bAccess.TabIndex = 46;
            this.bAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bAccess.Click += new System.EventHandler(this.bAccess_Click);
            // 
            // DiaWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 282);
            this.Controls.Add(this.bDelWeb);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiaWeb";
            this.Text = "DiaWeb";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiaWeb_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWeb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbURL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 bOK;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
        private Bunifu.Framework.UI.BunifuThinButton2 bDelWeb;
        private Bunifu.Framework.UI.BunifuThinButton2 bAccess;
    }
}