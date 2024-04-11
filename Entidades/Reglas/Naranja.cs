using Entidades.Interfaces;

namespace Entidades.Reglas
{
    public class Naranja : Carta, IFunciones
    {
        public Naranja()
        {
            base.Color = Colores.Naranja;
        }

        public Byte IrGanando(List<Carta> mazo)
        {
            Dictionary<Byte, Byte> numeroCantidad = new();

            foreach(Carta regla in mazo)
                if(numeroCantidad.ContainsKey(regla.Numero))
                    numeroCantidad[regla.Numero]++;
                else
                    numeroCantidad[regla.Numero] = 1;

            return numeroCantidad.Values.Max();
        }
    }
}
