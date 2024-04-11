using Entidades.Reglas;

namespace Entidades
{
    public static class Baraja
    {
        public static List<Carta> BarajaGeneral { get; set; }

        static Baraja()
        {
            BarajaGeneral = Baraja.GenerarBaraja();
        }

        private static List<Carta> GenerarBaraja()
        {
            List<Carta> baraja = new List<Carta>();

            foreach(Byte numero in new Byte[]{ 1, 2, 3, 4, 5, 6, 7 })
            {
                baraja.Add(new Rojo { Numero = numero});
                baraja.Add(new Naranja { Numero = numero });
                baraja.Add(new Amarillo { Numero = numero });
                baraja.Add(new Verde { Numero = numero });
                baraja.Add(new Celeste { Numero = numero });
                baraja.Add(new Azul { Numero = numero });
                baraja.Add(new Violeta { Numero = numero });
            }
            return baraja;
        }
    }
}
