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
    public partial class FormStart: Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
        
            if (txtNume.Text == "" || txtParola.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            var db = new BazaDate();
            db.AdaugaUtilizator(txtNume.Text, txtParola.Text, txtEmail.Text);

            listBoxUtilizatori.Items.Clear();
            foreach (var user in db.ListaUtilizatori())
                listBoxUtilizatori.Items.Add(user);

            db.Inchide();

            txtNume.Clear();
            txtParola.Clear();
            txtEmail.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            var db = new BazaDate();
            foreach (var user in db.ListaUtilizatori())
                listBoxUtilizatori.Items.Add(user);
            db.Inchide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdaugareProdus formNou = new FormAdaugareProdus();
            formNou.Show();
            this.Hide();
        }
    }
}

