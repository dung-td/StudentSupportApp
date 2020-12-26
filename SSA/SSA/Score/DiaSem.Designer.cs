
namespace StudentSupportApp
{
    partial class DiaSem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaSem));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbAddNew = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lDiaSem = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 215);
            this.panel1.TabIndex = 70;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(8, 77);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(120, 62);
            this.lbLogin.TabIndex = 21;
            this.lbLogin.Text = "Thông tin\r\nhọc kì";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddNew
            // 
            this.tbAddNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddNew.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAddNew.HintForeColor = System.Drawing.Color.Empty;
            this.tbAddNew.HintText = "";
            this.tbAddNew.isPassword = false;
            this.tbAddNew.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbAddNew.LineIdleColor = System.Drawing.Color.Gray;
            this.tbAddNew.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbAddNew.LineThickness = 4;
            this.tbAddNew.Location = new System.Drawing.Point(137, 77);
            this.tbAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddNew.Name = "tbAddNew";
            this.tbAddNew.Size = new System.Drawing.Size(292, 47);
            this.tbAddNew.TabIndex = 69;
            this.tbAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bExit
            // 
            this.bExit.Activecolor = System.Drawing.Color.Silver;
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bExit.BorderRadius = 0;
            this.bExit.ButtonText = "";
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.DisabledColor = System.Drawing.Color.Gray;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.Transparent;
            this.bExit.Iconcolor = System.Drawing.Color.Transparent;
            this.bExit.Iconimage = null;
            this.bExit.Iconimage_right = null;
            this.bExit.Iconimage_right_Selected = null;
            this.bExit.Iconimage_Selected = null;
            this.bExit.IconMarginLeft = 0;
            this.bExit.IconMarginRight = 0;
            this.bExit.IconRightVisible = true;
            this.bExit.IconRightZoom = 0D;
            this.bExit.IconVisible = true;
            this.bExit.IconZoom = 90D;
            this.bExit.IsTab = false;
            this.bExit.Location = new System.Drawing.Point(304, 140);
            this.bExit.Margin = new System.Windows.Forms.Padding(5);
            this.bExit.Name = "bExit";
            this.bExit.Normalcolor = System.Drawing.Color.Transparent;
            this.bExit.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bExit.OnHoverTextColor = System.Drawing.Color.Black;
            this.bExit.selected = false;
            this.bExit.Size = new System.Drawing.Size(45, 39);
            this.bExit.TabIndex = 68;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Textcolor = System.Drawing.Color.Gray;
            this.bExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bOK
            // 
            this.bOK.Activecolor = System.Drawing.Color.Silver;
            this.bOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bOK.BackColor = System.Drawing.Color.Transparent;
            this.bOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bOK.BackgroundImage")));
            this.bOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bOK.BorderRadius = 0;
            this.bOK.ButtonText = "";
            this.bOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOK.DisabledColor = System.Drawing.Color.Gray;
            this.bOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.ForeColor = System.Drawing.Color.Transparent;
            this.bOK.Iconcolor = System.Drawing.Color.Transparent;
            this.bOK.Iconimage = null;
            this.bOK.Iconimage_right = null;
            this.bOK.Iconimage_right_Selected = null;
            this.bOK.Iconimage_Selected = null;
            this.bOK.IconMarginLeft = 0;
            this.bOK.IconMarginRight = 0;
            this.bOK.IconRightVisible = true;
            this.bOK.IconRightZoom = 0D;
            this.bOK.IconVisible = true;
            this.bOK.IconZoom = 90D;
            this.bOK.IsTab = false;
            this.bOK.Location = new System.Drawing.Point(219, 140);
            this.bOK.Margin = new System.Windows.Forms.Padding(5);
            this.bOK.Name = "bOK";
            this.bOK.Normalcolor = System.Drawing.Color.Transparent;
            this.bOK.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bOK.OnHoverTextColor = System.Drawing.Color.Black;
            this.bOK.selected = false;
            this.bOK.Size = new System.Drawing.Size(42, 39);
            this.bOK.TabIndex = 67;
            this.bOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bOK.Textcolor = System.Drawing.Color.Gray;
            this.bOK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // lDiaSem
            // 
            this.lDiaSem.AutoSize = true;
            this.lDiaSem.BackColor = System.Drawing.Color.Transparent;
            this.lDiaSem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiaSem.ForeColor = System.Drawing.Color.Black;
            this.lDiaSem.Location = new System.Drawing.Point(174, 41);
            this.lDiaSem.Name = "lDiaSem";
            this.lDiaSem.Size = new System.Drawing.Size(200, 25);
            this.lDiaSem.TabIndex = 66;
            this.lDiaSem.Text = "Thêm tên học kì mới:";
            // 
            // DiaSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 216);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbAddNew);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lDiaSem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DiaSem";
            this.Text = "DiaSem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiaSem_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbAddNew;
        private Bunifu.Framework.UI.BunifuFlatButton bExit;
        private Bunifu.Framework.UI.BunifuFlatButton bOK;
        private System.Windows.Forms.Label lDiaSem;
        private System.Windows.Forms.Label lbLogin;
    }
}