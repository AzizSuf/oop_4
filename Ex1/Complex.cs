namespace Ex1
{
    public struct Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex()
        {
            Re = 0.0;
            Im = 0.0;
        }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public double Module()
        {
            return Math.Sqrt(Re * Re + Im * Im);
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
            return (a.Re == b.Re) &&
                   (a.Im == b.Im);
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Complex other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Re, Im);
        }

        public override string ToString()
        {
            // {number: +0; -0; 0}
            // +0: Displays a + for positive numbers.
            // -0: Displays a - for negative numbers.
            //  0: If the number is zero, it simply shows 0.
            return $"{Re}{Im:+0;-0;0}i";
        }
    }
}
