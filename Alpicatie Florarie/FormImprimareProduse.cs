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
    public partial class FormImprimareProduse: Form
    {
        public FormImprimareProduse()
        {
            InitializeComponent();
        }
        private List<Produs> produse;

        public FormImprimareProduse(List<Produs> listaProduse)
        {
            InitializeComponent();
            produse = listaProduse;
        }

        private void FormImprimareProduse_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string textPrintat = "Lista Produse:\n\n";
            foreach (var p in produse)
            {
                textPrintat += $"{p.Denumire}, Cat.: {p.Categorie}, Pret: {p.Pret} lei, Cant.: {p.CantitateStoc}\n";
            }

            e.Graphics.DrawString(textPrintat, new Font("Arial", 12), Brushes.Black, new RectangleF(100, 100, e.PageBounds.Width - 200, e.PageBounds.Height - 200));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
