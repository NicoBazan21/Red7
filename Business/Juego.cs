using Entidades;

namespace Business
{
    public static class Juego
    {
        public static List<Jugador> Iniciar(List<Carta> baraja, List<String> jugadores)
        {
            List<Jugador> retorno = new List<Jugador>();
            if(baraja is not null)
                foreach (String nombre in jugadores)
                    retorno.Add(new Jugador { Mano = Juego.obtenerMano(baraja!), Nombre = nombre, Ganando = false });

            return retorno;
        }

        private static List<Carta> obtenerMano(List<Carta?> baraja)
        {
            Random random = new Random();
            Int32 indice;
            List<Carta> mano = new List<Carta>();
            Byte i = 0;

            while(i < 7)
            { 
                indice = random.Next(0, 48);
                if (baraja[indice] is not null)
                {
                    mano.Add(baraja[indice]!);
                    baraja[indice] = null;
                    i++;
                }
            }

            return mano;
        }
    }
}
