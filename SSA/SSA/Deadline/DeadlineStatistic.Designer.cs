
namespace StudentSupportApp
{
    partial class DeadlineStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeadlineStatistic));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbStatis = new System.Windows.Forms.Label();
            this.chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Options = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTime = new System.Windows.Forms.ComboBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.cb1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.lbStatis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 600);
            this.panel1.TabIndex = 75;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bExit
            // 
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bExit.ActiveForecolor = System.Drawing.Color.White;
            this.bExit.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.ButtonText = "Thoát";
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bExit.IdleBorderThickness = 1;
            this.bExit.IdleCornerRadius = 20;
            this.bExit.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bExit.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.bExit.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.bExit.Location = new System.Drawing.Point(14, 363);
            this.bExit.Margin = new System.Windows.Forms.Padding(5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(105, 40);
            this.bExit.TabIndex = 45;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lbStatis
            // 
            this.lbStatis.AutoSize = true;
            this.lbStatis.BackColor = System.Drawing.Color.Transparent;
            this.lbStatis.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatis.ForeColor = System.Drawing.Color.White;
            this.lbStatis.Location = new System.Drawing.Point(17, 230);
            this.lbStatis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatis.Name = "lbStatis";
            this.lbStatis.Size = new System.Drawing.Size(102, 81);
            this.lbStatis.TabIndex = 21;
            this.lbStatis.Text = "Thống kê\r\nDeadline\r\n\r\n";
            this.lbStatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartStatistic
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea1);
            this.chartStatistic.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend1);
            this.chartStatistic.Location = new System.Drawing.Point(152, 0);
            this.chartStatistic.Name = "chartStatistic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Số lượng deadline";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Số deadline đã hoàn thành";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Số deadline chưa hoàn thành";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartStatistic.Series.Add(series1);
            this.chartStatistic.Series.Add(series2);
            this.chartStatistic.Series.Add(series3);
            this.chartStatistic.Size = new System.Drawing.Size(748, 600);
            this.chartStatistic.TabIndex = 76;
            this.chartStatistic.Text = "chart1";
            // 
            // Options
            // 
            this.Options.Controls.Add(this.label1);
            this.Options.Controls.Add(this.cbbTime);
            this.Options.Controls.Add(this.lb2);
            this.Options.Controls.Add(this.cb1);
            this.Options.Controls.Add(this.cb2);
            this.Options.Controls.Add(this.lb1);
            this.Options.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(682, 319);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(189, 233);
            this.Options.TabIndex = 83;
            this.Options.TabStop = false;
            this.Options.Text = "Tùy chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "Khoảng thời gian";
            // 
            // cbbTime
            // 
            this.cbbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Items.AddRange(new object[] {
            "Ngày qua",
            "Tuần qua",
            "Tháng qua (Mặc định)",
            "Năm qua"});
            this.cbbTime.Location = new System.Drawing.Point(34, 73);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(126, 22);
            this.cbbTime.TabIndex = 82;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(42, 204);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(147, 15);
            this.lb2.TabIndex = 81;
            this.lb2.Text = "Deadline chưa hoàn thành";
            // 
            // cb1
            // 
            this.cb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb1.Checked = true;
            this.cb1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb1.ForeColor = System.Drawing.Color.White;
            this.cb1.Location = new System.Drawing.Point(6, 160);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(20, 20);
            this.cb1.TabIndex = 76;
            this.cb1.OnChange += new System.EventHandler(this.cb1_OnChange);
            // 
            // cb2
            // 
            this.cb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb2.Checked = true;
            this.cb2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb2.ForeColor = System.Drawing.Color.White;
            this.cb2.Location = new System.Drawing.Point(6, 199);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(20, 20);
            this.cb2.TabIndex = 79;
            this.cb2.OnChange += new System.EventHandler(this.cb2_OnChange);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(42, 165);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(118, 15);
            this.lb1.TabIndex = 78;
            this.lb1.Text = "Deadline hoàn thành";
            // 
            // DeadlineStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.chartStatistic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeadlineStatistic";
            this.Text = "DeadlineStatistic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
        private System.Windows.Forms.Label lbStatis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTime;
        private System.Windows.Forms.Label lb2;
        private Bunifu.Framework.UI.BunifuCheckbox cb1;
        private Bunifu.Framework.UI.BunifuCheckbox cb2;
        private System.Windows.Forms.Label lb1;
    }
}