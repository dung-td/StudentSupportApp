
namespace StudentSupportApp
{
    partial class ModLessonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModLessonForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSaveML = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExitML = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbxSubIDML = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxSubNaML = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxSemNaML = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbxTimeOrderM = new System.Windows.Forms.ComboBox();
            this.cbxDIWML = new System.Windows.Forms.ComboBox();
            this.lbTimeOrML = new System.Windows.Forms.Label();
            this.lbSubIDML = new System.Windows.Forms.Label();
            this.lbSubNameML = new System.Windows.Forms.Label();
            this.lbDIWML = new System.Windows.Forms.Label();
            this.lbSemML = new System.Windows.Forms.Label();
            this.GradientPanelAddLesson = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbModLesson = new System.Windows.Forms.Label();
            this.GradientPanelAddLesson.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnSaveML
            // 
            this.btnSaveML.ActiveBorderThickness = 1;
            this.btnSaveML.ActiveCornerRadius = 20;
            this.btnSaveML.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveML.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveML.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveML.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveML.BackgroundImage")));
            this.btnSaveML.ButtonText = "Lưu";
            this.btnSaveML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveML.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveML.IdleBorderThickness = 1;
            this.btnSaveML.IdleCornerRadius = 20;
            this.btnSaveML.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveML.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnSaveML.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveML.Location = new System.Drawing.Point(278, 393);
            this.btnSaveML.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveML.Name = "btnSaveML";
            this.btnSaveML.Size = new System.Drawing.Size(158, 62);
            this.btnSaveML.TabIndex = 59;
            this.btnSaveML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveML.Click += new System.EventHandler(this.btnSaveML_Click);
            // 
            // btnExitML
            // 
            this.btnExitML.ActiveBorderThickness = 1;
            this.btnExitML.ActiveCornerRadius = 20;
            this.btnExitML.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnExitML.ActiveForecolor = System.Drawing.Color.White;
            this.btnExitML.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnExitML.BackColor = System.Drawing.SystemColors.Control;
            this.btnExitML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitML.BackgroundImage")));
            this.btnExitML.ButtonText = "Thoát";
            this.btnExitML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitML.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExitML.IdleBorderThickness = 1;
            this.btnExitML.IdleCornerRadius = 20;
            this.btnExitML.IdleFillColor = System.Drawing.Color.White;
            this.btnExitML.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnExitML.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnExitML.Location = new System.Drawing.Point(524, 393);
            this.btnExitML.Margin = new System.Windows.Forms.Padding(5);
            this.btnExitML.Name = "btnExitML";
            this.btnExitML.Size = new System.Drawing.Size(158, 62);
            this.btnExitML.TabIndex = 58;
            this.btnExitML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExitML.Click += new System.EventHandler(this.btnExitML_Click);
            // 
            // tbxSubIDML
            // 
            this.tbxSubIDML.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSubIDML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubIDML.ForeColor = System.Drawing.Color.Black;
            this.tbxSubIDML.HintForeColor = System.Drawing.Color.Black;
            this.tbxSubIDML.HintText = "";
            this.tbxSubIDML.isPassword = false;
            this.tbxSubIDML.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubIDML.LineIdleColor = System.Drawing.Color.DimGray;
            this.tbxSubIDML.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubIDML.LineThickness = 3;
            this.tbxSubIDML.Location = new System.Drawing.Point(375, 229);
            this.tbxSubIDML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSubIDML.Name = "tbxSubIDML";
            this.tbxSubIDML.Size = new System.Drawing.Size(348, 70);
            this.tbxSubIDML.TabIndex = 57;
            this.tbxSubIDML.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxSubIDML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSubIDML_KeyDown);
            // 
            // tbxSubNaML
            // 
            this.tbxSubNaML.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSubNaML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubNaML.ForeColor = System.Drawing.Color.Black;
            this.tbxSubNaML.HintForeColor = System.Drawing.Color.Black;
            this.tbxSubNaML.HintText = "";
            this.tbxSubNaML.isPassword = false;
            this.tbxSubNaML.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubNaML.LineIdleColor = System.Drawing.Color.DimGray;
            this.tbxSubNaML.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubNaML.LineThickness = 3;
            this.tbxSubNaML.Location = new System.Drawing.Point(375, 144);
            this.tbxSubNaML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSubNaML.Name = "tbxSubNaML";
            this.tbxSubNaML.Size = new System.Drawing.Size(348, 75);
            this.tbxSubNaML.TabIndex = 56;
            this.tbxSubNaML.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxSubNaML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSubNaML_KeyDown);
            // 
            // tbxSemNaML
            // 
            this.tbxSemNaML.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSemNaML.Enabled = false;
            this.tbxSemNaML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSemNaML.ForeColor = System.Drawing.Color.Black;
            this.tbxSemNaML.HintForeColor = System.Drawing.Color.Black;
            this.tbxSemNaML.HintText = "";
            this.tbxSemNaML.isPassword = false;
            this.tbxSemNaML.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.tbxSemNaML.LineIdleColor = System.Drawing.Color.DimGray;
            this.tbxSemNaML.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.tbxSemNaML.LineThickness = 3;
            this.tbxSemNaML.Location = new System.Drawing.Point(375, 0);
            this.tbxSemNaML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSemNaML.Name = "tbxSemNaML";
            this.tbxSemNaML.Size = new System.Drawing.Size(348, 83);
            this.tbxSemNaML.TabIndex = 55;
            this.tbxSemNaML.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxSemNaML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSemNaML_KeyDown);
            // 
            // cbxTimeOrderM
            // 
            this.cbxTimeOrderM.BackColor = System.Drawing.Color.White;
            this.cbxTimeOrderM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimeOrderM.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimeOrderM.FormattingEnabled = true;
            this.cbxTimeOrderM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxTimeOrderM.Location = new System.Drawing.Point(375, 343);
            this.cbxTimeOrderM.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTimeOrderM.Name = "cbxTimeOrderM";
            this.cbxTimeOrderM.Size = new System.Drawing.Size(344, 33);
            this.cbxTimeOrderM.TabIndex = 54;
            this.cbxTimeOrderM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxTimeOrderM_KeyDown);
            // 
            // cbxDIWML
            // 
            this.cbxDIWML.BackColor = System.Drawing.Color.White;
            this.cbxDIWML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDIWML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDIWML.FormattingEnabled = true;
            this.cbxDIWML.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật"});
            this.cbxDIWML.Location = new System.Drawing.Point(379, 111);
            this.cbxDIWML.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDIWML.Name = "cbxDIWML";
            this.cbxDIWML.Size = new System.Drawing.Size(344, 33);
            this.cbxDIWML.TabIndex = 53;
            this.cbxDIWML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxDIWML_KeyDown);
            // 
            // lbTimeOrML
            // 
            this.lbTimeOrML.AutoSize = true;
            this.lbTimeOrML.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeOrML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeOrML.ForeColor = System.Drawing.Color.Black;
            this.lbTimeOrML.Location = new System.Drawing.Point(189, 343);
            this.lbTimeOrML.Name = "lbTimeOrML";
            this.lbTimeOrML.Size = new System.Drawing.Size(90, 25);
            this.lbTimeOrML.TabIndex = 52;
            this.lbTimeOrML.Text = "Tiết học";
            // 
            // lbSubIDML
            // 
            this.lbSubIDML.AutoSize = true;
            this.lbSubIDML.BackColor = System.Drawing.Color.Transparent;
            this.lbSubIDML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubIDML.ForeColor = System.Drawing.Color.Black;
            this.lbSubIDML.Location = new System.Drawing.Point(189, 268);
            this.lbSubIDML.Name = "lbSubIDML";
            this.lbSubIDML.Size = new System.Drawing.Size(133, 25);
            this.lbSubIDML.TabIndex = 51;
            this.lbSubIDML.Text = "ID môn học";
            // 
            // lbSubNameML
            // 
            this.lbSubNameML.AutoSize = true;
            this.lbSubNameML.BackColor = System.Drawing.Color.Transparent;
            this.lbSubNameML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubNameML.ForeColor = System.Drawing.Color.Black;
            this.lbSubNameML.Location = new System.Drawing.Point(189, 188);
            this.lbSubNameML.Name = "lbSubNameML";
            this.lbSubNameML.Size = new System.Drawing.Size(149, 25);
            this.lbSubNameML.TabIndex = 50;
            this.lbSubNameML.Text = "Tên môn học";
            // 
            // lbDIWML
            // 
            this.lbDIWML.AutoSize = true;
            this.lbDIWML.BackColor = System.Drawing.Color.Transparent;
            this.lbDIWML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDIWML.ForeColor = System.Drawing.Color.Black;
            this.lbDIWML.Location = new System.Drawing.Point(189, 114);
            this.lbDIWML.Name = "lbDIWML";
            this.lbDIWML.Size = new System.Drawing.Size(185, 25);
            this.lbDIWML.TabIndex = 49;
            this.lbDIWML.Text = "Ngày trong tuần";
            // 
            // lbSemML
            // 
            this.lbSemML.AutoSize = true;
            this.lbSemML.BackColor = System.Drawing.Color.Transparent;
            this.lbSemML.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemML.ForeColor = System.Drawing.Color.Black;
            this.lbSemML.Location = new System.Drawing.Point(189, 51);
            this.lbSemML.Name = "lbSemML";
            this.lbSemML.Size = new System.Drawing.Size(117, 25);
            this.lbSemML.TabIndex = 48;
            this.lbSemML.Text = "Tên học kì";
            // 
            // GradientPanelAddLesson
            // 
            this.GradientPanelAddLesson.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanelAddLesson.BackgroundImage")));
            this.GradientPanelAddLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanelAddLesson.Controls.Add(this.lbModLesson);
            this.GradientPanelAddLesson.Dock = System.Windows.Forms.DockStyle.Left;
            this.GradientPanelAddLesson.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.Location = new System.Drawing.Point(0, 0);
            this.GradientPanelAddLesson.Margin = new System.Windows.Forms.Padding(2);
            this.GradientPanelAddLesson.Name = "GradientPanelAddLesson";
            this.GradientPanelAddLesson.Quality = 10;
            this.GradientPanelAddLesson.Size = new System.Drawing.Size(165, 469);
            this.GradientPanelAddLesson.TabIndex = 47;
            // 
            // lbModLesson
            // 
            this.lbModLesson.AutoSize = true;
            this.lbModLesson.BackColor = System.Drawing.Color.Transparent;
            this.lbModLesson.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModLesson.ForeColor = System.Drawing.Color.White;
            this.lbModLesson.Location = new System.Drawing.Point(16, 148);
            this.lbModLesson.Name = "lbModLesson";
            this.lbModLesson.Size = new System.Drawing.Size(135, 165);
            this.lbModLesson.TabIndex = 18;
            this.lbModLesson.Text = "Sửa\r\nmôn \r\nhọc\r\n";
            // 
            // ModLessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnSaveML);
            this.Controls.Add(this.btnExitML);
            this.Controls.Add(this.tbxSubIDML);
            this.Controls.Add(this.tbxSubNaML);
            this.Controls.Add(this.tbxSemNaML);
            this.Controls.Add(this.cbxTimeOrderM);
            this.Controls.Add(this.cbxDIWML);
            this.Controls.Add(this.lbTimeOrML);
            this.Controls.Add(this.lbSubIDML);
            this.Controls.Add(this.lbSubNameML);
            this.Controls.Add(this.lbDIWML);
            this.Controls.Add(this.lbSemML);
            this.Controls.Add(this.GradientPanelAddLesson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModLessonForm";
            this.Text = "ModLessonForm";
            this.GradientPanelAddLesson.ResumeLayout(false);
            this.GradientPanelAddLesson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveML;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExitML;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxSubIDML;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxSubNaML;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxSemNaML;
        private System.Windows.Forms.ComboBox cbxTimeOrderM;
        private System.Windows.Forms.ComboBox cbxDIWML;
        private System.Windows.Forms.Label lbTimeOrML;
        private System.Windows.Forms.Label lbSubIDML;
        private System.Windows.Forms.Label lbSubNameML;
        private System.Windows.Forms.Label lbDIWML;
        private System.Windows.Forms.Label lbSemML;
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelAddLesson;
        private System.Windows.Forms.Label lbModLesson;
    }
}