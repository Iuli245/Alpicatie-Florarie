using AplicatieFlorarie.Clase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alpicatie_Florarie
{
    public partial class FormDragDropComenzi : Form
    {
        private List<Produs> produse;

        public FormDragDropComenzi(List<Produs> listaProduse)
        {
            InitializeComponent();
            produse = listaProduse;

            IncarcaProduseDisponibile();

            listBoxProduseDisponibile.MouseDown += ListBoxProduseDisponibile_MouseDown;
            listBoxCosComanda.AllowDrop = true;
            listBoxCosComanda.DragEnter += ListBoxCosComanda_DragEnter;
            listBoxCosComanda.DragDrop += ListBoxCosComanda_DragDrop;
        }

        private void IncarcaProduseDisponibile()
        {
            listBoxProduseDisponibile.Items.Clear();
            foreach (var produs in produse)
            {
                listBoxProduseDisponibile.Items.Add(produs.Denumire);
            }
        }

        private void ListBoxProduseDisponibile_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxProduseDisponibile.SelectedItem != null)
            {
                listBoxProduseDisponibile.DoDragDrop(listBoxProduseDisponibile.SelectedItem, DragDropEffects.Move);
            }
        }

        private void ListBoxCosComanda_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ListBoxCosComanda_DragDrop(object sender, DragEventArgs e)
        {
            string produsMutat = (string)e.Data.GetData(DataFormats.StringFormat);
            listBoxCosComanda.Items.Add(produsMutat);
            listBoxProduseDisponibile.Items.Remove(produsMutat);
        }

       
        private void listBoxProduseDisponibile_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void FormDragDropComenzi_Load(object sender, EventArgs e)
        {
           
        }

    }
}
