using System;
using System.Globalization;
using System.Text;

class H02T04
{
    public static void Main()
    {
        Console.Write("Anna jaettava kokonaisluku: ");

        int luku = int.Parse(Console.ReadLine());

        Console.Write("Anna jakaja kokonaislukuna: ");

        int jakaja = int.Parse(Console.ReadLine());
        int tulos;

        Console.WriteLine("Jakolaskun " + luku + "/" + jakaja + " jakojäännös on " + (tulos = luku % jakaja));
    }
}