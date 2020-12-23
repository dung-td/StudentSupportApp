
namespace StudentSupportApp
{
    partial class AddLessonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLessonForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GradientPanelAddLesson = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbAddLesson = new System.Windows.Forms.Label();
            this.btnAddAL = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExitAL = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbxSubIDAL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxSubNaAL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxSemNaAL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbxTimeOrderBegin = new System.Windows.Forms.ComboBox();
            this.cbxDIWAL = new System.Windows.Forms.ComboBox();
            this.lbTimeOrAL = new System.Windows.Forms.Label();
            this.lbSubIDAL = new System.Windows.Forms.Label();
            this.lbSubNameAL = new System.Windows.Forms.Label();
            this.lbDIWAL = new System.Windows.Forms.Label();
            this.lbSemAL = new System.Windows.Forms.Label();
            this.cbxTimeOrderEnd = new System.Windows.Forms.ComboBox();
            this.lbFromTo = new System.Windows.Forms.Label();
            this.GradientPanelAddLesson.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GradientPanelAddLesson
            // 
            this.GradientPanelAddLesson.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanelAddLesson.BackgroundImage")));
            this.GradientPanelAddLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanelAddLesson.Controls.Add(this.lbAddLesson);
            this.GradientPanelAddLesson.Dock = System.Windows.Forms.DockStyle.Left;
            this.GradientPanelAddLesson.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddLesson.Location = new System.Drawing.Point(0, 0);
            this.GradientPanelAddLesson.Name = "GradientPanelAddLesson";
            this.GradientPanelAddLesson.Quality = 10;
            this.GradientPanelAddLesson.Size = new System.Drawing.Size(165, 569);
            this.GradientPanelAddLesson.TabIndex = 46;
            // 
            // lbAddLesson
            // 
            this.lbAddLesson.AutoSize = true;
            this.lbAddLesson.BackColor = System.Drawing.Color.Transparent;
            this.lbAddLesson.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddLesson.ForeColor = System.Drawing.Color.White;
            this.lbAddLesson.Location = new System.Drawing.Point(-10, 195);
            this.lbAddLesson.Name = "lbAddLesson";
            this.lbAddLesson.Size = new System.Drawing.Size(191, 180);
            this.lbAddLesson.TabIndex = 18;
            this.lbAddLesson.Text = "Thêm\r\ntiết học \r\nmới\r\n";
            this.lbAddLesson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddAL
            // 
            this.btnAddAL.ActiveBorderThickness = 1;
            this.btnAddAL.ActiveCornerRadius = 20;
            this.btnAddAL.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnAddAL.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddAL.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnAddAL.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddAL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAL.BackgroundImage")));
            this.btnAddAL.ButtonText = "Thêm";
            this.btnAddAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAL.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAddAL.IdleBorderThickness = 1;
            this.btnAddAL.IdleCornerRadius = 20;
            this.btnAddAL.IdleFillColor = System.Drawing.Color.White;
            this.btnAddAL.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnAddAL.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnAddAL.Location = new System.Drawing.Point(286, 485);
            this.btnAddAL.Margin = new System.Windows.Forms.Padding(8);
            this.btnAddAL.Name = "btnAddAL";
            this.btnAddAL.Size = new System.Drawing.Size(158, 62);
            this.btnAddAL.TabIndex = 45;
            this.btnAddAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAL.Click += new System.EventHandler(this.btnAddAL_Click);
            // 
            // btnExitAL
            // 
            this.btnExitAL.ActiveBorderThickness = 1;
            this.btnExitAL.ActiveCornerRadius = 20;
            this.btnExitAL.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnExitAL.ActiveForecolor = System.Drawing.Color.White;
            this.btnExitAL.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnExitAL.BackColor = System.Drawing.SystemColors.Control;
            this.btnExitAL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitAL.BackgroundImage")));
            this.btnExitAL.ButtonText = "Thoát";
            this.btnExitAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitAL.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExitAL.IdleBorderThickness = 1;
            this.btnExitAL.IdleCornerRadius = 20;
            this.btnExitAL.IdleFillColor = System.Drawing.Color.White;
            this.btnExitAL.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnExitAL.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnExitAL.Location = new System.Drawing.Point(542, 485);
            this.btnExitAL.Margin = new System.Windows.Forms.Padding(8);
            this.btnExitAL.Name = "btnExitAL";
            this.btnExitAL.Size = new System.Drawing.Size(158, 62);
            this.btnExitAL.TabIndex = 44;
            this.btnExitAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExitAL.Click += new System.EventHandler(this.btnExitAL_Click);
            // 
            // tbxSubIDAL
            // 
            this.tbxSubIDAL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSubIDAL.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubIDAL.ForeColor = System.Drawing.Color.Black;
            this.tbxSubIDAL.HintForeColor = System.Drawing.Color.Black;
            this.tbxSubIDAL.HintText = "Ví dụ: IT007,...";
            this.tbxSubIDAL.isPassword = false;
            this.tbxSubIDAL.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubIDAL.LineIdleColor = System.Drawing.Color.DimGray;
            this.tbxSubIDAL.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubIDAL.LineThickness = 4;
            this.tbxSubIDAL.Location = new System.Drawing.Point(382, 283);
            this.tbxSubIDAL.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbxSubIDAL.Name = "tbxSubIDAL";
            this.tbxSubIDAL.Size = new System.Drawing.Size(348, 101);
            this.tbxSubIDAL.TabIndex = 43;
            this.tbxSubIDAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxSubIDAL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSubIDAL_KeyDown);
            // 
            // tbxSubNaAL
            // 
            this.tbxSubNaAL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSubNaAL.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubNaAL.ForeColor = System.Drawing.Color.Black;
            this.tbxSubNaAL.HintForeColor = System.Drawing.Color.Black;
            this.tbxSubNaAL.HintText = "Ví dụ: Hệ điều hành,...";
            this.tbxSubNaAL.isPassword = false;
            this.tbxSubNaAL.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubNaAL.LineIdleColor = System.Drawing.Color.DimGray;
            this.tbxSubNaAL.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.tbxSubNaAL.LineThickness = 4;
            this.tbxSubNaAL.Location = new System.Drawing.Point(382, 184);
            this.tbxSubNaAL.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbxSubNaAL.Name = "tbxSubNaAL";
            this.tbxSubNaAL.Size = new System.Drawing.Size(348, 96);
            this.tbxSubNaAL.TabIndex = 42;
            this.tbxSubNaAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxSubNaAL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSubNaAL_KeyDown);
            // 
            // tbxSemNaAL
            // 
            this.tbxSemNaAL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSemNaAL.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSemNaAL.ForeColor = System.Drawing.Color.Black;
            this.tbxSemNaAL.HintForeColor = System.Drawing.Color.Black;
            this.tbxSemNaAL.HintText = "Ví dụ: HK1,...";
            this.tbxSemNaAL.isPassword = false;
            this.tbxSemNaAL.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.tbxSemNaAL.LineIdleColor = System.Drawing.Color.DimGray;
            this.tbxSemNaAL.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.tbxSemNaAL.LineThickness = 4;
            this.tbxSemNaAL.Location = new System.Drawing.Point(382, 0);
            this.tbxSemNaAL.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbxSemNaAL.Name = "tbxSemNaAL";
            this.tbxSemNaAL.Size = new System.Drawing.Size(348, 100);
            this.tbxSemNaAL.TabIndex = 41;
            this.tbxSemNaAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxSemNaAL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSemNaAL_KeyDown);
            // 
            // cbxTimeOrderBegin
            // 
            this.cbxTimeOrderBegin.BackColor = System.Drawing.Color.White;
            this.cbxTimeOrderBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimeOrderBegin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimeOrderBegin.FormattingEnabled = true;
            this.cbxTimeOrderBegin.Items.AddRange(new object[] {
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
            this.cbxTimeOrderBegin.Location = new System.Drawing.Point(386, 418);
            this.cbxTimeOrderBegin.Name = "cbxTimeOrderBegin";
            this.cbxTimeOrderBegin.Size = new System.Drawing.Size(115, 35);
            this.cbxTimeOrderBegin.TabIndex = 40;
            this.cbxTimeOrderBegin.SelectedIndexChanged += new System.EventHandler(this.cbxTimeOrderBegin_SelectedIndexChanged);
            this.cbxTimeOrderBegin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxTimeOrder_KeyDown);
            // 
            // cbxDIWAL
            // 
            this.cbxDIWAL.BackColor = System.Drawing.Color.White;
            this.cbxDIWAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDIWAL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDIWAL.FormattingEnabled = true;
            this.cbxDIWAL.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật"});
            this.cbxDIWAL.Location = new System.Drawing.Point(386, 138);
            this.cbxDIWAL.Name = "cbxDIWAL";
            this.cbxDIWAL.Size = new System.Drawing.Size(344, 35);
            this.cbxDIWAL.TabIndex = 39;
            this.cbxDIWAL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxDIWAL_KeyDown);
            // 
            // lbTimeOrAL
            // 
            this.lbTimeOrAL.AutoSize = true;
            this.lbTimeOrAL.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeOrAL.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeOrAL.ForeColor = System.Drawing.Color.Black;
            this.lbTimeOrAL.Location = new System.Drawing.Point(194, 423);
            this.lbTimeOrAL.Name = "lbTimeOrAL";
            this.lbTimeOrAL.Size = new System.Drawing.Size(98, 29);
            this.lbTimeOrAL.TabIndex = 38;
            this.lbTimeOrAL.Text = "Tiết học";
            // 
            // lbSubIDAL
            // 
            this.lbSubIDAL.AutoSize = true;
            this.lbSubIDAL.BackColor = System.Drawing.Color.Transparent;
            this.lbSubIDAL.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubIDAL.ForeColor = System.Drawing.Color.Black;
            this.lbSubIDAL.Location = new System.Drawing.Point(198, 335);
            this.lbSubIDAL.Name = "lbSubIDAL";
            this.lbSubIDAL.Size = new System.Drawing.Size(138, 29);
            this.lbSubIDAL.TabIndex = 37;
            this.lbSubIDAL.Text = "ID môn học";
            // 
            // lbSubNameAL
            // 
            this.lbSubNameAL.AutoSize = true;
            this.lbSubNameAL.BackColor = System.Drawing.Color.Transparent;
            this.lbSubNameAL.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubNameAL.ForeColor = System.Drawing.Color.Black;
            this.lbSubNameAL.Location = new System.Drawing.Point(194, 245);
            this.lbSubNameAL.Name = "lbSubNameAL";
            this.lbSubNameAL.Size = new System.Drawing.Size(152, 29);
            this.lbSubNameAL.TabIndex = 36;
            this.lbSubNameAL.Text = "Tên môn học";
            // 
            // lbDIWAL
            // 
            this.lbDIWAL.AutoSize = true;
            this.lbDIWAL.BackColor = System.Drawing.Color.Transparent;
            this.lbDIWAL.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDIWAL.ForeColor = System.Drawing.Color.Black;
            this.lbDIWAL.Location = new System.Drawing.Point(194, 140);
            this.lbDIWAL.Name = "lbDIWAL";
            this.lbDIWAL.Size = new System.Drawing.Size(182, 29);
            this.lbDIWAL.TabIndex = 35;
            this.lbDIWAL.Text = "Ngày trong tuần";
            // 
            // lbSemAL
            // 
            this.lbSemAL.AutoSize = true;
            this.lbSemAL.BackColor = System.Drawing.Color.Transparent;
            this.lbSemAL.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemAL.ForeColor = System.Drawing.Color.Black;
            this.lbSemAL.Location = new System.Drawing.Point(194, 58);
            this.lbSemAL.Name = "lbSemAL";
            this.lbSemAL.Size = new System.Drawing.Size(126, 29);
            this.lbSemAL.TabIndex = 34;
            this.lbSemAL.Text = "Tên học kì";
            // 
            // cbxTimeOrderEnd
            // 
            this.cbxTimeOrderEnd.BackColor = System.Drawing.Color.White;
            this.cbxTimeOrderEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimeOrderEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimeOrderEnd.FormattingEnabled = true;
            this.cbxTimeOrderEnd.Items.AddRange(new object[] {
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
            this.cbxTimeOrderEnd.Location = new System.Drawing.Point(615, 417);
            this.cbxTimeOrderEnd.Name = "cbxTimeOrderEnd";
            this.cbxTimeOrderEnd.Size = new System.Drawing.Size(115, 35);
            this.cbxTimeOrderEnd.TabIndex = 47;
            this.cbxTimeOrderEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxTimeOrderEnd_KeyDown);
            // 
            // lbFromTo
            // 
            this.lbFromTo.AutoSize = true;
            this.lbFromTo.BackColor = System.Drawing.Color.Transparent;
            this.lbFromTo.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromTo.ForeColor = System.Drawing.Color.Black;
            this.lbFromTo.Location = new System.Drawing.Point(537, 423);
            this.lbFromTo.Name = "lbFromTo";
            this.lbFromTo.Size = new System.Drawing.Size(51, 29);
            this.lbFromTo.TabIndex = 48;
            this.lbFromTo.Text = "đến";
            // 
            // AddLessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.lbFromTo);
            this.Controls.Add(this.cbxTimeOrderEnd);
            this.Controls.Add(this.GradientPanelAddLesson);
            this.Controls.Add(this.btnAddAL);
            this.Controls.Add(this.btnExitAL);
            this.Controls.Add(this.tbxSubIDAL);
            this.Controls.Add(this.tbxSubNaAL);
            this.Controls.Add(this.tbxSemNaAL);
            this.Controls.Add(this.cbxTimeOrderBegin);
            this.Controls.Add(this.cbxDIWAL);
            this.Controls.Add(this.lbTimeOrAL);
            this.Controls.Add(this.lbSubIDAL);
            this.Controls.Add(this.lbSubNameAL);
            this.Controls.Add(this.lbDIWAL);
            this.Controls.Add(this.lbSemAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddLessonForm";
            this.Text = "AddLessonForm";
            this.GradientPanelAddLesson.ResumeLayout(false);
            this.GradientPanelAddLesson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelAddLesson;
        private System.Windows.Forms.Label lbAddLesson;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddAL;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExitAL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxSubIDAL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxSubNaAL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxSemNaAL;
        private System.Windows.Forms.ComboBox cbxTimeOrderBegin;
        private System.Windows.Forms.ComboBox cbxDIWAL;
        private System.Windows.Forms.Label lbTimeOrAL;
        private System.Windows.Forms.Label lbSubIDAL;
        private System.Windows.Forms.Label lbSubNameAL;
        private System.Windows.Forms.Label lbDIWAL;
        private System.Windows.Forms.Label lbSemAL;
        private System.Windows.Forms.ComboBox cbxTimeOrderEnd;
        private System.Windows.Forms.Label lbFromTo;
    }
}