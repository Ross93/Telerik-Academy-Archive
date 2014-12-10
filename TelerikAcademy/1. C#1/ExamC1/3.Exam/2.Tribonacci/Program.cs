using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        short n = short.Parse(Console.ReadLine());
        BigInteger d = 0;
 
        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if ( n == 2)
        {
            Console.WriteLine(b);
        }
        else if (n == 3)
        {
            Console.WriteLine(c);
        }
        else
        {
            for (short i = 1; i <= n - 3; i++)
            {
                d = a + b + c;
                a = b;
                b = c;
                c = d;
            }
            Console.WriteLine(d);
        }
    }
}