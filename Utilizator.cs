using System;

namespace AplicatieFlorarie.Clase
{
    public enum RolUtilizator
    {
        Admin,
        Angajat
    }

    public class Utilizator
    {
        public int IdUtilizator { get; set; }
        public string NumeUtilizator { get; set; }
        public string Parola { get; set; } 
        public RolUtilizator Rol { get; set; }
    }
}
