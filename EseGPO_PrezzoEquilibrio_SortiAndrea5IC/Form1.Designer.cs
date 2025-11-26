namespace EseGPO_PrezzoEquilibrio_SortiAndrea5IC
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEquilibrioQ = new System.Windows.Forms.Label();
            this.lblEquilibrioP = new System.Windows.Forms.Label();
            this.txtDomA = new System.Windows.Forms.TextBox();
            this.txtDomB = new System.Windows.Forms.TextBox();
            this.txtOffA = new System.Windows.Forms.TextBox();
            this.txtOffB = new System.Windows.Forms.TextBox();
            this.txtMaxQ = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.dgvValori = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GraficoRisultati = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domanda A:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domanda B:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Offerta A:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Offerta B:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Q:";
            // 
            // lblEquilibrioQ
            // 
            this.lblEquilibrioQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquilibrioQ.Location = new System.Drawing.Point(789, 120);
            this.lblEquilibrioQ.Name = "lblEquilibrioQ";
            this.lblEquilibrioQ.Size = new System.Drawing.Size(148, 23);
            this.lblEquilibrioQ.TabIndex = 14;
            this.lblEquilibrioQ.Text = "Q equilibrio = ";
            // 
            // lblEquilibrioP
            // 
            this.lblEquilibrioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquilibrioP.Location = new System.Drawing.Point(958, 121);
            this.lblEquilibrioP.Name = "lblEquilibrioP";
            this.lblEquilibrioP.Size = new System.Drawing.Size(175, 23);
            this.lblEquilibrioP.TabIndex = 15;
            this.lblEquilibrioP.Text = "Prezzo equilibrio = ";
            // 
            // txtDomA
            // 
            this.txtDomA.Location = new System.Drawing.Point(97, 86);
            this.txtDomA.Name = "txtDomA";
            this.txtDomA.Size = new System.Drawing.Size(146, 20);
            this.txtDomA.TabIndex = 6;
            this.txtDomA.Text = "90";
            // 
            // txtDomB
            // 
            this.txtDomB.Location = new System.Drawing.Point(360, 89);
            this.txtDomB.Name = "txtDomB";
            this.txtDomB.Size = new System.Drawing.Size(145, 20);
            this.txtDomB.TabIndex = 7;
            this.txtDomB.Text = "4";
            // 
            // txtOffA
            // 
            this.txtOffA.Location = new System.Drawing.Point(83, 123);
            this.txtOffA.Name = "txtOffA";
            this.txtOffA.Size = new System.Drawing.Size(160, 20);
            this.txtOffA.TabIndex = 8;
            this.txtOffA.Text = "10";
            // 
            // txtOffB
            // 
            this.txtOffB.Location = new System.Drawing.Point(345, 124);
            this.txtOffB.Name = "txtOffB";
            this.txtOffB.Size = new System.Drawing.Size(160, 20);
            this.txtOffB.TabIndex = 9;
            this.txtOffB.Text = "100";
            // 
            // txtMaxQ
            // 
            this.txtMaxQ.Location = new System.Drawing.Point(597, 122);
            this.txtMaxQ.Name = "txtMaxQ";
            this.txtMaxQ.Size = new System.Drawing.Size(168, 20);
            this.txtMaxQ.TabIndex = 10;
            this.txtMaxQ.Text = "15";
            // 
            // btnCalcola
            // 
            this.btnCalcola.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcola.Location = new System.Drawing.Point(15, 149);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(1118, 80);
            this.btnCalcola.TabIndex = 11;
            this.btnCalcola.Text = "Calcola e Disegna";
            this.btnCalcola.UseVisualStyleBackColor = false;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // dgvValori
            // 
            this.dgvValori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvValori.Location = new System.Drawing.Point(15, 235);
            this.dgvValori.Name = "dgvValori";
            this.dgvValori.Size = new System.Drawing.Size(350, 300);
            this.dgvValori.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // GraficoRisultati
            // 
            this.GraficoRisultati.Location = new System.Drawing.Point(385, 235);
            this.GraficoRisultati.Name = "GraficoRisultati";
            this.GraficoRisultati.Size = new System.Drawing.Size(748, 300);
            this.GraficoRisultati.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(539, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "ESERCIZIO PREZZO EQUILIBRIO";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1156, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDomA);
            this.Controls.Add(this.txtDomB);
            this.Controls.Add(this.txtOffA);
            this.Controls.Add(this.txtOffB);
            this.Controls.Add(this.txtMaxQ);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.dgvValori);
            this.Controls.Add(this.GraficoRisultati);
            this.Controls.Add(this.lblEquilibrioQ);
            this.Controls.Add(this.lblEquilibrioP);
            this.Name = "Form1";
            this.Text = "Curve Domanda e Offerta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvValori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoRisultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        #endregion

        private System.Windows.Forms.DataGridView dgvValori;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoRisultati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomA;
        private System.Windows.Forms.TextBox txtDomB;
        private System.Windows.Forms.TextBox txtOffB;
        private System.Windows.Forms.TextBox txtOffA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxQ;
        private System.Windows.Forms.Label lblEquilibrioQ;
        private System.Windows.Forms.Label lblEquilibrioP;
        private System.Windows.Forms.Label label6;
    }
}

