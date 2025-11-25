namespace EseGPO_PrezzoEquilibrio_SortiAndrea5IC
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GraficoRisultati = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_Risultati = new System.Windows.Forms.DataGridView();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoRisultati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Risultati)).BeginInit();
            this.SuspendLayout();
            // 
            // GraficoRisultati
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficoRisultati.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficoRisultati.Legends.Add(legend2);
            this.GraficoRisultati.Location = new System.Drawing.Point(652, 72);
            this.GraficoRisultati.Margin = new System.Windows.Forms.Padding(4);
            this.GraficoRisultati.Name = "GraficoRisultati";
            this.GraficoRisultati.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Domanda";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Offerta";
            this.GraficoRisultati.Series.Add(series3);
            this.GraficoRisultati.Series.Add(series4);
            this.GraficoRisultati.Size = new System.Drawing.Size(655, 431);
            this.GraficoRisultati.TabIndex = 5;
            this.GraficoRisultati.Text = "GraficoRisultati";
            // 
            // dgv_Risultati
            // 
            this.dgv_Risultati.AllowUserToAddRows = false;
            this.dgv_Risultati.AllowUserToDeleteRows = false;
            this.dgv_Risultati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Risultati.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Risultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Risultati.Location = new System.Drawing.Point(41, 72);
            this.dgv_Risultati.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Risultati.Name = "dgv_Risultati";
            this.dgv_Risultati.ReadOnly = true;
            this.dgv_Risultati.RowHeadersWidth = 51;
            this.dgv_Risultati.Size = new System.Drawing.Size(603, 431);
            this.dgv_Risultati.TabIndex = 4;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcola.Location = new System.Drawing.Point(41, 511);
            this.btnCalcola.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(1265, 116);
            this.btnCalcola.TabIndex = 3;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(142, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(995, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "ESERCIZIO Sorti Andrea 5IC PREZZO DI EQUILIBRIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1347, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraficoRisultati);
            this.Controls.Add(this.dgv_Risultati);
            this.Controls.Add(this.btnCalcola);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GraficoRisultati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Risultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Risultati;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoRisultati;
        private System.Windows.Forms.Label label1;
    }
}

