using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AplicatieFlorarie.Clase;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Alpicatie_Florarie
{
    public partial class FormAdaugareProdus: Form
    {
        private List<Produs> produse = new List<Produs>();
        public FormAdaugareProdus()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ContextMenuStrip = contextMenuProduse;
            IncarcaProduseDinFisier();
        }
        private void FormAdaugareProdus_Load(object sender, EventArgs e)
        {
            if (contextMenuProduse.Items.Count == 0)
            {
                contextMenuProduse.Items.Add("Reseteaza campuri", null, resetareCampuriToolStripMenuItem_Click);
                contextMenuProduse.Items.Add("Incarca produse din fisier", null, incarcaProduseDinFisierToolStripMenuItem_Click);
                contextMenuProduse.Items.Add("Salveaza produse in fisier", null, salveazaPToolStripMenuItem_Click);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            //validarea datelor
            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                MessageBox.Show("Introduceti denumirea produsului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCategorie.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati categoria produsului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPret.Text, out decimal pret) || pret <= 0)
            {
                MessageBox.Show("Introduceti un pret valid (> 0)!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numCantitate.Value <= 0)
            {
                MessageBox.Show("Introduceti o cantitate valida (> 0)!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var produsNou = new Produs
            {
                IdProdus = GenereazaIdProdus(),
                Denumire = txtDenumire.Text,
                Categorie = cmbCategorie.SelectedItem.ToString(),
                Pret = pret,
                CantitateStoc = (int)numCantitate.Value,
                Descriere = txtDescriere.Text
            };

            produse.Add(produsNou); // Adauga produs in lista
            SalveazaProduseInFisier(); // Salveaza lista actualizata

            MessageBox.Show($"Produsul {produsNou.Denumire} a fost adaugat si salvat!", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // resetare formular intrare noua
            txtDenumire.Clear();
            cmbCategorie.SelectedIndex = -1;
            txtPret.Clear();
            numCantitate.Value = 0;
            txtDescriere.Clear();
        }
        private int GenereazaIdProdus()
        {
            return new Random().Next(1000, 9999);
        }

        private void txtDenumire_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdaugaProdus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //  salvarea produsului->enter
                btnSalvare.PerformClick();

                // oprim propagarea tastei mai repede
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // resetare prin tasta ESC
                txtDenumire.Clear();
                cmbCategorie.SelectedIndex = -1;
                txtPret.Clear();
                numCantitate.Value = 0;
                txtDescriere.Clear();

                e.Handled = true;
            }
        }

        private void afiseazaProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iesireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatia Florarie\nVersiune: 1.0\nRealizat de: Rijnoveanu Gabriel Iulian", "Despre",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void adaugaProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDenumire.Clear();
            cmbCategorie.SelectedIndex = -1;
            txtPret.Clear();
            numCantitate.Value = 0;
            txtDescriere.Clear();
            txtDenumire.Focus();
        }

        private void afiseazaProdusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mesaj = "Produse disponibile:\n";
            foreach (Produs p in produse)
            {
                mesaj += $"- {p.Denumire}, Categorie: {p.Categorie}, Preț: {p.Pret} lei, Cantitate: {p.CantitateStoc}\n";
            }
            MessageBox.Show(mesaj, "Lista produse", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void adaugaComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Functionalitate in curs de dezvoltare pentru adaugare comanda.",
      "Adauga Comanda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void istoricComenziToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormIstoricComenzi f = new FormIstoricComenzi();
            f.Show();
            //     MessageBox.Show("Functionalitate in curs de dezvoltare pentru istoricul comenzilor.",
            //"Istoric Comenzi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gestionareLivrariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Functionalitate in curs de dezvoltare pentru gestionare livrari.",
        "Gestionare Livrari", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void ajutorRapidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pentru a adauga produse foloseste formularul disponibil. Foloseste meniurile pentru navigare rapida in aplicatie.",
       "Ajutor Rapid", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void resetareCampuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDenumire.Clear();
            cmbCategorie.SelectedIndex = -1;
            txtPret.Clear();
            numCantitate.Value = 0;
            txtDescriere.Clear();
            txtDenumire.Focus();
        }

        private void incarcaProduseDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncarcaProduseDinFisier();
            MessageBox.Show("Produsele au fost incarcate din fisier!", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salveazaPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalveazaProduseInFisier();
            MessageBox.Show("Produsele au fost salvate în fisier!", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //serializare salvare in fisiere/ citire din fisier
        private void SalveazaProduseInFisier()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("produse.dat", FileMode.Create))
            {
                formatter.Serialize(stream, produse);
            }
        }

        private void IncarcaProduseDinFisier()
        {
            if (File.Exists("produse.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("produse.dat", FileMode.Open))
                {
                    produse = (List<Produs>)formatter.Deserialize(stream);
                }
            }
            else
            {
                MessageBox.Show("Nu exista fisierul cu produse!", "Eroare incarcare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void afisareGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void afisareGraficProdusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            var frmGrafic = new FormGraficProduse(produse); // trimite lista produse
            frmGrafic.ShowDialog();
        

        }

        private void imprimareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPrint = new FormImprimareProduse(produse);
            frmPrint.ShowDialog();
        }

        private void dragDropFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDragDrop = new FormDragDropComenzi(produse);
            frmDragDrop.ShowDialog();
        }
    }

}
