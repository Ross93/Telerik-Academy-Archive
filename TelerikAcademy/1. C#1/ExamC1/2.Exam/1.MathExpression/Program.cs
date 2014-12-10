using System;

class MathExpression
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal up = (n * n + (1 / (m * p)) + 1337);
        decimal down = (n - ((decimal)128.523123123 * p));
        decimal plus = (decimal)Math.Sin((int)(m % 180));
        decimal result = up / down + plus;
        Console.WriteLine(System.Math.Round(result, 6));
    }
}