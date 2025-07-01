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
    public partial class FormIstoricComenzi: Form
    {
        public FormIstoricComenzi()
        {
            InitializeComponent();
        }

        private void FormIstoricComenzi_Load(object sender, EventArgs e)
        {

        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            int y = 10;

            // Exemplu de produse simulate (în loc de bază de date)
            List<(string denumire, string pret, string categorie)> produse = new List<(string, string, string)>
    {
        ("Trandafir", "25", "Flori"),
        ("Buchet Mireasa", "120", "Buchete"),
        ("Lalele", "18", "Flori"),
    };

            foreach (var p in produse)
            {
                ProdusControl pc = new ProdusControl();
                pc.Denumire = p.denumire;
                pc.Pret = p.pret;
                pc.Categorie = p.categorie;

                pc.Location = new Point(10, y);
                this.Controls.Add(pc);
                y += pc.Height + 10;
            }
        }
    }
}
