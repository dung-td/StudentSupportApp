
namespace StudentSupportApp
{
    partial class Documents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documents));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbYourDocs = new System.Windows.Forms.Label();
            this.GradientPanelDocuments = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModifiedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddDoc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOpenDoc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelDoc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaveDoc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExitDoc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GradientPanelDocuments.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbYourDocs
            // 
            this.lbYourDocs.AutoSize = true;
            this.lbYourDocs.BackColor = System.Drawing.Color.Transparent;
            this.lbYourDocs.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourDocs.ForeColor = System.Drawing.Color.White;
            this.lbYourDocs.Location = new System.Drawing.Point(15, 63);
            this.lbYourDocs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYourDocs.Name = "lbYourDocs";
            this.lbYourDocs.Size = new System.Drawing.Size(77, 172);
            this.lbYourDocs.TabIndex = 18;
            this.lbYourDocs.Text = "Tài\r\nliệu\r\ncủa\r\nbạn";
            this.lbYourDocs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradientPanelDocuments
            // 
            this.GradientPanelDocuments.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelDocuments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanelDocuments.BackgroundImage")));
            this.GradientPanelDocuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanelDocuments.Controls.Add(this.lbYourDocs);
            this.GradientPanelDocuments.Dock = System.Windows.Forms.DockStyle.Left;
            this.GradientPanelDocuments.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelDocuments.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelDocuments.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelDocuments.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelDocuments.Location = new System.Drawing.Point(0, 0);
            this.GradientPanelDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.GradientPanelDocuments.Name = "GradientPanelDocuments";
            this.GradientPanelDocuments.Quality = 10;
            this.GradientPanelDocuments.Size = new System.Drawing.Size(110, 307);
            this.GradientPanelDocuments.TabIndex = 47;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Type,
            this.ModifiedDate,
            this.Path});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(127, 24);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(462, 215);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FileName
            // 
            this.FileName.Text = "Tên";
            this.FileName.Width = 200;
            // 
            // Type
            // 
            this.Type.Text = "Loại file";
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.Text = "Ngày chỉnh sửa";
            this.ModifiedDate.Width = 100;
            // 
            // Path
            // 
            this.Path.Text = "Đường dẫn";
            this.Path.Width = 130;
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.ActiveBorderThickness = 1;
            this.btnAddDoc.ActiveCornerRadius = 20;
            this.btnAddDoc.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnAddDoc.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddDoc.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnAddDoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDoc.BackgroundImage")));
            this.btnAddDoc.ButtonText = "Thêm";
            this.btnAddDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDoc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAddDoc.IdleBorderThickness = 1;
            this.btnAddDoc.IdleCornerRadius = 20;
            this.btnAddDoc.IdleFillColor = System.Drawing.Color.White;
            this.btnAddDoc.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnAddDoc.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnAddDoc.Location = new System.Drawing.Point(127, 256);
            this.btnAddDoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(84, 40);
            this.btnAddDoc.TabIndex = 49;
            this.btnAddDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnOpenDoc
            // 
            this.btnOpenDoc.ActiveBorderThickness = 1;
            this.btnOpenDoc.ActiveCornerRadius = 20;
            this.btnOpenDoc.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenDoc.ActiveForecolor = System.Drawing.Color.White;
            this.btnOpenDoc.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenDoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenDoc.BackgroundImage")));
            this.btnOpenDoc.ButtonText = "Mở";
            this.btnOpenDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDoc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenDoc.IdleBorderThickness = 1;
            this.btnOpenDoc.IdleCornerRadius = 20;
            this.btnOpenDoc.IdleFillColor = System.Drawing.Color.White;
            this.btnOpenDoc.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnOpenDoc.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenDoc.Location = new System.Drawing.Point(221, 256);
            this.btnOpenDoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpenDoc.Name = "btnOpenDoc";
            this.btnOpenDoc.Size = new System.Drawing.Size(81, 40);
            this.btnOpenDoc.TabIndex = 50;
            this.btnOpenDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpenDoc.Click += new System.EventHandler(this.btnOpenDoc_Click);
            // 
            // btnDelDoc
            // 
            this.btnDelDoc.ActiveBorderThickness = 1;
            this.btnDelDoc.ActiveCornerRadius = 20;
            this.btnDelDoc.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnDelDoc.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelDoc.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnDelDoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelDoc.BackgroundImage")));
            this.btnDelDoc.ButtonText = "Xóa";
            this.btnDelDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelDoc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelDoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDelDoc.IdleBorderThickness = 1;
            this.btnDelDoc.IdleCornerRadius = 20;
            this.btnDelDoc.IdleFillColor = System.Drawing.Color.White;
            this.btnDelDoc.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnDelDoc.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnDelDoc.Location = new System.Drawing.Point(313, 256);
            this.btnDelDoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelDoc.Name = "btnDelDoc";
            this.btnDelDoc.Size = new System.Drawing.Size(84, 40);
            this.btnDelDoc.TabIndex = 51;
            this.btnDelDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelDoc.Click += new System.EventHandler(this.btnDelDoc_Click);
            // 
            // btnSaveDoc
            // 
            this.btnSaveDoc.ActiveBorderThickness = 1;
            this.btnSaveDoc.ActiveCornerRadius = 20;
            this.btnSaveDoc.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveDoc.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveDoc.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveDoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveDoc.BackgroundImage")));
            this.btnSaveDoc.ButtonText = "Lưu";
            this.btnSaveDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveDoc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveDoc.IdleBorderThickness = 1;
            this.btnSaveDoc.IdleCornerRadius = 20;
            this.btnSaveDoc.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveDoc.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnSaveDoc.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveDoc.Location = new System.Drawing.Point(409, 256);
            this.btnSaveDoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveDoc.Name = "btnSaveDoc";
            this.btnSaveDoc.Size = new System.Drawing.Size(84, 40);
            this.btnSaveDoc.TabIndex = 52;
            this.btnSaveDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveDoc.Click += new System.EventHandler(this.btnSaveDoc_Click);
            // 
            // btnExitDoc
            // 
            this.btnExitDoc.ActiveBorderThickness = 1;
            this.btnExitDoc.ActiveCornerRadius = 20;
            this.btnExitDoc.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnExitDoc.ActiveForecolor = System.Drawing.Color.White;
            this.btnExitDoc.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnExitDoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnExitDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitDoc.BackgroundImage")));
            this.btnExitDoc.ButtonText = "Thoát";
            this.btnExitDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitDoc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExitDoc.IdleBorderThickness = 1;
            this.btnExitDoc.IdleCornerRadius = 20;
            this.btnExitDoc.IdleFillColor = System.Drawing.Color.White;
            this.btnExitDoc.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnExitDoc.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnExitDoc.Location = new System.Drawing.Point(503, 256);
            this.btnExitDoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnExitDoc.Name = "btnExitDoc";
            this.btnExitDoc.Size = new System.Drawing.Size(84, 40);
            this.btnExitDoc.TabIndex = 53;
            this.btnExitDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExitDoc.Click += new System.EventHandler(this.btnExitDoc_Click);
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 307);
            this.Controls.Add(this.btnExitDoc);
            this.Controls.Add(this.btnSaveDoc);
            this.Controls.Add(this.btnDelDoc);
            this.Controls.Add(this.btnOpenDoc);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GradientPanelDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Documents";
            this.Text = "Documents";
            this.Load += new System.EventHandler(this.Documents_Load);
            this.GradientPanelDocuments.ResumeLayout(false);
            this.GradientPanelDocuments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelDocuments;
        private System.Windows.Forms.Label lbYourDocs;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader ModifiedDate;
        private System.Windows.Forms.ColumnHeader Path;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExitDoc;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveDoc;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelDoc;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOpenDoc;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddDoc;
    }
}