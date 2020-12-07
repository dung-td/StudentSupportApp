
namespace StudentSupportApp
{
    partial class Notifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifi));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labelText = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAlert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.labelText);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Controls.Add(this.btnAlert);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.OrangeRed;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.OrangeRed;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(532, 110);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(6, 60);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(360, 23);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "You are having upcoming activities!";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(476, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 58);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlert.BackColor = System.Drawing.Color.Transparent;
            this.btnAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlert.BorderRadius = 0;
            this.btnAlert.ButtonText = "Alert!";
            this.btnAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlert.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlert.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlert.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAlert.Iconimage")));
            this.btnAlert.Iconimage_right = null;
            this.btnAlert.Iconimage_right_Selected = null;
            this.btnAlert.Iconimage_Selected = null;
            this.btnAlert.IconMarginLeft = 0;
            this.btnAlert.IconMarginRight = 0;
            this.btnAlert.IconRightVisible = true;
            this.btnAlert.IconRightZoom = 0D;
            this.btnAlert.IconVisible = true;
            this.btnAlert.IconZoom = 60D;
            this.btnAlert.IsTab = false;
            this.btnAlert.Location = new System.Drawing.Point(185, 0);
            this.btnAlert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAlert.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAlert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAlert.selected = false;
            this.btnAlert.Size = new System.Drawing.Size(172, 58);
            this.btnAlert.TabIndex = 0;
            this.btnAlert.Text = "Alert!";
            this.btnAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlert.Textcolor = System.Drawing.Color.White;
            this.btnAlert.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 110);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifi";
            this.Text = "Noti";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label labelText;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlert;
        private System.Windows.Forms.Timer timer1;
    }
}