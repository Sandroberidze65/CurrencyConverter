namespace Currencyconverter
{
    partial class CurrencyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_from = new System.Windows.Forms.ComboBox();
            this.comboBox_To = new System.Windows.Forms.ComboBox();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.chart_statistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.chart_statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // comboBox_from
            // 
            this.comboBox_from.FormattingEnabled = true;
            this.comboBox_from.Location = new System.Drawing.Point(145, 57);
            this.comboBox_from.Name = "comboBox_from";
            this.comboBox_from.Size = new System.Drawing.Size(89, 37);
            this.comboBox_from.TabIndex = 2;
            this.comboBox_from.SelectedValueChanged += new System.EventHandler(this.comboBox_from_SelectedValueChanged);
            // 
            // comboBox_To
            // 
            this.comboBox_To.FormattingEnabled = true;
            this.comboBox_To.Location = new System.Drawing.Point(145, 106);
            this.comboBox_To.Name = "comboBox_To";
            this.comboBox_To.Size = new System.Drawing.Size(89, 37);
            this.comboBox_To.TabIndex = 3;
            this.comboBox_To.SelectedValueChanged += new System.EventHandler(this.comboBox_from_SelectedValueChanged);
            // 
            // textBox_from
            // 
            this.textBox_from.Location = new System.Drawing.Point(263, 57);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(209, 35);
            this.textBox_from.TabIndex = 4;
            this.textBox_from.Text = "0";
            this.textBox_from.TextChanged += new System.EventHandler(this.textBox_from_TextChanged);
            // 
            // textBox_to
            // 
            this.textBox_to.Location = new System.Drawing.Point(263, 106);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.ReadOnly = true;
            this.textBox_to.Size = new System.Drawing.Size(209, 35);
            this.textBox_to.TabIndex = 5;
            // 
            // chart_statistic
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_statistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_statistic.Legends.Add(legend1);
            this.chart_statistic.Location = new System.Drawing.Point(58, 173);
            this.chart_statistic.Name = "chart_statistic";
            this.chart_statistic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gel";
            this.chart_statistic.Series.Add(series1);
            this.chart_statistic.Size = new System.Drawing.Size(414, 407);
            this.chart_statistic.TabIndex = 6;
            // 
            // CurrencyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(502, 624);
            this.Controls.Add(this.chart_statistic);
            this.Controls.Add(this.textBox_to);
            this.Controls.Add(this.textBox_from);
            this.Controls.Add(this.comboBox_To);
            this.Controls.Add(this.comboBox_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CurrencyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CurrencyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_statistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_from;
        private System.Windows.Forms.ComboBox comboBox_To;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_statistic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

