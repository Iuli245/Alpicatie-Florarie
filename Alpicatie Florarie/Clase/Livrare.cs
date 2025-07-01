using System;

namespace AplicatieFlorarie.Clase
{
    [Serializable]
    public enum StatusLivrare
    {
        InCursDeLivrare,
        Livrat,
        Anulat
    }

    public class Livrare
    {
        public int IdLivrare { get; set; }
        public string Adresa { get; set; }
        public DateTime DataLivrare { get; set; }
        public StatusLivrare Status { get; set; }
        public string Observatii { get; set; }
    }
}
