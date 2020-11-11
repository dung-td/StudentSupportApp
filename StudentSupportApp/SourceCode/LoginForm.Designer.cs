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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.lbIDinvalid = new System.Windows.Forms.Label();
            this.lbWrongPass = new System.Windows.Forms.Label();
            this.lbPassLogin = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxPassLogin = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbLogo);
            this.bunifuGradientPanel1.Controls.Add(this.lbIDinvalid);
            this.bunifuGradientPanel1.Controls.Add(this.lbWrongPass);
            this.bunifuGradientPanel1.Controls.Add(this.lbPassLogin);
            this.bunifuGradientPanel1.Controls.Add(this.lbID);
            this.bunifuGradientPanel1.Controls.Add(this.btnExitApp);
            this.bunifuGradientPanel1.Controls.Add(this.btnSignup);
            this.bunifuGradientPanel1.Controls.Add(this.btnLogin);
            this.bunifuGradientPanel1.Controls.Add(this.tbxID);
            this.bunifuGradientPanel1.Controls.Add(this.tbxPassLogin);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 449);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.Color.Transparent;
            this.lbLogo.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.White;
            this.lbLogo.Location = new System.Drawing.Point(108, 47);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(638, 60);
            this.lbLogo.TabIndex = 9;
            this.lbLogo.Text = "STUDENT SUPPORT APP";
            // 
            // lbIDinvalid
            // 
            this.lbIDinvalid.AutoSize = true;
            this.lbIDinvalid.ForeColor = System.Drawing.Color.Red;
            this.lbIDinvalid.Location = new System.Drawing.Point(268, 275);
            this.lbIDinvalid.Name = "lbIDinvalid";
            this.lbIDinvalid.Size = new System.Drawing.Size(250, 20);
            this.lbIDinvalid.TabIndex = 8;
            this.lbIDinvalid.Text = "Your ID is invalid. Please try again!";
            this.lbIDinvalid.Visible = false;
            // 
            // lbWrongPass
            // 
            this.lbWrongPass.AutoSize = true;
            this.lbWrongPass.ForeColor = System.Drawing.Color.Red;
            this.lbWrongPass.Location = new System.Drawing.Point(244, 275);
            this.lbWrongPass.Name = "lbWrongPass";
            this.lbWrongPass.Size = new System.Drawing.Size(319, 20);
            this.lbWrongPass.TabIndex = 7;
            this.lbWrongPass.Text = "Your password is incorrect. Please try again!";
            this.lbWrongPass.Visible = false;
            // 
            // lbPassLogin
            // 
            this.lbPassLogin.AutoSize = true;
            this.lbPassLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbPassLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassLogin.ForeColor = System.Drawing.Color.White;
            this.lbPassLogin.Location = new System.Drawing.Point(77, 232);
            this.lbPassLogin.Name = "lbPassLogin";
            this.lbPassLogin.Size = new System.Drawing.Size(104, 27);
            this.lbPassLogin.TabIndex = 6;
            this.lbPassLogin.Text = "Password";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(102, 157);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(37, 27);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "ID";
            // 
            // btnExitApp
            // 
            this.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApp.Location = new System.Drawing.Point(546, 309);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(136, 68);
            this.btnExitApp.TabIndex = 4;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.Location = new System.Drawing.Point(118, 309);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(136, 68);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(333, 309);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 68);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(198, 157);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(484, 26);
            this.tbxID.TabIndex = 0;
            // 
            // tbxPassLogin
            // 
            this.tbxPassLogin.Location = new System.Drawing.Point(198, 232);
            this.tbxPassLogin.Name = "tbxPassLogin";
            this.tbxPassLogin.PasswordChar = '*';
            this.tbxPassLogin.Size = new System.Drawing.Size(484, 26);
            this.tbxPassLogin.TabIndex = 1;
            this.tbxPassLogin.UseSystemPasswordChar = true;
            this.tbxPassLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassLogin_KeyDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbIDinvalid;
        private System.Windows.Forms.Label lbWrongPass;
        private System.Windows.Forms.Label lbPassLogin;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxPassLogin;
        private System.Windows.Forms.Label lbLogo;
    }
}
