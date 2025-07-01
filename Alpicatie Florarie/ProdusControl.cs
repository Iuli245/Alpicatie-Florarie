using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpicatie_Florarie
{
    public partial class ProdusControl: UserControl
    {
        public ProdusControl()
        {
            InitializeComponent();
        }
        public string Denumire
        {
            get => lblDenumire.Text;
            set => lblDenumire.Text = "Denumire: " + value;
        }

        public string Pret
        {
            get => lblPret.Text;
            set => lblPret.Text = "Pret: " + value + " lei";
        }

        public string Categorie
        {
            get => lblCategorie.Text;
            set => lblCategorie.Text = "Categorie: " + value;
        }

        private void ProdusControl_Load(object sender, EventArgs e)
        {

        }
    }
}
