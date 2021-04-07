
namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    partial class ThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNamm = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNamm)).BeginInit();
            this.SuspendLayout();
            // 
            // chartThang
            // 
            this.chartThang.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartThang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThang.Legends.Add(legend1);
            this.chartThang.Location = new System.Drawing.Point(2, 329);
            this.chartThang.Name = "chartThang";
            this.chartThang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartThang.Series.Add(series1);
            this.chartThang.Size = new System.Drawing.Size(848, 402);
            this.chartThang.TabIndex = 0;
            this.chartThang.Text = "chartTháng";
            // 
            // chartNamm
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNamm.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNamm.Legends.Add(legend2);
            this.chartNamm.Location = new System.Drawing.Point(2, 1);
            this.chartNamm.Name = "chartNamm";
            this.chartNamm.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartNamm.Series.Add(series2);
            this.chartNamm.Size = new System.Drawing.Size(848, 322);
            this.chartNamm.TabIndex = 1;
            this.chartNamm.Text = "chartNăm";
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1338, 736);
            this.Controls.Add(this.chartNamm);
            this.Controls.Add(this.chartThang);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Revenue statistics";
            this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNamm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNamm;
    }
}