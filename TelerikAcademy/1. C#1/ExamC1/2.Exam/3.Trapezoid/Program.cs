using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = n - 1;
        for (int i = 1; i <= n; i++)
        {
            Console.Write(".");
        }
        for (int i = 1; i <= n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i = 1; i < n; i++) //middle part
        {
            for (int j = 0; j < (2 * n) - 1; j++) //ROW
            {
                if (j == p)
                    Console.Write("*");
                else
                    Console.Write(".");

            }
            Console.WriteLine("*");
            p--;
        }

        for (int i = 1; i <= 2 * n; i++) //last row
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}