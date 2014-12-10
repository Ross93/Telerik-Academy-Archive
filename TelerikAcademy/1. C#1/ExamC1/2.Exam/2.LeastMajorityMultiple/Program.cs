using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int maxDevisor = a * b * c * d * e;
        int devisions = 0;
        for (int i = 1; i <= maxDevisor; i++)
        {
            if (i % a == 0)
            {
                devisions++;
            }
            if (i % b == 0)
            {
                devisions++;
            } if (i % c == 0)
            {
                devisions++;
            } if (i % d == 0)
            {
                devisions++;
            } if (i % e == 0)
            {
                devisions++;
            }
            if (devisions >= 3)
            {
                Console.WriteLine(i);
                break;
            }
            else
            {
                devisions *= 0;
            }
        }
    }
}