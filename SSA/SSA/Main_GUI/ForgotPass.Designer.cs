
namespace StudentSupportApp
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.tbNewPass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bChange = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lInvalid = new System.Windows.Forms.Label();
            this.lConfirmWrong = new System.Windows.Forms.Label();
            this.lShortPass = new System.Windows.Forms.Label();
            this.tbNewPass1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lCodeWrong = new System.Windows.Forms.Label();
            this.tbVerifyCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bSend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lSent = new System.Windows.Forms.Label();
            this.GradientPanelForgotPasswd = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbForgotPass = new System.Windows.Forms.Label();
            this.GradientPanelForgotPasswd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewPass2
            // 
            this.tbNewPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tbNewPass2, "tbNewPass2");
            this.tbNewPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass2.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass2.HintText = "Lặp lại mật khẩu";
            this.tbNewPass2.isPassword = true;
            this.tbNewPass2.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineThickness = 4;
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewPass2.OnValueChanged += new System.EventHandler(this.tbNewPass2_OnValueChanged);
            // 
            // bExit
            // 
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bExit.ActiveForecolor = System.Drawing.Color.White;
            this.bExit.ActiveLineColor = System.Drawing.Color.Empty;
            this.bExit.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.bExit, "bExit");
            this.bExit.ButtonText = "Thoát";
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleBorderThickness = 1;
            this.bExit.IdleCornerRadius = 20;
            this.bExit.IdleFillColor = System.Drawing.Color.White;
            this.bExit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.Name = "bExit";
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bChange
            // 
            this.bChange.ActiveBorderThickness = 1;
            this.bChange.ActiveCornerRadius = 20;
            this.bChange.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bChange.ActiveForecolor = System.Drawing.Color.White;
            this.bChange.ActiveLineColor = System.Drawing.Color.Empty;
            this.bChange.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.bChange, "bChange");
            this.bChange.ButtonText = "Đổi";
            this.bChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.IdleBorderThickness = 1;
            this.bChange.IdleCornerRadius = 20;
            this.bChange.IdleFillColor = System.Drawing.Color.White;
            this.bChange.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.Name = "bChange";
            this.bChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // lInvalid
            // 
            resources.ApplyResources(this.lInvalid, "lInvalid");
            this.lInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lInvalid.ForeColor = System.Drawing.Color.Red;
            this.lInvalid.Name = "lInvalid";
            // 
            // lConfirmWrong
            // 
            resources.ApplyResources(this.lConfirmWrong, "lConfirmWrong");
            this.lConfirmWrong.BackColor = System.Drawing.Color.Transparent;
            this.lConfirmWrong.ForeColor = System.Drawing.Color.Red;
            this.lConfirmWrong.Name = "lConfirmWrong";
            // 
            // lShortPass
            // 
            resources.ApplyResources(this.lShortPass, "lShortPass");
            this.lShortPass.BackColor = System.Drawing.Color.Transparent;
            this.lShortPass.ForeColor = System.Drawing.Color.Red;
            this.lShortPass.Name = "lShortPass";
            // 
            // tbNewPass1
            // 
            this.tbNewPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tbNewPass1, "tbNewPass1");
            this.tbNewPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass1.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass1.HintText = "Mật khẩu mới";
            this.tbNewPass1.isPassword = true;
            this.tbNewPass1.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineThickness = 4;
            this.tbNewPass1.Name = "tbNewPass1";
            this.tbNewPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewPass1.OnValueChanged += new System.EventHandler(this.tbNewPass1_OnValueChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbEmail.HintText = "Email";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEmail.LineThickness = 4;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lCodeWrong
            // 
            resources.ApplyResources(this.lCodeWrong, "lCodeWrong");
            this.lCodeWrong.BackColor = System.Drawing.Color.Transparent;
            this.lCodeWrong.ForeColor = System.Drawing.Color.Red;
            this.lCodeWrong.Name = "lCodeWrong";
            // 
            // tbVerifyCode
            // 
            this.tbVerifyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tbVerifyCode, "tbVerifyCode");
            this.tbVerifyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbVerifyCode.HintForeColor = System.Drawing.Color.Empty;
            this.tbVerifyCode.HintText = "Mã xác nhận";
            this.tbVerifyCode.isPassword = false;
            this.tbVerifyCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbVerifyCode.LineIdleColor = System.Drawing.Color.Gray;
            this.tbVerifyCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbVerifyCode.LineThickness = 4;
            this.tbVerifyCode.Name = "tbVerifyCode";
            this.tbVerifyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bSend
            // 
            this.bSend.ActiveBorderThickness = 1;
            this.bSend.ActiveCornerRadius = 20;
            this.bSend.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bSend.ActiveForecolor = System.Drawing.Color.White;
            this.bSend.ActiveLineColor = System.Drawing.Color.Empty;
            this.bSend.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.bSend, "bSend");
            this.bSend.ButtonText = "Gửi mã";
            this.bSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.IdleBorderThickness = 1;
            this.bSend.IdleCornerRadius = 20;
            this.bSend.IdleFillColor = System.Drawing.Color.White;
            this.bSend.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.Name = "bSend";
            this.bSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // lSent
            // 
            this.lSent.BackColor = System.Drawing.Color.Transparent;
            this.lSent.ForeColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.lSent, "lSent");
            this.lSent.Name = "lSent";
            // 
            // GradientPanelForgotPasswd
            // 
            this.GradientPanelForgotPasswd.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.GradientPanelForgotPasswd, "GradientPanelForgotPasswd");
            this.GradientPanelForgotPasswd.Controls.Add(this.lbForgotPass);
            this.GradientPanelForgotPasswd.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.Name = "GradientPanelForgotPasswd";
            this.GradientPanelForgotPasswd.Quality = 10;
            // 
            // lbForgotPass
            // 
            resources.ApplyResources(this.lbForgotPass, "lbForgotPass");
            this.lbForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lbForgotPass.ForeColor = System.Drawing.Color.White;
            this.lbForgotPass.Name = "lbForgotPass";
            // 
            // ForgotPass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GradientPanelForgotPasswd);
            this.Controls.Add(this.lSent);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.lCodeWrong);
            this.Controls.Add(this.tbVerifyCode);
            this.Controls.Add(this.tbNewPass2);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.lInvalid);
            this.Controls.Add(this.lConfirmWrong);
            this.Controls.Add(this.lShortPass);
            this.Controls.Add(this.tbNewPass1);
            this.Controls.Add(this.tbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPass";
            this.GradientPanelForgotPasswd.ResumeLayout(false);
            this.GradientPanelForgotPasswd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPass2;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
        private Bunifu.Framework.UI.BunifuThinButton2 bChange;
        private System.Windows.Forms.Label lInvalid;
        private System.Windows.Forms.Label lConfirmWrong;
        private System.Windows.Forms.Label lShortPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPass1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbEmail;
        private System.Windows.Forms.Label lCodeWrong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbVerifyCode;
        private Bunifu.Framework.UI.BunifuThinButton2 bSend;
        private System.Windows.Forms.Label lSent;
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelForgotPasswd;
        private System.Windows.Forms.Label lbForgotPass;
    }
}