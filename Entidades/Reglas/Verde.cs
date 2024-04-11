using Entidades.Interfaces;

namespace Entidades.Reglas
{
    public class Verde : Carta, IFunciones
    {
        public Verde()
        {
            base.Color = Colores.Verde;
        }

        public Byte IrGanando(List<Carta> mazo)
        {
            Byte contadorPares = 0;
            foreach (Carta regla in mazo)
                if (regla.Numero % 2 == 0)
                    contadorPares++;

            return contadorPares;
        }
    }
}
