using Entidades.Interfaces;

namespace Entidades.Reglas
{
    public class Celeste : Carta, IFunciones
    {
        public Celeste()
        {
            base.Color = Colores.Celete;
        }

        public Byte IrGanando(List<Carta> mazo)
        {
            List<Colores> colores = new List<Colores>();

            foreach (Carta regla in mazo)
                if (!colores.Contains(regla.Color))
                    colores.Add(regla.Color);

            return (Byte)colores.Count();
        }
    }
}
