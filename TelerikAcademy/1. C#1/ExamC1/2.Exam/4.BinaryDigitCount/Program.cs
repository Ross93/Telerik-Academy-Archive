using System;

class Digit
{
    static void Main()
    {
        uint countOne = 0;
        uint countZero = 0;
        uint b = uint.Parse(Console.ReadLine());
        uint n = uint.Parse(Console.ReadLine());
        uint[] numbers = new uint[n];
        for (uint i = 0; i < n; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
            for (uint j = 0; j < Convert.ToString(numbers[i], 2).Length; j++)
            {
                uint mask = (uint)1 << (int)j;
                uint andMask = (uint)numbers[i] & mask;
                uint bit = (uint)andMask >> (int)j;
                if (bit == 1)
                    countOne++;
                else if (bit == 0)
                    countZero++;
            }
            //Console.WriteLine(Convert.ToString(numbers[i], 2));
            //Console.WriteLine("to string: " + Convert.ToString(numbers[i], 2).Length);
            if (b == 0)
            {
                //Console.Write("0: ");
                Console.WriteLine(countZero);
            }
            else if (b == 1)
            {
                // Console.Write("1: ");
                Console.WriteLine(countOne);
            }
            countZero *= 0;
            countOne *= 0;
        }

    }
}