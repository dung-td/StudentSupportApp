
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
            this.GradientPanelAddDeadline.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewPass2
            // 
            this.tbNewPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass2.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass2.HintText = "Lặp lại mật khẩu";
            this.tbNewPass2.isPassword = false;
            this.tbNewPass2.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineThickness = 3;
            this.tbNewPass2.Location = new System.Drawing.Point(298, 427);
            this.tbNewPass2.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.Size = new System.Drawing.Size(555, 68);
            this.tbNewPass2.TabIndex = 76;
            this.tbNewPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bExit
            // 
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.Color.SeaGreen;
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
            this.bExit.IdleFillColor = System.Drawing.Color.White;
            this.bExit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.Location = new System.Drawing.Point(683, 560);
            this.bExit.Margin = new System.Windows.Forms.Padding(8);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(156, 68);
            this.bExit.TabIndex = 78;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bChange
            // 
            this.bChange.ActiveBorderThickness = 1;
            this.bChange.ActiveCornerRadius = 20;
            this.bChange.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bChange.ActiveForecolor = System.Drawing.Color.White;
            this.bChange.ActiveLineColor = System.Drawing.Color.Empty;
            this.bChange.BackColor = System.Drawing.SystemColors.Control;
            this.bChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bChange.BackgroundImage")));
            this.bChange.ButtonText = "Đổi";
            this.bChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.IdleBorderThickness = 1;
            this.bChange.IdleCornerRadius = 20;
            this.bChange.IdleFillColor = System.Drawing.Color.White;
            this.bChange.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.Location = new System.Drawing.Point(511, 559);
            this.bChange.Margin = new System.Windows.Forms.Padding(8);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(156, 69);
            this.bChange.TabIndex = 77;
            this.bChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lInvalid
            // 
            this.lInvalid.AutoSize = true;
            this.lInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lInvalid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInvalid.ForeColor = System.Drawing.Color.Red;
            this.lInvalid.Location = new System.Drawing.Point(293, 109);
            this.lInvalid.Name = "lInvalid";
            this.lInvalid.Size = new System.Drawing.Size(333, 21);
            this.lInvalid.TabIndex = 81;
            this.lInvalid.Text = "Tài khoản không tồn tại trong hệ thống";
            this.lInvalid.Visible = false;
            // 
            // lConfirmWrong
            // 
            this.lConfirmWrong.AutoSize = true;
            this.lConfirmWrong.BackColor = System.Drawing.Color.Transparent;
            this.lConfirmWrong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConfirmWrong.ForeColor = System.Drawing.Color.Red;
            this.lConfirmWrong.Location = new System.Drawing.Point(293, 527);
            this.lConfirmWrong.Name = "lConfirmWrong";
            this.lConfirmWrong.Size = new System.Drawing.Size(242, 21);
            this.lConfirmWrong.TabIndex = 80;
            this.lConfirmWrong.Text = "Mật khẩu không trùng khớp";
            this.lConfirmWrong.Visible = false;
            // 
            // lShortPass
            // 
            this.lShortPass.AutoSize = true;
            this.lShortPass.BackColor = System.Drawing.Color.Transparent;
            this.lShortPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShortPass.ForeColor = System.Drawing.Color.Red;
            this.lShortPass.Location = new System.Drawing.Point(293, 380);
            this.lShortPass.Name = "lShortPass";
            this.lShortPass.Size = new System.Drawing.Size(243, 21);
            this.lShortPass.TabIndex = 79;
            this.lShortPass.Text = "Mật khẩu phải dài hơn 8 kí tự";
            this.lShortPass.Visible = false;
            // 
            // tbNewPass1
            // 
            this.tbNewPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass1.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass1.HintText = "Mật khẩu mới";
            this.tbNewPass1.isPassword = false;
            this.tbNewPass1.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineThickness = 3;
            this.tbNewPass1.Location = new System.Drawing.Point(298, 291);
            this.tbNewPass1.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewPass1.Name = "tbNewPass1";
            this.tbNewPass1.Size = new System.Drawing.Size(555, 68);
            this.tbNewPass1.TabIndex = 75;
            this.tbNewPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbEmail.HintText = "Your old password";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEmail.LineThickness = 3;
            this.tbEmail.Location = new System.Drawing.Point(297, 15);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(6);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(555, 68);
            this.tbEmail.TabIndex = 74;
            this.tbEmail.Text = "ID/Email";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // GradientPanelAddDeadline
            // 
            this.GradientPanelAddDeadline.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanelAddDeadline.BackgroundImage")));
            this.GradientPanelAddDeadline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanelAddDeadline.Controls.Add(this.lbAddLesson);
            this.GradientPanelAddDeadline.Dock = System.Windows.Forms.DockStyle.Left;
            this.GradientPanelAddDeadline.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.Location = new System.Drawing.Point(0, 0);
            this.GradientPanelAddDeadline.Name = "GradientPanelAddDeadline";
            this.GradientPanelAddDeadline.Quality = 10;
            this.GradientPanelAddDeadline.Size = new System.Drawing.Size(208, 646);
            this.GradientPanelAddDeadline.TabIndex = 82;
            // 
            // lbAddLesson
            // 
            this.lbAddLesson.AutoSize = true;
            this.lbAddLesson.BackColor = System.Drawing.Color.Transparent;
            this.lbAddLesson.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddLesson.ForeColor = System.Drawing.Color.White;
            this.lbAddLesson.Location = new System.Drawing.Point(3, 240);
            this.lbAddLesson.Name = "lbAddLesson";
            this.lbAddLesson.Size = new System.Drawing.Size(217, 110);
            this.lbAddLesson.TabIndex = 18;
            this.lbAddLesson.Text = "Quên \r\nmật khẩu";
            this.lbAddLesson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lCodeWrong
            // 
            this.lCodeWrong.AutoSize = true;
            this.lCodeWrong.BackColor = System.Drawing.Color.Transparent;
            this.lCodeWrong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodeWrong.ForeColor = System.Drawing.Color.Red;
            this.lCodeWrong.Location = new System.Drawing.Point(293, 240);
            this.lCodeWrong.Name = "lCodeWrong";
            this.lCodeWrong.Size = new System.Drawing.Size(357, 21);
            this.lCodeWrong.TabIndex = 84;
            this.lCodeWrong.Text = "Mã xác nhận không đúng, vui lòng thử lại";
            this.lCodeWrong.Visible = false;
            // 
            // tbVerifyCode
            // 
            this.tbVerifyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbVerifyCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVerifyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbVerifyCode.HintForeColor = System.Drawing.Color.Empty;
            this.tbVerifyCode.HintText = "Your old password";
            this.tbVerifyCode.isPassword = false;
            this.tbVerifyCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbVerifyCode.LineIdleColor = System.Drawing.Color.Gray;
            this.tbVerifyCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbVerifyCode.LineThickness = 3;
            this.tbVerifyCode.Location = new System.Drawing.Point(298, 145);
            this.tbVerifyCode.Margin = new System.Windows.Forms.Padding(6);
            this.tbVerifyCode.Name = "tbVerifyCode";
            this.tbVerifyCode.Size = new System.Drawing.Size(555, 68);
            this.tbVerifyCode.TabIndex = 83;
            this.tbVerifyCode.Text = "Mã xác nhận";
            this.tbVerifyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 646);
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
            this.Text = "ForgotPass";
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
    }
}