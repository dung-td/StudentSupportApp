namespace SSA
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbRepassWrong = new System.Windows.Forms.Label();
            this.lbShortPass = new System.Windows.Forms.Label();
            this.btnCancelSU = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lbPassSU = new System.Windows.Forms.Label();
            this.lbIDSU = new System.Windows.Forms.Label();
            this.lbRePassSU = new System.Windows.Forms.Label();
            this.tbxRePassSU = new System.Windows.Forms.TextBox();
            this.tbxPassSU = new System.Windows.Forms.TextBox();
            this.tbxIDSU = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbRepassWrong);
            this.bunifuGradientPanel1.Controls.Add(this.lbShortPass);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelSU);
            this.bunifuGradientPanel1.Controls.Add(this.btnSignup);
            this.bunifuGradientPanel1.Controls.Add(this.lbPassSU);
            this.bunifuGradientPanel1.Controls.Add(this.lbIDSU);
            this.bunifuGradientPanel1.Controls.Add(this.lbRePassSU);
            this.bunifuGradientPanel1.Controls.Add(this.tbxRePassSU);
            this.bunifuGradientPanel1.Controls.Add(this.tbxPassSU);
            this.bunifuGradientPanel1.Controls.Add(this.tbxIDSU);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Salmon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightCoral;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkSalmon;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // lbRepassWrong
            // 
            this.lbRepassWrong.AutoSize = true;
            this.lbRepassWrong.ForeColor = System.Drawing.Color.Red;
            this.lbRepassWrong.Location = new System.Drawing.Point(270, 299);
            this.lbRepassWrong.Name = "lbRepassWrong";
            this.lbRepassWrong.Size = new System.Drawing.Size(302, 20);
            this.lbRepassWrong.TabIndex = 26;
            this.lbRepassWrong.Text = "Repassword is incorrect. Please try again!";
            this.lbRepassWrong.Visible = false;
            // 
            // lbShortPass
            // 
            this.lbShortPass.AutoSize = true;
            this.lbShortPass.ForeColor = System.Drawing.Color.Red;
            this.lbShortPass.Location = new System.Drawing.Point(204, 222);
            this.lbShortPass.Name = "lbShortPass";
            this.lbShortPass.Size = new System.Drawing.Size(478, 20);
            this.lbShortPass.TabIndex = 25;
            this.lbShortPass.Text = "Password must equal or longer than 8 characters. Please try again!";
            this.lbShortPass.Visible = false;
            // 
            // btnCancelSU
            // 
            this.btnCancelSU.Location = new System.Drawing.Point(428, 338);
            this.btnCancelSU.Name = "btnCancelSU";
            this.btnCancelSU.Size = new System.Drawing.Size(124, 66);
            this.btnCancelSU.TabIndex = 24;
            this.btnCancelSU.Text = "Cancel";
            this.btnCancelSU.UseVisualStyleBackColor = true;
            this.btnCancelSU.Click += new System.EventHandler(this.btnCancelSU_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(232, 338);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(124, 66);
            this.btnSignup.TabIndex = 23;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lbPassSU
            // 
            this.lbPassSU.AutoSize = true;
            this.lbPassSU.Location = new System.Drawing.Point(84, 199);
            this.lbPassSU.Name = "lbPassSU";
            this.lbPassSU.Size = new System.Drawing.Size(78, 20);
            this.lbPassSU.TabIndex = 22;
            this.lbPassSU.Text = "Password";
            // 
            // lbIDSU
            // 
            this.lbIDSU.AutoSize = true;
            this.lbIDSU.Location = new System.Drawing.Point(84, 135);
            this.lbIDSU.Name = "lbIDSU";
            this.lbIDSU.Size = new System.Drawing.Size(26, 20);
            this.lbIDSU.TabIndex = 21;
            this.lbIDSU.Text = "ID";
            // 
            // lbRePassSU
            // 
            this.lbRePassSU.AutoSize = true;
            this.lbRePassSU.Location = new System.Drawing.Point(84, 267);
            this.lbRePassSU.Name = "lbRePassSU";
            this.lbRePassSU.Size = new System.Drawing.Size(99, 20);
            this.lbRePassSU.TabIndex = 20;
            this.lbRePassSU.Text = "RePassword";
            // 
            // tbxRePassSU
            // 
            this.tbxRePassSU.Location = new System.Drawing.Point(208, 261);
            this.tbxRePassSU.Name = "tbxRePassSU";
            this.tbxRePassSU.PasswordChar = '*';
            this.tbxRePassSU.Size = new System.Drawing.Size(468, 26);
            this.tbxRePassSU.TabIndex = 19;
            this.tbxRePassSU.TextChanged += new System.EventHandler(this.tbxRePassSU_TextChanged);
            // 
            // tbxPassSU
            // 
            this.tbxPassSU.Location = new System.Drawing.Point(208, 193);
            this.tbxPassSU.Name = "tbxPassSU";
            this.tbxPassSU.PasswordChar = '*';
            this.tbxPassSU.Size = new System.Drawing.Size(468, 26);
            this.tbxPassSU.TabIndex = 18;
            this.tbxPassSU.TextChanged += new System.EventHandler(this.tbxPassSU_TextChanged);
            // 
            // tbxIDSU
            // 
            this.tbxIDSU.Location = new System.Drawing.Point(208, 129);
            this.tbxIDSU.Name = "tbxIDSU";
            this.tbxIDSU.Size = new System.Drawing.Size(468, 26);
            this.tbxIDSU.TabIndex = 17;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbRepassWrong;
        private System.Windows.Forms.Label lbShortPass;
        private System.Windows.Forms.Button btnCancelSU;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lbPassSU;
        private System.Windows.Forms.Label lbIDSU;
        private System.Windows.Forms.Label lbRePassSU;
        private System.Windows.Forms.TextBox tbxRePassSU;
        private System.Windows.Forms.TextBox tbxPassSU;
        private System.Windows.Forms.TextBox tbxIDSU;
    }
}