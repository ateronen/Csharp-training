using System;
using System.Collections;
using System.Reflection;
using System.Text;

class H03bT02
{
    static void Main(string[] args)
    {
        Random randm = new Random();
        int num;
        int i;

        Console.Write("Anna lukualueen minimi (>0): ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Anna lukualueen maksimi (<1000): ");
        int max = int.Parse(Console.ReadLine());

        Console.Write("Anna lukujen määrä väliltä 1-100: ");
        int rand = int.Parse(Console.ReadLine());
        int[] randoms = new int[rand];

        if ((min < 0 || min > 999) || (max > 1000 || max < min))
        {
            Console.WriteLine("Lukualue ei täsmää... Anna uusi lukualueen minimi ja/tai maksimi: ");
            Console.Write("Anna lukualueen minimi (>0): ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Anna lukualueen maksimi (<1000): ");
            max = int.Parse(Console.ReadLine());

        }

        for (i = 1; i <= randoms.Length; i = i + 1)
        {
            num = randm.Next(min, max);
            Console.WriteLine(i + ". numero on: " + num);
        }
    }
}