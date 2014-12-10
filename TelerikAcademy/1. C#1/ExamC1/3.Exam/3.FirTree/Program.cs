using System;

class FirTree
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte p = (byte)(n - 2);
        byte k = 1;

        for (int i = 0; i < n - 2; i++)//col
        {
            for (int j = p; j > 0; j--)//col .
            {
                Console.Write(".");
            }
            p--;
            for (int r = 0; r < k; r++)//col *
            {
                Console.Write("*");
            }
            k += 2;
            for (int s = p; s >= 0; s--)//col .
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < 2 * n - 3; i++) //
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i = 0; i < n - 2; i++) //last row
        {
            Console.Write(".");
        }
        Console.Write("*");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();
    }
}