namespace Futbol
{
    public class Jugador
    {
        // Atributos
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }

        // Métodos
        public string ObtenerDetalles()
        {
            return $"{Nombre} juega como {Posicion}, y tiene {Edad} años.";
        }
    }
}
