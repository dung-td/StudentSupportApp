
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
            this.tbNewPass1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbOldPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.panel1.Controls.Add(this.lbWeb);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 284);
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
            // tbNewPass1
            // 
            this.tbNewPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass1.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass1.HintText = "New password";
            this.tbNewPass1.isPassword = false;
            this.tbNewPass1.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineThickness = 3;
            this.tbNewPass1.Location = new System.Drawing.Point(197, 137);
            this.tbNewPass1.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPass1.Name = "tbNewPass1";
            this.tbNewPass1.Size = new System.Drawing.Size(370, 44);
            this.tbNewPass1.TabIndex = 73;
            this.tbNewPass1.Text = "Dán URL";
            this.tbNewPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldPass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOldPass.HintForeColor = System.Drawing.Color.Empty;
            this.tbOldPass.HintText = "Your old password";
            this.tbOldPass.isPassword = false;
            this.tbOldPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbOldPass.LineIdleColor = System.Drawing.Color.Gray;
            this.tbOldPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbOldPass.LineThickness = 3;
            this.tbOldPass.Location = new System.Drawing.Point(197, 45);
            this.tbOldPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(370, 44);
            this.tbOldPass.TabIndex = 72;
            this.tbOldPass.Text = "Nhập tên ";
            this.tbOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bOK.Location = new System.Drawing.Point(254, 207);
            this.bOK.Margin = new System.Windows.Forms.Padding(5);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(99, 50);
            this.bOK.TabIndex = 75;
            this.bOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bExit.Location = new System.Drawing.Point(380, 207);
            this.bExit.Margin = new System.Windows.Forms.Padding(5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(99, 50);
            this.bExit.TabIndex = 74;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiaWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 282);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tbNewPass1);
            this.Controls.Add(this.tbOldPass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiaWeb";
            this.Text = "DiaWeb";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWeb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPass1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbOldPass;
        private Bunifu.Framework.UI.BunifuThinButton2 bOK;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
    }
}