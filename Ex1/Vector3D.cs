namespace Ex1
{
    public struct Vector3D
    {
        public double x, y, z;

        public Vector3D()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Experiments...
        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default: throw new ArgumentOutOfRangeException();
                }
            }

            set
            {
                switch (i)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        public double Module()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            var c = new Vector3D();
            c.x = a.x + b.x;
            c.y = a.y + b.y;
            return c;
        }

        public static Vector3D operator *(double c, Vector3D a)
        {
            var h = new Vector3D();
            h.x = a.x * c;
            h.y = a.y * c;
            return h;
        }

        public static Vector3D operator *(Vector3D a, double c)
        {
            var h = new Vector3D();
            h.x = a.x * c;
            h.y = a.y * c;
            return h;
        }

        public static Vector3D operator /(Vector3D a, double c)
        {
            var h = new Vector3D();
            h.x = a.x / c;
            h.y = a.y / c;
            return h;
        }

        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            var c = new Vector3D();
            c.x = a.x - b.x;
            c.y = a.y - b.y;
            return c;
        }

        /// <summary>
        /// Dot product - Скалярное произведение
        /// </summary>
        public static double operator *(Vector3D a, Vector3D b)
        {
            return a.x * b.x + a.y * b.y;
        }

        /// <summary>
        /// Cross product - Векторное произведение
        /// </summary>
        public static Vector3D operator &(Vector3D a, Vector3D b)
        {
            var c = new Vector3D();
            c.x = a.y * b.z - a.z * b.y;
            c.y = a.z * b.y - a.y * b.z;
            c.z = a.x * b.z - a.z * b.x;
            return c;
        }

        public static bool operator ==(Vector3D a, Vector3D b)
        {
            return (a.x == b.x) &&
                   (a.y == b.y) &&
                   (a.z == b.z);
        }

        public static bool operator !=(Vector3D a, Vector3D b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Vector3D other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        }

        public override string ToString()
        {
            return $"x:{x}, y:{y} z:{z}";
        }
    }
}
