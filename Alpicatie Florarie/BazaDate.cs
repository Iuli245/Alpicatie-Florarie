using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpicatie_Florarie
{
    public class BazaDate
    {
        private SQLiteConnection conexiune;

        public BazaDate()
        {
            conexiune = new SQLiteConnection("Data Source=Florarie.db;Version=3;");

            conexiune.Open();
        }

        public void AdaugaUtilizator(string nume, string parola, string email)
        {
            string sql = "INSERT INTO Utilizatori (Nume, Parola, Email) VALUES (@nume, @parola, @email)";
            using (var cmd = new SQLiteCommand(sql, conexiune))
            {
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@parola", parola);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> ListaUtilizatori()
        {
            var lista = new List<string>();
            string sql = "SELECT Nume, Email FROM Utilizatori";
            using (var cmd = new SQLiteCommand(sql, conexiune))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add($"{reader["Nume"]} - {reader["Email"]}");
                }
            }
            return lista;
        }

        public void Inchide() => conexiune?.Close();
    }
}
