using Entidades.Interfaces;

namespace Entidades.Reglas
{
    public class Violeta : Carta, IFunciones
    {
        public Violeta()
        {
            base.Color = Colores.Violeta;
        }

        public Byte IrGanando(List<Carta> mazo)
        {
            Byte cartasMenoresACuatro = 0;

            foreach (Carta carta in mazo)
                if (carta.Numero < 4)
                    cartasMenoresACuatro++;

            return cartasMenoresACuatro;
        }
    }
}
