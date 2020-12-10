
namespace StudentSupportApp.Main_GUI
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
            this.GradientPanelAddDeadline = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbAddLesson = new System.Windows.Forms.Label();
            this.lCodeWrong = new System.Windows.Forms.Label();
            this.tbVerifyCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bSend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lSent = new System.Windows.Forms.Label();
            this.GradientPanelAddDeadline.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewPass2
            // 
            resources.ApplyResources(this.tbNewPass2, "tbNewPass2");
            this.tbNewPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass2.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass2.HintText = "Lặp lại mật khẩu";
            this.tbNewPass2.isPassword = false;
            this.tbNewPass2.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineThickness = 3;
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bExit
            // 
            resources.ApplyResources(this.bExit, "bExit");
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bExit.ActiveForecolor = System.Drawing.Color.White;
            this.bExit.ActiveLineColor = System.Drawing.Color.Empty;
            this.bExit.BackColor = System.Drawing.SystemColors.Control;
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
            resources.ApplyResources(this.bChange, "bChange");
            this.bChange.ActiveBorderThickness = 1;
            this.bChange.ActiveCornerRadius = 20;
            this.bChange.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bChange.ActiveForecolor = System.Drawing.Color.White;
            this.bChange.ActiveLineColor = System.Drawing.Color.Empty;
            this.bChange.BackColor = System.Drawing.SystemColors.Control;
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
            resources.ApplyResources(this.tbNewPass1, "tbNewPass1");
            this.tbNewPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass1.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass1.HintText = "Mật khẩu mới";
            this.tbNewPass1.isPassword = false;
            this.tbNewPass1.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineThickness = 3;
            this.tbNewPass1.Name = "tbNewPass1";
            this.tbNewPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbEmail
            // 
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbEmail.HintText = "Your old password";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEmail.LineThickness = 3;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // GradientPanelAddDeadline
            // 
            resources.ApplyResources(this.GradientPanelAddDeadline, "GradientPanelAddDeadline");
            this.GradientPanelAddDeadline.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.Controls.Add(this.lbAddLesson);
            this.GradientPanelAddDeadline.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.Name = "GradientPanelAddDeadline";
            this.GradientPanelAddDeadline.Quality = 10;
            // 
            // lbAddLesson
            // 
            resources.ApplyResources(this.lbAddLesson, "lbAddLesson");
            this.lbAddLesson.BackColor = System.Drawing.Color.Transparent;
            this.lbAddLesson.ForeColor = System.Drawing.Color.White;
            this.lbAddLesson.Name = "lbAddLesson";
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
            resources.ApplyResources(this.tbVerifyCode, "tbVerifyCode");
            this.tbVerifyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbVerifyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbVerifyCode.HintForeColor = System.Drawing.Color.Empty;
            this.tbVerifyCode.HintText = "Your old password";
            this.tbVerifyCode.isPassword = false;
            this.tbVerifyCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbVerifyCode.LineIdleColor = System.Drawing.Color.Gray;
            this.tbVerifyCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbVerifyCode.LineThickness = 3;
            this.tbVerifyCode.Name = "tbVerifyCode";
            this.tbVerifyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bSend
            // 
            resources.ApplyResources(this.bSend, "bSend");
            this.bSend.ActiveBorderThickness = 1;
            this.bSend.ActiveCornerRadius = 20;
            this.bSend.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bSend.ActiveForecolor = System.Drawing.Color.White;
            this.bSend.ActiveLineColor = System.Drawing.Color.Empty;
            this.bSend.BackColor = System.Drawing.SystemColors.Control;
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
            resources.ApplyResources(this.lSent, "lSent");
            this.lSent.BackColor = System.Drawing.Color.Transparent;
            this.lSent.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lSent.Name = "lSent";
            // 
            // ForgotPass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lSent);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.lCodeWrong);
            this.Controls.Add(this.tbVerifyCode);
            this.Controls.Add(this.GradientPanelAddDeadline);
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
            this.GradientPanelAddDeadline.ResumeLayout(false);
            this.GradientPanelAddDeadline.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelAddDeadline;
        private System.Windows.Forms.Label lbAddLesson;
        private System.Windows.Forms.Label lCodeWrong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbVerifyCode;
        private Bunifu.Framework.UI.BunifuThinButton2 bSend;
        private System.Windows.Forms.Label lSent;
    }
}