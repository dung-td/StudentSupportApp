
namespace StudentSupportApp
{
    partial class ScoreStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreStatistics));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStatis = new System.Windows.Forms.Label();
            this.chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
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
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.lbStatis);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 429);
            this.panel1.TabIndex = 71;
            // 
            // lbStatis
            // 
            this.lbStatis.AutoSize = true;
            this.lbStatis.BackColor = System.Drawing.Color.Transparent;
            this.lbStatis.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatis.ForeColor = System.Drawing.Color.White;
            this.lbStatis.Location = new System.Drawing.Point(5, 131);
            this.lbStatis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatis.Name = "lbStatis";
            this.lbStatis.Size = new System.Drawing.Size(119, 90);
            this.lbStatis.TabIndex = 21;
            this.lbStatis.Text = "Thống kê\r\nĐiểm số\r\n\r\n";
            this.lbStatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartStatistic
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend1);
            this.chartStatistic.Location = new System.Drawing.Point(137, -3);
            this.chartStatistic.Name = "chartStatistic";
            this.chartStatistic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartStatistic.Size = new System.Drawing.Size(701, 429);
            this.chartStatistic.TabIndex = 73;
            this.chartStatistic.Text = "chartScore";
            // 
            // bExit
            // 
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bExit.ActiveForecolor = System.Drawing.Color.White;
            this.bExit.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
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
            this.bExit.Location = new System.Drawing.Point(14, 273);
            this.bExit.Margin = new System.Windows.Forms.Padding(5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(105, 40);
            this.bExit.TabIndex = 45;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // ScoreStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 427);
            this.Controls.Add(this.chartStatistic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreStatistics";
            this.Text = "ScoreStatistics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScoreStatistics_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbStatis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
    }
}