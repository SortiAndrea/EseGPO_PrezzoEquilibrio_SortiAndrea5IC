using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EseGPO_PrezzoEquilibrio_SortiAndrea5IC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgv_Risultati.Columns.Clear();
            dgv_Risultati.Columns.Add("Quantità", "Quantità");
            dgv_Risultati.Columns.Add("Domanda", "Domanda");
            dgv_Risultati.Columns.Add("Offerta", "Offerta");
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            dgv_Risultati.Rows.Clear();

            // Determino i valori iniziali
            double q = 0.0;
            double d = 90 - 4 * q;
            double o = 10 + Math.Pow(q, 3) / 100.0;

            double dIniziale = 90;
            double oIniziale = 10;

            dgv_Risultati.Rows.Add(q, d, o);

            // Parte 1: Cerco il punto di pareggio

            double step = 1.0;
            double minStep = 0.0001;
            bool superato = false;

            int safetyLimit = 500000;
            int counter = 0;

            while (!superato && counter < safetyLimit)
            {
                counter++;

                q += step;

                d = 90 - 4 * q;
                o = 10 + Math.Pow(q, 3) / 100.0;

                // Add initial row
                dgv_Risultati.Rows.Add(q, d, o);

                double diff = o - d;   // positivo = o sopra d

                // Riduzione dinamica step per precisione crescente
                if (Math.Abs(diff) < 10) step = 0.1;
                if (Math.Abs(diff) < 1) step = 0.01;
                if (Math.Abs(diff) < 0.1) step = 0.001;
                if (Math.Abs(diff) < 0.01) step = minStep;

                // ---> Se superato, passa al punto 2
                if (o >= d)
                {
                    superato = true;
                }
            }

            //Parte 2: arrivo fino a ~13.9 poi passo a 14 e continuo +1

            double qLimit = 13.9; // limite prima di forzare a 14
            double qTarget = Math.Ceiling(q); // di solito sarà 14 se sei a 13.x

            // 1) Incrementi piccoli SOLO finché q < 13.9
            while (q < qLimit && counter < safetyLimit)
            {
                counter++;

                q += 0.1;     // passo piccolo
                d = 90 - 4 * q;
                o = 10 + Math.Pow(q, 3) / 100.0;

                dgv_Risultati.Rows.Add(q, d, o);
            }

            // 2) Appena supero 13.9 → salto diretto al successivo intero
            q = qTarget; // esempio: si fissa a 14
            d = 90 - 4 * q;
            o = 10 + Math.Pow(q, 3) / 100.0;
            dgv_Risultati.Rows.Add(q, d, o);

            // 3) Ora incremento regolare di 1
            while (d > oIniziale && counter < safetyLimit)
            {
                counter++;

                q += 1;   // passo regolare da 1

                d = 90 - 4 * q;
                o = 10 + Math.Pow(q, 3) / 100.0;

                dgv_Risultati.Rows.Add(q, d, o);
            }

            // Creo il grafico

            // Svuoto eventuali dati precedenti
            GraficoRisultati.Series["Domanda"].Points.Clear();
            GraficoRisultati.Series["Offerta"].Points.Clear();

            // Popolo il grafico leggendo i valori dalla DataGridView
            foreach (DataGridViewRow row in dgv_Risultati.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                double qVal = Convert.ToDouble(row.Cells[0].Value);
                double dVal = Convert.ToDouble(row.Cells[1].Value);
                double oVal = Convert.ToDouble(row.Cells[2].Value);

                GraficoRisultati.Series["Domanda"].Points.AddXY(qVal, dVal);
                GraficoRisultati.Series["Offerta"].Points.AddXY(qVal, oVal);
                // Arrotondo solo i valori visibili sugli assi del grafico
                GraficoRisultati.ChartAreas[0].AxisX.LabelStyle.Format = "0";     // Accetto solo numeri interi
                GraficoRisultati.ChartAreas[0].AxisY.LabelStyle.Format = "0.##";  // Accetto massimo due decimali


            }

            // Miglioro l’aspetto come nel grafico
            GraficoRisultati.ChartAreas[0].AxisX.Title = "quantità";
            GraficoRisultati.ChartAreas[0].AxisY.Title = "prezzo";
            GraficoRisultati.Titles.Clear();
            GraficoRisultati.Titles.Add("aggiornamento sw"); // titolo come nell’esempio
            GraficoRisultati.ChartAreas[0].RecalculateAxesScale();

            // PUNTO DI EQUILIBRIO

            // Cerco la prima riga in cui o >= d
            double equilibrioQ = 0;
            double equilibrioD = 0;
            double equilibrioO = 0;
            bool trovato = false;

            foreach (DataGridViewRow row in dgv_Risultati.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                double qVal = Convert.ToDouble(row.Cells[0].Value);
                double dVal = Convert.ToDouble(row.Cells[1].Value);
                double oVal = Convert.ToDouble(row.Cells[2].Value);

                if (oVal >= dVal && !trovato)
                {
                    equilibrioQ = qVal;
                    equilibrioD = dVal;
                    equilibrioO = oVal;
                    trovato = true;
                }
            }

            // Se trovato, metto il pallino rosso
            if (trovato)
            {
                var serieEquilibrio = GraficoRisultati.Series.Add("Equilibrio");
                serieEquilibrio.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                serieEquilibrio.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                serieEquilibrio.MarkerSize = 7;
                serieEquilibrio.Color = Color.Red;

                serieEquilibrio.Points.AddXY(equilibrioQ, equilibrioD);

                // Etichetta vicino al punto
                serieEquilibrio.Points[0].Label = $"q={Math.Round(equilibrioQ, 5)}\nd={Math.Round(equilibrioD, 5)}\no={Math.Round(equilibrioO, 5)}";
                serieEquilibrio.Points[0].LabelForeColor = Color.Black;

            }
        }
    }
}
