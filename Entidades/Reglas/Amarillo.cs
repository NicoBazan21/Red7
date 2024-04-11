using Entidades.Interfaces;

namespace Entidades.Reglas
{
    public class Amarillo : Carta, IFunciones
    {
        public Amarillo()
        {
            base.Color = Colores.Amarillo;
        }

        public Byte IrGanando(List<Carta> mazo)
        {
            Dictionary<Colores, Byte> colorCantidad = new Dictionary<Colores, Byte>();

            foreach(Carta regla in mazo)
                if (colorCantidad.ContainsKey(regla.Color))
                    colorCantidad[regla.Color]++;
                else
                    colorCantidad[regla.Color] = 1;

            return colorCantidad.Values.Max();
        }
    }
}
