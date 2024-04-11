using Entidades.Interfaces;

namespace Entidades.Reglas
{
    public class Rojo : Carta, IFunciones
    {
        public Rojo()
        {
            base.Color = Colores.Rojo;
        }

        public Byte IrGanando(List<Carta> mazo)
        {
            Byte masAlto = 0;

            foreach(Carta item in mazo)
                if(item.Numero > masAlto)
                    masAlto = item.Numero;

            return masAlto;
        }

        public static Boolean operator >=(Rojo c1, Carta c2)
        {
            if (c1.Numero > c2.Numero) return true;
            if (c1.Numero == c2.Numero) return c1 > c2;
            return false;
        }
        public static Boolean operator <=(Rojo r1, Carta r2)
        => !(r1 > r2);
    }
}
