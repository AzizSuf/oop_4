using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public struct Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex()
        {
            Re = 0;
            Im = 0;
        }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public double Mod()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }

        public static implicit operator Complex((double re, double im) num)
        {
            return new Complex(num.re, num.im);
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Re * b.Re, a.Im * b.Im);
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return (a.Re == b.Re) && (a.Im == b.Im);
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return (a.Re != b.Re) || (a.Im != b.Im);
        }
    }
}
