using System;
using Ejercicios11Punto02.Enum;

namespace Ejercicios11Punto02.Entidades
{
    public class Circunferencia:ICloneable
    {
        public int Radio { get; set; }
        public Punto Centro { get; set; }

        public Borde Borde { get; set; }
        public string Relleno { get; set; }

        public double GetPerimetro()=>2 * Math.PI * Radio;
        

        public double GetSuperficie() => Math.PI * Math.Pow(Radio, 2);

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Circunferencia))
            {
                return false;
            }

            return this.Radio == ((Circunferencia) obj).Radio
                   && this.Centro.Equals(((Circunferencia) obj).Centro);
        }

        public override int GetHashCode()
        {
            return this.Radio.GetHashCode() + Centro.GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
