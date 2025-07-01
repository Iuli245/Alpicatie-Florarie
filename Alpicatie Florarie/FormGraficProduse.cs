using AplicatieFlorarie.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpicatie_Florarie
{
    public partial class FormGraficProduse: Form
    {
        public FormGraficProduse()
        {
            InitializeComponent();
        }
        private List<Produs> produse;

        public FormGraficProduse(List<Produs> listaProduse)
        {
            InitializeComponent();
            produse = listaProduse;
            AfiseazaGraficProduse();
        }
        private void AfiseazaGraficProduse()
        {
            // resetare date existente
            chartProduse.Series.Clear();
            chartProduse.ChartAreas.Clear();
            chartProduse.ChartAreas.Add("CategoriiProduse");

            var categorii = produse.GroupBy(p => p.Categorie)
                                   .Select(g => new { Categorie = g.Key, Total = g.Sum(p => p.CantitateStoc) });

            chartProduse.Series.Add("Produse");
            chartProduse.Series["Produse"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (var c in categorii)
            {
                chartProduse.Series["Produse"].Points.AddXY(c.Categorie, c.Total);
            }
        }

        private void FormGraficProduse_Load(object sender, EventArgs e)
        {

        }

        private void chartProduse_Click(object sender, EventArgs e)
        {

        }
    }
}
