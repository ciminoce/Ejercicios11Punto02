namespace Ejercicios11Punto02.Entidades
{
    public class Punto
    {
        public int CoordenadaX { get; set; }
        public int CoordenadaY { get; set; }

        public Punto()
        {
            
        }

        public override string ToString()
        {
            return $"({CoordenadaX};{CoordenadaY})";
        }
    }
}
