
namespace StudentSupportApp
{
    partial class AddDeadline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeadline));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.btbMinute = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btbHour = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelTimeSubmit = new System.Windows.Forms.Label();
            this.btbSubID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelSubID = new System.Windows.Forms.Label();
            this.btbSubject = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btbDetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btbStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label_ID = new System.Windows.Forms.Label();
            this.bDateTime = new Bunifu.Framework.UI.BunifuDatepicker();
            this.labelDateSubmit = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.tbAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GradientPanelAddDeadline = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbAddLesson = new System.Windows.Forms.Label();
            this.labelTimeFormat = new System.Windows.Forms.Label();
            this.GradientPanelAddDeadline.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBoxTime.Location = new System.Drawing.Point(415, 276);
            this.comboBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(69, 21);
            this.comboBoxTime.TabIndex = 24;
            // 
            // btbMinute
            // 
            this.btbMinute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btbMinute.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbMinute.HintForeColor = System.Drawing.Color.Empty;
            this.btbMinute.HintText = "";
            this.btbMinute.isPassword = false;
            this.btbMinute.LineFocusedColor = System.Drawing.Color.Blue;
            this.btbMinute.LineIdleColor = System.Drawing.Color.Gray;
            this.btbMinute.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btbMinute.LineThickness = 2;
            this.btbMinute.Location = new System.Drawing.Point(339, 242);
            this.btbMinute.Margin = new System.Windows.Forms.Padding(4);
            this.btbMinute.Name = "btbMinute";
            this.btbMinute.Size = new System.Drawing.Size(26, 51);
            this.btbMinute.TabIndex = 23;
            this.btbMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btbMinute.OnValueChanged += new System.EventHandler(this.btbMinute_OnValueChanged);
            // 
            // btbHour
            // 
            this.btbHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btbHour.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbHour.HintForeColor = System.Drawing.Color.Empty;
            this.btbHour.HintText = "";
            this.btbHour.isPassword = false;
            this.btbHour.LineFocusedColor = System.Drawing.Color.Blue;
            this.btbHour.LineIdleColor = System.Drawing.Color.Gray;
            this.btbHour.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btbHour.LineThickness = 2;
            this.btbHour.Location = new System.Drawing.Point(262, 242);
            this.btbHour.Margin = new System.Windows.Forms.Padding(4);
            this.btbHour.Name = "btbHour";
            this.btbHour.Size = new System.Drawing.Size(26, 51);
            this.btbHour.TabIndex = 22;
            this.btbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btbHour.OnValueChanged += new System.EventHandler(this.btbHour_OnValueChanged);
            // 
            // labelTimeSubmit
            // 
            this.labelTimeSubmit.AutoSize = true;
            this.labelTimeSubmit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSubmit.Location = new System.Drawing.Point(154, 276);
            this.labelTimeSubmit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeSubmit.Name = "labelTimeSubmit";
            this.labelTimeSubmit.Size = new System.Drawing.Size(66, 20);
            this.labelTimeSubmit.TabIndex = 21;
            this.labelTimeSubmit.Text = "Giờ nộp";
            // 
            // btbSubID
            // 
            this.btbSubID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btbSubID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSubID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbSubID.HintForeColor = System.Drawing.Color.Empty;
            this.btbSubID.HintText = "";
            this.btbSubID.isPassword = false;
            this.btbSubID.LineFocusedColor = System.Drawing.Color.Blue;
            this.btbSubID.LineIdleColor = System.Drawing.Color.Gray;
            this.btbSubID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btbSubID.LineThickness = 2;
            this.btbSubID.Location = new System.Drawing.Point(262, 7);
            this.btbSubID.Margin = new System.Windows.Forms.Padding(4);
            this.btbSubID.Name = "btbSubID";
            this.btbSubID.Size = new System.Drawing.Size(335, 51);
            this.btbSubID.TabIndex = 20;
            this.btbSubID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btbSubID.OnValueChanged += new System.EventHandler(this.btbSubID_OnValueChanged);
            // 
            // labelSubID
            // 
            this.labelSubID.AutoSize = true;
            this.labelSubID.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubID.Location = new System.Drawing.Point(155, 40);
            this.labelSubID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubID.Name = "labelSubID";
            this.labelSubID.Size = new System.Drawing.Size(93, 20);
            this.labelSubID.TabIndex = 19;
            this.labelSubID.Text = "ID môn học";
            // 
            // btbSubject
            // 
            this.btbSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btbSubject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbSubject.HintForeColor = System.Drawing.Color.Empty;
            this.btbSubject.HintText = "";
            this.btbSubject.isPassword = false;
            this.btbSubject.LineFocusedColor = System.Drawing.Color.Blue;
            this.btbSubject.LineIdleColor = System.Drawing.Color.Gray;
            this.btbSubject.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btbSubject.LineThickness = 2;
            this.btbSubject.Location = new System.Drawing.Point(262, 70);
            this.btbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btbSubject.Name = "btbSubject";
            this.btbSubject.Size = new System.Drawing.Size(335, 51);
            this.btbSubject.TabIndex = 18;
            this.btbSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btbDetails
            // 
            this.btbDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btbDetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbDetails.HintForeColor = System.Drawing.Color.Empty;
            this.btbDetails.HintText = "";
            this.btbDetails.isPassword = false;
            this.btbDetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.btbDetails.LineIdleColor = System.Drawing.Color.Gray;
            this.btbDetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btbDetails.LineThickness = 2;
            this.btbDetails.Location = new System.Drawing.Point(262, 131);
            this.btbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btbDetails.Name = "btbDetails";
            this.btbDetails.Size = new System.Drawing.Size(335, 51);
            this.btbDetails.TabIndex = 17;
            this.btbDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btbStatus
            // 
            this.btbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btbStatus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbStatus.HintForeColor = System.Drawing.Color.Empty;
            this.btbStatus.HintText = "";
            this.btbStatus.isPassword = false;
            this.btbStatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.btbStatus.LineIdleColor = System.Drawing.Color.Gray;
            this.btbStatus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btbStatus.LineThickness = 2;
            this.btbStatus.Location = new System.Drawing.Point(262, 299);
            this.btbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btbStatus.Name = "btbStatus";
            this.btbStatus.Size = new System.Drawing.Size(103, 51);
            this.btbStatus.TabIndex = 16;
            this.btbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(251, 19);
            this.label_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(0, 19);
            this.label_ID.TabIndex = 13;
            // 
            // bDateTime
            // 
            this.bDateTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.bDateTime.BorderRadius = 0;
            this.bDateTime.ForeColor = System.Drawing.Color.White;
            this.bDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bDateTime.FormatCustom = null;
            this.bDateTime.Location = new System.Drawing.Point(262, 214);
            this.bDateTime.Name = "bDateTime";
            this.bDateTime.Size = new System.Drawing.Size(335, 22);
            this.bDateTime.TabIndex = 12;
            this.bDateTime.Value = new System.DateTime(2020, 11, 23, 18, 17, 39, 367);
            // 
            // labelDateSubmit
            // 
            this.labelDateSubmit.AutoSize = true;
            this.labelDateSubmit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateSubmit.Location = new System.Drawing.Point(155, 218);
            this.labelDateSubmit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateSubmit.Name = "labelDateSubmit";
            this.labelDateSubmit.Size = new System.Drawing.Size(80, 20);
            this.labelDateSubmit.TabIndex = 11;
            this.labelDateSubmit.Text = "Ngày nộp";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(154, 325);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(77, 20);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Trạng thái";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(155, 164);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(58, 20);
            this.labelDetails.TabIndex = 5;
            this.labelDetails.Text = "Chi tiết";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(155, 103);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(75, 20);
            this.labelSubject.TabIndex = 4;
            this.labelSubject.Text = "Môn học";
            // 
            // tbAdd
            // 
            this.tbAdd.ActiveBorderThickness = 1;
            this.tbAdd.ActiveCornerRadius = 20;
            this.tbAdd.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.tbAdd.ActiveForecolor = System.Drawing.Color.White;
            this.tbAdd.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.tbAdd.BackColor = System.Drawing.SystemColors.Control;
            this.tbAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbAdd.BackgroundImage")));
            this.tbAdd.ButtonText = "Thêm";
            this.tbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbAdd.IdleBorderThickness = 1;
            this.tbAdd.IdleCornerRadius = 20;
            this.tbAdd.IdleFillColor = System.Drawing.Color.White;
            this.tbAdd.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.tbAdd.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.tbAdd.Location = new System.Drawing.Point(255, 367);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(101, 47);
            this.tbAdd.TabIndex = 3;
            this.tbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // tbCancel
            // 
            this.tbCancel.ActiveBorderThickness = 1;
            this.tbCancel.ActiveCornerRadius = 20;
            this.tbCancel.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.tbCancel.ActiveForecolor = System.Drawing.Color.White;
            this.tbCancel.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.tbCancel.BackColor = System.Drawing.SystemColors.Control;
            this.tbCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbCancel.BackgroundImage")));
            this.tbCancel.ButtonText = "Huỷ";
            this.tbCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbCancel.IdleBorderThickness = 1;
            this.tbCancel.IdleCornerRadius = 20;
            this.tbCancel.IdleFillColor = System.Drawing.Color.White;
            this.tbCancel.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.tbCancel.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.tbCancel.Location = new System.Drawing.Point(415, 369);
            this.tbCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(101, 46);
            this.tbCancel.TabIndex = 4;
            this.tbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbCancel.Click += new System.EventHandler(this.tbCancel_Click);
            // 
            // GradientPanelAddDeadline
            // 
            this.GradientPanelAddDeadline.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanelAddDeadline.BackgroundImage")));
            this.GradientPanelAddDeadline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanelAddDeadline.Controls.Add(this.lbAddLesson);
            this.GradientPanelAddDeadline.Dock = System.Windows.Forms.DockStyle.Left;
            this.GradientPanelAddDeadline.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelAddDeadline.Location = new System.Drawing.Point(0, 0);
            this.GradientPanelAddDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.GradientPanelAddDeadline.Name = "GradientPanelAddDeadline";
            this.GradientPanelAddDeadline.Quality = 10;
            this.GradientPanelAddDeadline.Size = new System.Drawing.Size(139, 434);
            this.GradientPanelAddDeadline.TabIndex = 47;
            // 
            // lbAddLesson
            // 
            this.lbAddLesson.AutoSize = true;
            this.lbAddLesson.BackColor = System.Drawing.Color.Transparent;
            this.lbAddLesson.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddLesson.ForeColor = System.Drawing.Color.White;
            this.lbAddLesson.Location = new System.Drawing.Point(-7, 175);
            this.lbAddLesson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddLesson.Name = "lbAddLesson";
            this.lbAddLesson.Size = new System.Drawing.Size(149, 74);
            this.lbAddLesson.TabIndex = 18;
            this.lbAddLesson.Text = "Thêm\r\nDeadline";
            this.lbAddLesson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeFormat
            // 
            this.labelTimeFormat.AutoSize = true;
            this.labelTimeFormat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeFormat.ForeColor = System.Drawing.Color.Red;
            this.labelTimeFormat.Location = new System.Drawing.Point(494, 278);
            this.labelTimeFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeFormat.Name = "labelTimeFormat";
            this.labelTimeFormat.Size = new System.Drawing.Size(110, 17);
            this.labelTimeFormat.TabIndex = 48;
            this.labelTimeFormat.Text = "Sai định dạng giờ!";
            this.labelTimeFormat.Visible = false;
            // 
            // AddDeadline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 434);
            this.Controls.Add(this.labelTimeFormat);
            this.Controls.Add(this.GradientPanelAddDeadline);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btbStatus);
            this.Controls.Add(this.labelSubID);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.tbCancel);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.btbSubject);
            this.Controls.Add(this.btbDetails);
            this.Controls.Add(this.btbMinute);
            this.Controls.Add(this.btbSubID);
            this.Controls.Add(this.labelDateSubmit);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.btbHour);
            this.Controls.Add(this.labelTimeSubmit);
            this.Controls.Add(this.bDateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDeadline";
            this.Text = "AddDeadline";
            this.GradientPanelAddDeadline.ResumeLayout(false);
            this.GradientPanelAddDeadline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btbSubject;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btbDetails;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btbStatus;
        private System.Windows.Forms.Label label_ID;
        private Bunifu.Framework.UI.BunifuDatepicker bDateTime;
        private System.Windows.Forms.Label labelDateSubmit;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelSubject;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btbSubID;
        private System.Windows.Forms.Label labelSubID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btbHour;
        private System.Windows.Forms.Label labelTimeSubmit;
        private Bunifu.Framework.UI.BunifuThinButton2 tbCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 tbAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btbMinute;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelAddDeadline;
        private System.Windows.Forms.Label lbAddLesson;
        private System.Windows.Forms.Label labelTimeFormat;
    }
}