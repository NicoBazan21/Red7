namespace Entidades
{
    public class Jugador
    {
        public required String Nombre { get; set; }
        public required List<Carta> Mano { get; set; }
        public required Boolean Ganando { get; set; }
    }
}
