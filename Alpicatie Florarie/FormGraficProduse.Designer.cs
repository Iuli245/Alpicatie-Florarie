﻿namespace Alpicatie_Florarie
{
    partial class FormGraficProduse
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
            this.chartProduse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProduse
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProduse.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProduse.Legends.Add(legend1);
            this.chartProduse.Location = new System.Drawing.Point(-2, 0);
            this.chartProduse.Name = "chartProduse";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProduse.Series.Add(series1);
            this.chartProduse.Size = new System.Drawing.Size(1226, 651);
            this.chartProduse.TabIndex = 0;
            this.chartProduse.Text = "chart1";
            this.chartProduse.Click += new System.EventHandler(this.chartProduse_Click);
            // 
            // FormGraficProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 654);
            this.Controls.Add(this.chartProduse);
            this.Name = "FormGraficProduse";
            this.Text = "FormGraficProduse";
            this.Load += new System.EventHandler(this.FormGraficProduse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProduse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduse;
    }
}