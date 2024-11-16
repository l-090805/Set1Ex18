using System.Data.Common;

namespace Set1Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Descompunere in factori primi: ");
            DescompunereFactoriPrimi(n);
        }

        static void DescompunereFactoriPrimi(int n)
        {
            bool primulFactor = true;

            int putere = 0;
            while (n % 2 == 0)
            {
                n /= 2;
                putere++;
            }
            if (putere > 0)
            {
                if (!primulFactor)
                {
                    Console.Write(" X ");
                }
                Console.Write($"2^{putere}");
                primulFactor = false;
            }

            for (int i = 3; i * i <= n; i += 2)
            {
                putere = 0;
                while (n % i == 0)
                {
                    n /= i;
                    putere++;
                }
                if (putere > 0)
                {
                    if (!primulFactor)
                    {
                        Console.Write(" X ");
                    }
                    Console.Write($"{i}^{putere}");
                    primulFactor = false;

                }

            }
            if (n > 1)
            {
                if (!primulFactor)
                {
                    Console.Write(" X ");
                }
                Console.Write($"{n}^1");
            }
            Console.WriteLine();
        }
    }
}
