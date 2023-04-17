// Задание 1. Создание структур и перегрузка операторов.

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Complex a = new Complex(2, 5);
            Complex b = new Complex(2, 6);

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
        }
    }
}