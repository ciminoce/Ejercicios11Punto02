using Ejercicios11Punto02.Enum;

namespace Ejercicios11Punto02.Entidades
{
    public class Circunferencia
    {
        public int Radio { get; set; }
        public Punto Centro { get; set; }

        public Borde Borde { get; set; }
        public string Relleno { get; set; }
    }
}
