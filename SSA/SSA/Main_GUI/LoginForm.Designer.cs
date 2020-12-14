namespace StudentSupportApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbxID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bID = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bForgot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelInvalid = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelWrong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbLogin);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(155, 390);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(11, 144);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(136, 90);
            this.lbLogin.TabIndex = 20;
            this.lbLogin.Text = "Đăng \r\nnhập";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bExit
            // 
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bExit.ActiveForecolor = System.Drawing.Color.White;
            this.bExit.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.bExit.BackColor = System.Drawing.SystemColors.Control;
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.ButtonText = "Thoát";
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bExit.IdleBorderThickness = 1;
            this.bExit.IdleCornerRadius = 20;
            this.bExit.IdleFillColor = System.Drawing.Color.White;
            this.bExit.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.bExit.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.bExit.Location = new System.Drawing.Point(469, 291);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(105, 40);
            this.bExit.TabIndex = 2;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bLogin
            // 
            this.bLogin.ActiveBorderThickness = 1;
            this.bLogin.ActiveCornerRadius = 20;
            this.bLogin.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bLogin.ActiveForecolor = System.Drawing.Color.White;
            this.bLogin.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.bLogin.BackColor = System.Drawing.SystemColors.Control;
            this.bLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bLogin.BackgroundImage")));
            this.bLogin.ButtonText = "Đăng nhập";
            this.bLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bLogin.IdleBorderThickness = 1;
            this.bLogin.IdleCornerRadius = 20;
            this.bLogin.IdleFillColor = System.Drawing.Color.White;
            this.bLogin.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.bLogin.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.bLogin.Location = new System.Drawing.Point(199, 291);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(105, 40);
            this.bLogin.TabIndex = 3;
            this.bLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bSignUp
            // 
            this.bSignUp.ActiveBorderThickness = 1;
            this.bSignUp.ActiveCornerRadius = 20;
            this.bSignUp.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bSignUp.ActiveForecolor = System.Drawing.Color.White;
            this.bSignUp.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.bSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.bSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSignUp.BackgroundImage")));
            this.bSignUp.ButtonText = "Đăng kí";
            this.bSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSignUp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bSignUp.IdleBorderThickness = 1;
            this.bSignUp.IdleCornerRadius = 20;
            this.bSignUp.IdleFillColor = System.Drawing.Color.White;
            this.bSignUp.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.bSignUp.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.bSignUp.Location = new System.Drawing.Point(335, 291);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(105, 40);
            this.bSignUp.TabIndex = 4;
            this.bSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            // 
            // tbxID
            // 
            this.tbxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxID.HintForeColor = System.Drawing.Color.Empty;
            this.tbxID.HintText = "Nhập ID hoặc Username";
            this.tbxID.isPassword = false;
            this.tbxID.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbxID.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbxID.LineThickness = 3;
            this.tbxID.Location = new System.Drawing.Point(357, 97);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(181, 55);
            this.tbxID.TabIndex = 6;
            this.tbxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxID.OnValueChanged += new System.EventHandler(this.tbxID_OnValueChanged);
            // 
            // tbxPass
            // 
            this.tbxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPass.HintForeColor = System.Drawing.Color.Empty;
            this.tbxPass.HintText = "Nhập mật khẩu";
            this.tbxPass.isPassword = false;
            this.tbxPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbxPass.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbxPass.LineThickness = 3;
            this.tbxPass.Location = new System.Drawing.Point(357, 184);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(181, 51);
            this.tbxPass.TabIndex = 7;
            this.tbxPass.Text = "Nhập password";
            this.tbxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPass.OnValueChanged += new System.EventHandler(this.tbxPass_OnValueChanged);
            this.tbxPass.Enter += new System.EventHandler(this.tbxPass_Enter);
            this.tbxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPass_KeyDown);
            // 
            // bID
            // 
            this.bID.Activecolor = System.Drawing.Color.Transparent;
            this.bID.BackColor = System.Drawing.Color.Transparent;
            this.bID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bID.BorderRadius = 0;
            this.bID.ButtonText = "ID/Username";
            this.bID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bID.DisabledColor = System.Drawing.Color.Transparent;
            this.bID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bID.Iconcolor = System.Drawing.Color.Transparent;
            this.bID.Iconimage = ((System.Drawing.Image)(resources.GetObject("bID.Iconimage")));
            this.bID.Iconimage_right = null;
            this.bID.Iconimage_right_Selected = null;
            this.bID.Iconimage_Selected = null;
            this.bID.IconMarginLeft = 0;
            this.bID.IconMarginRight = 0;
            this.bID.IconRightVisible = true;
            this.bID.IconRightZoom = 0D;
            this.bID.IconVisible = true;
            this.bID.IconZoom = 60D;
            this.bID.IsTab = false;
            this.bID.Location = new System.Drawing.Point(175, 121);
            this.bID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bID.Name = "bID";
            this.bID.Normalcolor = System.Drawing.Color.Transparent;
            this.bID.OnHovercolor = System.Drawing.Color.Transparent;
            this.bID.OnHoverTextColor = System.Drawing.SystemColors.Highlight;
            this.bID.selected = false;
            this.bID.Size = new System.Drawing.Size(162, 31);
            this.bID.TabIndex = 8;
            this.bID.Text = "ID/Username";
            this.bID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bID.Textcolor = System.Drawing.Color.Black;
            this.bID.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bPassword
            // 
            this.bPassword.Activecolor = System.Drawing.Color.Transparent;
            this.bPassword.BackColor = System.Drawing.Color.Transparent;
            this.bPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPassword.BorderRadius = 0;
            this.bPassword.ButtonText = "Mật khẩu";
            this.bPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPassword.DisabledColor = System.Drawing.Color.Gray;
            this.bPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.bPassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("bPassword.Iconimage")));
            this.bPassword.Iconimage_right = null;
            this.bPassword.Iconimage_right_Selected = null;
            this.bPassword.Iconimage_Selected = null;
            this.bPassword.IconMarginLeft = 0;
            this.bPassword.IconMarginRight = 0;
            this.bPassword.IconRightVisible = true;
            this.bPassword.IconRightZoom = 0D;
            this.bPassword.IconVisible = true;
            this.bPassword.IconZoom = 60D;
            this.bPassword.IsTab = false;
            this.bPassword.Location = new System.Drawing.Point(175, 203);
            this.bPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bPassword.Name = "bPassword";
            this.bPassword.Normalcolor = System.Drawing.Color.Transparent;
            this.bPassword.OnHovercolor = System.Drawing.Color.Transparent;
            this.bPassword.OnHoverTextColor = System.Drawing.SystemColors.Highlight;
            this.bPassword.selected = false;
            this.bPassword.Size = new System.Drawing.Size(155, 31);
            this.bPassword.TabIndex = 9;
            this.bPassword.Text = "Mật khẩu";
            this.bPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bPassword.Textcolor = System.Drawing.Color.Black;
            this.bPassword.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(185, 19);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(409, 45);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Student Support App";
            // 
            // bForgot
            // 
            this.bForgot.Activecolor = System.Drawing.Color.Transparent;
            this.bForgot.BackColor = System.Drawing.Color.Transparent;
            this.bForgot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bForgot.BorderRadius = 0;
            this.bForgot.ButtonText = "Quên ID/Mật khẩu?";
            this.bForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForgot.DisabledColor = System.Drawing.Color.Transparent;
            this.bForgot.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bForgot.Iconcolor = System.Drawing.Color.Transparent;
            this.bForgot.Iconimage = null;
            this.bForgot.Iconimage_right = null;
            this.bForgot.Iconimage_right_Selected = null;
            this.bForgot.Iconimage_Selected = null;
            this.bForgot.IconMarginLeft = 0;
            this.bForgot.IconMarginRight = 0;
            this.bForgot.IconRightVisible = true;
            this.bForgot.IconRightZoom = 0D;
            this.bForgot.IconVisible = true;
            this.bForgot.IconZoom = 60D;
            this.bForgot.IsTab = false;
            this.bForgot.Location = new System.Drawing.Point(375, 240);
            this.bForgot.Name = "bForgot";
            this.bForgot.Normalcolor = System.Drawing.Color.Transparent;
            this.bForgot.OnHovercolor = System.Drawing.Color.Transparent;
            this.bForgot.OnHoverTextColor = System.Drawing.SystemColors.Highlight;
            this.bForgot.selected = false;
            this.bForgot.Size = new System.Drawing.Size(144, 31);
            this.bForgot.TabIndex = 13;
            this.bForgot.Text = "Quên ID/Mật khẩu?";
            this.bForgot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bForgot.Textcolor = System.Drawing.Color.Black;
            this.bForgot.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bForgot.Click += new System.EventHandler(this.bForgot_Click);
            // 
            // labelInvalid
            // 
            this.labelInvalid.Activecolor = System.Drawing.Color.Transparent;
            this.labelInvalid.BackColor = System.Drawing.Color.Transparent;
            this.labelInvalid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.labelInvalid.BorderRadius = 0;
            this.labelInvalid.ButtonText = "ID/ Username không tồn tại!";
            this.labelInvalid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInvalid.DisabledColor = System.Drawing.Color.Transparent;
            this.labelInvalid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalid.ForeColor = System.Drawing.Color.Red;
            this.labelInvalid.Iconcolor = System.Drawing.Color.Transparent;
            this.labelInvalid.Iconimage = null;
            this.labelInvalid.Iconimage_right = null;
            this.labelInvalid.Iconimage_right_Selected = null;
            this.labelInvalid.Iconimage_Selected = null;
            this.labelInvalid.IconMarginLeft = 0;
            this.labelInvalid.IconMarginRight = 0;
            this.labelInvalid.IconRightVisible = true;
            this.labelInvalid.IconRightZoom = 0D;
            this.labelInvalid.IconVisible = true;
            this.labelInvalid.IconZoom = 60D;
            this.labelInvalid.IsTab = false;
            this.labelInvalid.Location = new System.Drawing.Point(349, 158);
            this.labelInvalid.Name = "labelInvalid";
            this.labelInvalid.Normalcolor = System.Drawing.Color.Transparent;
            this.labelInvalid.OnHovercolor = System.Drawing.Color.Transparent;
            this.labelInvalid.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.labelInvalid.selected = false;
            this.labelInvalid.Size = new System.Drawing.Size(195, 31);
            this.labelInvalid.TabIndex = 14;
            this.labelInvalid.Text = "ID/ Username không tồn tại!";
            this.labelInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInvalid.Textcolor = System.Drawing.Color.Red;
            this.labelInvalid.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalid.Visible = false;
            // 
            // labelWrong
            // 
            this.labelWrong.Activecolor = System.Drawing.Color.Transparent;
            this.labelWrong.BackColor = System.Drawing.Color.Transparent;
            this.labelWrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.labelWrong.BorderRadius = 0;
            this.labelWrong.ButtonText = "Sai mật khẩu!";
            this.labelWrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelWrong.DisabledColor = System.Drawing.Color.Transparent;
            this.labelWrong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrong.ForeColor = System.Drawing.Color.Red;
            this.labelWrong.Iconcolor = System.Drawing.Color.Transparent;
            this.labelWrong.Iconimage = null;
            this.labelWrong.Iconimage_right = null;
            this.labelWrong.Iconimage_right_Selected = null;
            this.labelWrong.Iconimage_Selected = null;
            this.labelWrong.IconMarginLeft = 0;
            this.labelWrong.IconMarginRight = 0;
            this.labelWrong.IconRightVisible = true;
            this.labelWrong.IconRightZoom = 0D;
            this.labelWrong.IconVisible = true;
            this.labelWrong.IconZoom = 60D;
            this.labelWrong.IsTab = false;
            this.labelWrong.Location = new System.Drawing.Point(357, 240);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Normalcolor = System.Drawing.Color.Transparent;
            this.labelWrong.OnHovercolor = System.Drawing.Color.Transparent;
            this.labelWrong.OnHoverTextColor = System.Drawing.Color.Red;
            this.labelWrong.selected = false;
            this.labelWrong.Size = new System.Drawing.Size(181, 31);
            this.labelWrong.TabIndex = 15;
            this.labelWrong.Text = "Sai mật khẩu!";
            this.labelWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWrong.Textcolor = System.Drawing.Color.Red;
            this.labelWrong.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrong.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(263, 70);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(213, 19);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 390);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.labelInvalid);
            this.Controls.Add(this.bForgot);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bPassword);
            this.Controls.Add(this.bID);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.bSignUp);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LoginForm_VisibleChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bSignUp;
        private Bunifu.Framework.UI.BunifuThinButton2 bLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxID;
        private Bunifu.Framework.UI.BunifuFlatButton bPassword;
        private Bunifu.Framework.UI.BunifuFlatButton bID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bForgot;
        private Bunifu.Framework.UI.BunifuFlatButton labelInvalid;
        private Bunifu.Framework.UI.BunifuFlatButton labelWrong;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lbLogin;
    }
}