// Задание 1. Создание структур и перегрузка операторов.

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Examples with Complex
            Console.WriteLine("Examples with Complex");
            var a = new Complex(2, 5);
            var b = new Complex(2, 6);

            Console.WriteLine(a + b);
            Console.WriteLine(a * b);

            if (a == b)
            {
                Console.WriteLine("a == b");
            }

            Complex num1, num2;

            num1 = (3, -3);

            num2 = (10, 3);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num1 + num2);
            #endregion

            Console.WriteLine();

            #region Examples with Vector3D
            Console.WriteLine("Examples with Vector3D");
            var vec1 = new Vector3D(10, 4, 5);
            var vec2 = new Vector3D(20, 6, 3);

            if (new Vector3D(5, 4, 5) == new Vector3D(5, 4, 5))
            {
                Console.WriteLine("vec1 == vec2");
            }

            var res = vec1 * vec2;
            Console.WriteLine(vec1);
            Console.WriteLine(res);

            var vec333 = new Vector3D(10, 20, 30);

            for (int i = 0; i < 3; i++)
            {
                Console.Write(vec333[i] + " ");
            }

            #endregion
        }
    }
}