namespace Entidades
{
    public abstract class Carta
    {
        #region Propiedades
        public virtual Colores Color { get; protected set; }
        public virtual byte Numero { get; internal set; }
        #endregion

        #region Sobrecarga de operadores
        public static Boolean operator >(Carta r1, Carta r2)
        {
            return r1.Color > r2.Color;
        }
        public static Boolean operator <(Carta r1, Carta r2)
        {
            return !(r1 > r2);
        }
        #endregion
    }
}
