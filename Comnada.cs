using System;
using System.Collections.Generic;
using System.Linq;

namespace AplicatieFlorarie.Clase
{
    public class Comanda
    {
        public int IdComanda { get; set; }
        public DateTime DataComanda { get; set; }
        public List<ProdusComandat> ListaProduse { get; set; } = new List<ProdusComandat>();
        public Client Client { get; set; }
        public Livrare Livrare { get; set; }

        // calcul pentru suma comenzii
        public decimal ValoareTotala => ListaProduse.Sum(p => p.Produs.Pret * p.Cantitate);
    }

    public class ProdusComandat
    {
        public Produs Produs { get; set; }
        public int Cantitate { get; set; }
    }
}
