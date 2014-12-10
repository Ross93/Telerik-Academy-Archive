using System;

class FighterAttack
{
    static void Main()
    {
        int Px1 = int.Parse(Console.ReadLine());
        int Py1 = int.Parse(Console.ReadLine());
        int Px2 = int.Parse(Console.ReadLine());
        int Py2 = int.Parse(Console.ReadLine());
        int Fx = int.Parse(Console.ReadLine());
        int Fy = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int left;
        int top;
        int right;
        int bottom;
      
        int damage = 0;

        left = Math.Min(Px1, Px2);
        right = Math.Max(Px1, Px2);
        top = Math.Max(Py1, Py2);
        bottom = Math.Min(Py1, Py2);

        Fx = Fx + D;
      
        if (Fx >= left && Fx <= right && Fy >= bottom && Fy <= top)
            damage += 100;
        if (Fx >= left && Fx <= right && Fy + 1 >= bottom && Fy + 1 <= top)
            damage += 50;
        if (Fx >= left && Fx <= right && Fy - 1 >= bottom && Fy - 1 <= top)
            damage += 50;
        if (Fx + 1 >= left && Fx + 1 <= right && Fy >= bottom && Fy <= top)
            damage += 75;
       
        Console.WriteLine(damage + "%");
    }
}

