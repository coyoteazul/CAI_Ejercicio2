using System;

namespace CAI_Ejercicio2
{
    class Program
    {
        static bool IsPrimo (int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 805; i++)
            {
                string suffix = null;
                if (IsPrimo(i))
                {
                    suffix += " Es primo";
                }
                if (i % 3 == 0)
                {
                    if (!string.IsNullOrEmpty(suffix))
                        suffix += " y";
                    suffix += " Es divisible por 3";
                }

                if (!string.IsNullOrEmpty(suffix))
                {
                    Console.WriteLine(i + suffix);
                }
            }
        }
    }
}
