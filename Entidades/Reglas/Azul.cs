using Entidades.Interfaces;

namespace Entidades.Reglas
{
    public class Azul : Carta, IFunciones
    {
        public Azul()
        {
            base.Color = Colores.Azul;
        }
        public Byte IrGanando(List<Carta> mazo)
        {
            Byte orden = 1;
            Byte maximo = 0;
            mazo = mazo.OrderBy(item => item.Numero).ToList();

            for(Byte i = 1; i < mazo.Count; i++)
                if (mazo[i].Numero == mazo[i - 1].Numero + 1)
                    orden++;
                else
                {
                    maximo = Math.Max(maximo, orden);
                    orden = 1;
                }

            return maximo;
        }
    }
}
