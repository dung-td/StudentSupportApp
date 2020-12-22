
namespace StudentSupportApp
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GradientPanelNote = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExitNote = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaveNote = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbYourNote = new System.Windows.Forms.Label();
            this.tbxNoteName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rtbDetail = new System.Windows.Forms.RichTextBox();
            this.GradientPanelNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GradientPanelNote
            // 
            this.GradientPanelNote.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanelNote.BackgroundImage")));
            this.GradientPanelNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanelNote.Controls.Add(this.btnExitNote);
            this.GradientPanelNote.Controls.Add(this.btnSaveNote);
            this.GradientPanelNote.Controls.Add(this.lbYourNote);
            this.GradientPanelNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.GradientPanelNote.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelNote.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelNote.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelNote.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelNote.Location = new System.Drawing.Point(0, 0);
            this.GradientPanelNote.MinimumSize = new System.Drawing.Size(206, 692);
            this.GradientPanelNote.Name = "GradientPanelNote";
            this.GradientPanelNote.Quality = 10;
            this.GradientPanelNote.Size = new System.Drawing.Size(206, 692);
            this.GradientPanelNote.TabIndex = 49;
            // 
            // btnExitNote
            // 
            this.btnExitNote.ActiveBorderThickness = 1;
            this.btnExitNote.ActiveCornerRadius = 20;
            this.btnExitNote.ActiveFillColor = System.Drawing.Color.White;
            this.btnExitNote.ActiveForecolor = System.Drawing.Color.LightCoral;
            this.btnExitNote.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnExitNote.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExitNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitNote.BackgroundImage")));
            this.btnExitNote.ButtonText = "Thoát";
            this.btnExitNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitNote.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExitNote.IdleBorderThickness = 1;
            this.btnExitNote.IdleCornerRadius = 20;
            this.btnExitNote.IdleFillColor = System.Drawing.Color.White;
            this.btnExitNote.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnExitNote.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnExitNote.Location = new System.Drawing.Point(32, 460);
            this.btnExitNote.Margin = new System.Windows.Forms.Padding(8);
            this.btnExitNote.Name = "btnExitNote";
            this.btnExitNote.Size = new System.Drawing.Size(143, 88);
            this.btnExitNote.TabIndex = 54;
            this.btnExitNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExitNote.Click += new System.EventHandler(this.btnExitNote_Click);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.ActiveBorderThickness = 1;
            this.btnSaveNote.ActiveCornerRadius = 20;
            this.btnSaveNote.ActiveFillColor = System.Drawing.Color.White;
            this.btnSaveNote.ActiveForecolor = System.Drawing.Color.LightCoral;
            this.btnSaveNote.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveNote.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveNote.BackgroundImage")));
            this.btnSaveNote.ButtonText = "Lưu";
            this.btnSaveNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNote.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveNote.IdleBorderThickness = 1;
            this.btnSaveNote.IdleCornerRadius = 20;
            this.btnSaveNote.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveNote.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btnSaveNote.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveNote.Location = new System.Drawing.Point(32, 357);
            this.btnSaveNote.Margin = new System.Windows.Forms.Padding(8);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(143, 88);
            this.btnSaveNote.TabIndex = 53;
            this.btnSaveNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // lbYourNote
            // 
            this.lbYourNote.AutoSize = true;
            this.lbYourNote.BackColor = System.Drawing.Color.Transparent;
            this.lbYourNote.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourNote.ForeColor = System.Drawing.Color.White;
            this.lbYourNote.Location = new System.Drawing.Point(42, 146);
            this.lbYourNote.Name = "lbYourNote";
            this.lbYourNote.Size = new System.Drawing.Size(114, 116);
            this.lbYourNote.TabIndex = 18;
            this.lbYourNote.Text = "Ghi\r\nchú";
            this.lbYourNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxNoteName
            // 
            this.tbxNoteName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNoteName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNoteName.ForeColor = System.Drawing.Color.Black;
            this.tbxNoteName.HintForeColor = System.Drawing.Color.Black;
            this.tbxNoteName.HintText = "Tên ghi chú";
            this.tbxNoteName.isPassword = false;
            this.tbxNoteName.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.tbxNoteName.LineIdleColor = System.Drawing.Color.DimGray;
            this.tbxNoteName.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.tbxNoteName.LineThickness = 3;
            this.tbxNoteName.Location = new System.Drawing.Point(224, 0);
            this.tbxNoteName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxNoteName.Name = "tbxNoteName";
            this.tbxNoteName.Size = new System.Drawing.Size(356, 78);
            this.tbxNoteName.TabIndex = 52;
            this.tbxNoteName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rtbDetail
            // 
            this.rtbDetail.AcceptsTab = true;
            this.rtbDetail.EnableAutoDragDrop = true;
            this.rtbDetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetail.Location = new System.Drawing.Point(206, 89);
            this.rtbDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDetail.Name = "rtbDetail";
            this.rtbDetail.Size = new System.Drawing.Size(652, 495);
            this.rtbDetail.TabIndex = 51;
            this.rtbDetail.Text = "";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 584);
            this.ControlBox = false;
            this.Controls.Add(this.tbxNoteName);
            this.Controls.Add(this.rtbDetail);
            this.Controls.Add(this.GradientPanelNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteForm";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.SizeChanged += new System.EventHandler(this.NoteForm_SizeChanged);
            this.GradientPanelNote.ResumeLayout(false);
            this.GradientPanelNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxNoteName;
        private System.Windows.Forms.RichTextBox rtbDetail;
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelNote;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExitNote;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveNote;
        private System.Windows.Forms.Label lbYourNote;
    }
}