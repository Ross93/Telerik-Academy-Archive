using System;

class WeAllLoveBits
{
    static void Main()
    {

        uint n = uint.Parse(Console.ReadLine());
        uint[] number = new uint[n];
        for (int i = 0; i < n; i++)
        {
            number[i] = uint.Parse(Console.ReadLine());

            //Console.WriteLine(Convert.ToString(number[i], 2));
        }
        for (int j = 0; j < n; j++)
        {
            int sizeJ = Convert.ToString(number[j], 2).Length;
            uint a = ~(number[j]);
            //Console.WriteLine(Convert.ToString(a, 2).Substring(Convert.ToString(a, 2).Length - sizeJ));
            int Ptilda = Convert.ToInt32(Convert.ToString(a, 2).Substring(Convert.ToString(a, 2).Length - sizeJ), 2);
            //Console.WriteLine(Ptilda);



            string Chisloto = Convert.ToString(number[j], 2);
            //Console.WriteLine(Chisloto);
            char[] progress = Chisloto.ToCharArray();
            Array.Reverse(progress);
            Chisloto = String.Concat(progress);
            //Console.WriteLine(Chisloto);
            int Ptochki = Convert.ToInt32(Chisloto, 2);
            //Console.WriteLine(Ptochki);

            Console.WriteLine((number[j] ^ Ptilda) & Ptochki);
        }

    }
}