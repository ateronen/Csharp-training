using System;
using System.Globalization;
using System.Text;

class H02T05
{
    public static void Main()
    {
        Console.Write("Anna ensimmäinen luku ");

        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Anna toinen luku ");

        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.Write("Ensimmäinen luku " + num1 + " on suurempi kuin jälkimmäinen luku " + num2);
        }
        if (num1 < num2)
        {
            Console.Write("Ensimmäinen luku " + num1 + " on pienempi kuin jälkimmäinen luku " + num2);
        }
        else if (num1 == num2)
        {
            Console.Write("Ensimmäinen luku " + num1 + " on yhtäsuuri kuin jälkimmäinen luku " + num2);
        }
    }
}