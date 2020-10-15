namespace SSA
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
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MistyRose;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Linen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightCoral;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Ivory;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // lbIDinvalid
            // 
            this.lbIDinvalid.AutoSize = true;
            this.lbIDinvalid.ForeColor = System.Drawing.Color.Red;
            this.lbIDinvalid.Location = new System.Drawing.Point(269, 275);
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
            this.lbPassLogin.Location = new System.Drawing.Point(114, 238);
            this.lbPassLogin.Name = "lbPassLogin";
            this.lbPassLogin.Size = new System.Drawing.Size(78, 20);
            this.lbPassLogin.TabIndex = 6;
            this.lbPassLogin.Text = "Password";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(114, 163);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 20);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "ID";
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(546, 310);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(136, 67);
            this.btnExitApp.TabIndex = 4;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(118, 310);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(136, 67);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(333, 310);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 67);
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
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}