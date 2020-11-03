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

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Punto))
            {
                return false;
            }

            return this.CoordenadaX == ((Punto) obj).CoordenadaX &&
                   this.CoordenadaY == ((Punto) obj).CoordenadaY;
        }

        public override int GetHashCode()
        {
            return CoordenadaX.GetHashCode() + CoordenadaY.GetHashCode();
        }
    }
}
