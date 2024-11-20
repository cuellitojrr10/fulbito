using System;
using System.Data;
using System.IO;

namespace Futbol
{
    public class Persistencia
    {
        private DataTable jugadoresTable;

        public Persistencia()
        {
            InicializarDataTable();
        }

        private void InicializarDataTable()
        {
            jugadoresTable = new DataTable("Jugadores");

            // Definir columnas
            jugadoresTable.Columns.Add("Nombre", typeof(string));
            jugadoresTable.Columns.Add("Posicion", typeof(string));
            jugadoresTable.Columns.Add("Edad", typeof(int));
        }

        public DataTable ObtenerDataTable()
        {
            return jugadoresTable;
        }

        public void AgregarJugador(Jugador jugador)
        {
            DataRow row = jugadoresTable.NewRow();
            row["Nombre"] = jugador.Nombre;
            row["Posicion"] = jugador.Posicion;
            row["Edad"] = jugador.Edad;
            jugadoresTable.Rows.Add(row);
        }

        public void GuardarEnXml(string filePath)
        {
            jugadoresTable.WriteXml(filePath);
        }

        public void CargarDeXml(string filePath)
        {
            if (File.Exists(filePath))
            {
                jugadoresTable.ReadXml(filePath);
            }
        }
    }
}
