
namespace StudentSupportApp
{
    partial class ChangeEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeEmailForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GradientPanelAddDeadline = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbAddLesson = new System.Windows.Forms.Label();
            this.tbxCurPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxNewEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxChangeMailVC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnExitEmailF = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChangeEmailF = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSendCodeCE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbWrongPasswd = new System.Windows.Forms.Label();
            this.lbInvalidEmailAddr = new System.Windows.Forms.Label();
            this.lbWrongVeriCode = new System.Windows.Forms.Label();
            this.lbSentCode = new System.Windows.Forms.Label();
            this.lbUsedEmail = new System.Windows.Forms.Label();
            this.GradientPanelAddDeadline.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GradientPanelAddDeadline
            // 
            this.GradientPanelAddDeadline.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanelAddDeadline.Controls.Add(this.lbAddLesson);
            this.GradientPanelAddDeadline.Dock = System.Windows.Forms.DockStyle.Left;
            this.GradientPanelAddDeadline.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.Location = new System.Drawing.Point(0, 0);
            this.GradientPanelAddDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.GradientPanelAddDeadline.Name = "GradientPanelAddDeadline";
            this.GradientPanelAddDeadline.Quality = 10;
            this.GradientPanelAddDeadline.Size = new System.Drawing.Size(139, 340);
            this.GradientPanelAddDeadline.TabIndex = 48;
            // 
            // lbAddLesson
            // 
            this.lbAddLesson.AutoSize = true;
            this.lbAddLesson.BackColor = System.Drawing.Color.Transparent;
            this.lbAddLesson.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddLesson.ForeColor = System.Drawing.Color.White;
            this.lbAddLesson.Location = new System.Drawing.Point(22, 128);
            this.lbAddLesson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddLesson.Name = "lbAddLesson";
            this.lbAddLesson.Size = new System.Drawing.Size(94, 74);
            this.lbAddLesson.TabIndex = 18;
            this.lbAddLesson.Text = "Đổi\r\nEmail";
            this.lbAddLesson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxCurPass
            // 
            this.tbxCurPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCurPass.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCurPass.HintForeColor = System.Drawing.Color.Empty;
            this.tbxCurPass.HintText = "Nhập mật khẩu";
            this.tbxCurPass.isPassword = false;
            this.tbxCurPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbxCurPass.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxCurPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbxCurPass.LineThickness = 3;
            this.tbxCurPass.Location = new System.Drawing.Point(157, 0);
            this.tbxCurPass.Margin = new System.Windows.Forms.Padding(5);
            this.tbxCurPass.Name = "tbxCurPass";
            this.tbxCurPass.Size = new System.Drawing.Size(233, 58);
            this.tbxCurPass.TabIndex = 66;
            this.tbxCurPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxCurPass.OnValueChanged += new System.EventHandler(this.tbxCurPass_OnValueChanged);
            this.tbxCurPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCurPass_KeyDown);
            // 
            // tbxNewEmail
            // 
            this.tbxNewEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNewEmail.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxNewEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbxNewEmail.HintText = "Nhập email mới";
            this.tbxNewEmail.isPassword = false;
            this.tbxNewEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbxNewEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxNewEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbxNewEmail.LineThickness = 3;
            this.tbxNewEmail.Location = new System.Drawing.Point(157, 103);
            this.tbxNewEmail.Margin = new System.Windows.Forms.Padding(5);
            this.tbxNewEmail.Name = "tbxNewEmail";
            this.tbxNewEmail.Size = new System.Drawing.Size(358, 57);
            this.tbxNewEmail.TabIndex = 67;
            this.tbxNewEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxNewEmail.OnValueChanged += new System.EventHandler(this.tbxNewEmail_OnValueChanged);
            this.tbxNewEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNewEmail_KeyDown);
            // 
            // tbxChangeMailVC
            // 
            this.tbxChangeMailVC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxChangeMailVC.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChangeMailVC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxChangeMailVC.HintForeColor = System.Drawing.Color.Empty;
            this.tbxChangeMailVC.HintText = "Mã xác nhận";
            this.tbxChangeMailVC.isPassword = false;
            this.tbxChangeMailVC.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbxChangeMailVC.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxChangeMailVC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbxChangeMailVC.LineThickness = 3;
            this.tbxChangeMailVC.Location = new System.Drawing.Point(157, 198);
            this.tbxChangeMailVC.Margin = new System.Windows.Forms.Padding(5);
            this.tbxChangeMailVC.Name = "tbxChangeMailVC";
            this.tbxChangeMailVC.Size = new System.Drawing.Size(233, 56);
            this.tbxChangeMailVC.TabIndex = 68;
            this.tbxChangeMailVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxChangeMailVC.OnValueChanged += new System.EventHandler(this.tbxChangeMailVC_OnValueChanged);
            this.tbxChangeMailVC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxChangeMailVC_KeyDown);
            // 
            // btnExitEmailF
            // 
            this.btnExitEmailF.ActiveBorderThickness = 1;
            this.btnExitEmailF.ActiveCornerRadius = 20;
            this.btnExitEmailF.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnExitEmailF.ActiveForecolor = System.Drawing.Color.White;
            this.btnExitEmailF.ActiveLineColor = System.Drawing.Color.Empty;
            this.btnExitEmailF.BackColor = System.Drawing.SystemColors.Control;
            this.btnExitEmailF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitEmailF.BackgroundImage")));
            this.btnExitEmailF.ButtonText = "Thoát";
            this.btnExitEmailF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitEmailF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitEmailF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnExitEmailF.IdleBorderThickness = 1;
            this.btnExitEmailF.IdleCornerRadius = 20;
            this.btnExitEmailF.IdleFillColor = System.Drawing.Color.White;
            this.btnExitEmailF.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnExitEmailF.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnExitEmailF.Location = new System.Drawing.Point(356, 279);
            this.btnExitEmailF.Margin = new System.Windows.Forms.Padding(5);
            this.btnExitEmailF.Name = "btnExitEmailF";
            this.btnExitEmailF.Size = new System.Drawing.Size(104, 44);
            this.btnExitEmailF.TabIndex = 71;
            this.btnExitEmailF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExitEmailF.Click += new System.EventHandler(this.btnExitEmailF_Click);
            // 
            // btnChangeEmailF
            // 
            this.btnChangeEmailF.ActiveBorderThickness = 1;
            this.btnChangeEmailF.ActiveCornerRadius = 20;
            this.btnChangeEmailF.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnChangeEmailF.ActiveForecolor = System.Drawing.Color.White;
            this.btnChangeEmailF.ActiveLineColor = System.Drawing.Color.Empty;
            this.btnChangeEmailF.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeEmailF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeEmailF.BackgroundImage")));
            this.btnChangeEmailF.ButtonText = "Đổi";
            this.btnChangeEmailF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeEmailF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmailF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangeEmailF.IdleBorderThickness = 1;
            this.btnChangeEmailF.IdleCornerRadius = 20;
            this.btnChangeEmailF.IdleFillColor = System.Drawing.Color.White;
            this.btnChangeEmailF.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangeEmailF.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangeEmailF.Location = new System.Drawing.Point(216, 278);
            this.btnChangeEmailF.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangeEmailF.Name = "btnChangeEmailF";
            this.btnChangeEmailF.Size = new System.Drawing.Size(104, 45);
            this.btnChangeEmailF.TabIndex = 70;
            this.btnChangeEmailF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeEmailF.Click += new System.EventHandler(this.btnChangeEmailF_Click);
            // 
            // btnSendCodeCE
            // 
            this.btnSendCodeCE.ActiveBorderThickness = 1;
            this.btnSendCodeCE.ActiveCornerRadius = 20;
            this.btnSendCodeCE.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnSendCodeCE.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendCodeCE.ActiveLineColor = System.Drawing.Color.Empty;
            this.btnSendCodeCE.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendCodeCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendCodeCE.BackgroundImage")));
            this.btnSendCodeCE.ButtonText = "Gửi Mã";
            this.btnSendCodeCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCodeCE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCodeCE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSendCodeCE.IdleBorderThickness = 1;
            this.btnSendCodeCE.IdleCornerRadius = 20;
            this.btnSendCodeCE.IdleFillColor = System.Drawing.Color.White;
            this.btnSendCodeCE.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSendCodeCE.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSendCodeCE.Location = new System.Drawing.Point(411, 198);
            this.btnSendCodeCE.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendCodeCE.Name = "btnSendCodeCE";
            this.btnSendCodeCE.Size = new System.Drawing.Size(104, 44);
            this.btnSendCodeCE.TabIndex = 72;
            this.btnSendCodeCE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendCodeCE.Click += new System.EventHandler(this.btnSendCodeCE_Click);
            // 
            // lbWrongPasswd
            // 
            this.lbWrongPasswd.AutoSize = true;
            this.lbWrongPasswd.BackColor = System.Drawing.Color.Transparent;
            this.lbWrongPasswd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrongPasswd.ForeColor = System.Drawing.Color.Red;
            this.lbWrongPasswd.Location = new System.Drawing.Point(155, 70);
            this.lbWrongPasswd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWrongPasswd.Name = "lbWrongPasswd";
            this.lbWrongPasswd.Size = new System.Drawing.Size(151, 17);
            this.lbWrongPasswd.TabIndex = 73;
            this.lbWrongPasswd.Text = "Sai mật khẩu! Hãy thử lại!";
            this.lbWrongPasswd.Visible = false;
            // 
            // lbInvalidEmailAddr
            // 
            this.lbInvalidEmailAddr.AutoSize = true;
            this.lbInvalidEmailAddr.BackColor = System.Drawing.Color.Transparent;
            this.lbInvalidEmailAddr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidEmailAddr.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidEmailAddr.Location = new System.Drawing.Point(155, 164);
            this.lbInvalidEmailAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInvalidEmailAddr.Name = "lbInvalidEmailAddr";
            this.lbInvalidEmailAddr.Size = new System.Drawing.Size(230, 17);
            this.lbInvalidEmailAddr.TabIndex = 74;
            this.lbInvalidEmailAddr.Text = "Invalid email format. Please try again!";
            this.lbInvalidEmailAddr.Visible = false;
            // 
            // lbWrongVeriCode
            // 
            this.lbWrongVeriCode.AutoSize = true;
            this.lbWrongVeriCode.BackColor = System.Drawing.Color.Transparent;
            this.lbWrongVeriCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrongVeriCode.ForeColor = System.Drawing.Color.Red;
            this.lbWrongVeriCode.Location = new System.Drawing.Point(155, 261);
            this.lbWrongVeriCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWrongVeriCode.Name = "lbWrongVeriCode";
            this.lbWrongVeriCode.Size = new System.Drawing.Size(173, 17);
            this.lbWrongVeriCode.TabIndex = 75;
            this.lbWrongVeriCode.Text = "Sai mã xác nhận. Hãy thử lại!";
            this.lbWrongVeriCode.Visible = false;
            // 
            // lbSentCode
            // 
            this.lbSentCode.AutoSize = true;
            this.lbSentCode.BackColor = System.Drawing.Color.Transparent;
            this.lbSentCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSentCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSentCode.Location = new System.Drawing.Point(155, 166);
            this.lbSentCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSentCode.Name = "lbSentCode";
            this.lbSentCode.Size = new System.Drawing.Size(342, 17);
            this.lbSentCode.TabIndex = 76;
            this.lbSentCode.Text = "Mã xác nhận đã được gửi tới email của bạn. Hãy kiểm tra!";
            this.lbSentCode.Visible = false;
            // 
            // lbUsedEmail
            // 
            this.lbUsedEmail.AutoSize = true;
            this.lbUsedEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbUsedEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsedEmail.ForeColor = System.Drawing.Color.Red;
            this.lbUsedEmail.Location = new System.Drawing.Point(155, 166);
            this.lbUsedEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsedEmail.Name = "lbUsedEmail";
            this.lbUsedEmail.Size = new System.Drawing.Size(333, 17);
            this.lbUsedEmail.TabIndex = 77;
            this.lbUsedEmail.Text = "Email này đã có sẵn trong hệ thống! Hãy thử email khác!";
            this.lbUsedEmail.Visible = false;
            // 
            // ChangeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 340);
            this.Controls.Add(this.lbUsedEmail);
            this.Controls.Add(this.lbSentCode);
            this.Controls.Add(this.lbWrongVeriCode);
            this.Controls.Add(this.lbInvalidEmailAddr);
            this.Controls.Add(this.lbWrongPasswd);
            this.Controls.Add(this.btnSendCodeCE);
            this.Controls.Add(this.btnExitEmailF);
            this.Controls.Add(this.btnChangeEmailF);
            this.Controls.Add(this.tbxChangeMailVC);
            this.Controls.Add(this.tbxNewEmail);
            this.Controls.Add(this.tbxCurPass);
            this.Controls.Add(this.GradientPanelAddDeadline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeEmailForm";
            this.Text = "ChangeEmailForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeEmailForm_MouseMove);
            this.GradientPanelAddDeadline.ResumeLayout(false);
            this.GradientPanelAddDeadline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelAddDeadline;
        private System.Windows.Forms.Label lbAddLesson;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxChangeMailVC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxNewEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxCurPass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExitEmailF;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChangeEmailF;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSendCodeCE;
        private System.Windows.Forms.Label lbWrongVeriCode;
        private System.Windows.Forms.Label lbInvalidEmailAddr;
        private System.Windows.Forms.Label lbWrongPasswd;
        private System.Windows.Forms.Label lbSentCode;
        private System.Windows.Forms.Label lbUsedEmail;
    }
}