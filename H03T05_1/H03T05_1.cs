using System;

class H03T05
{
    static void Main(string[] args)
    {
        double limiter = 100;
        double sumTotal = 0;
        double feed = 0;

        Console.WriteLine("Syötä kokonaislukuja, kunnes lukujen summa on suurempi kuin 100.");

        for (int i = 1; i <= limiter; i++)
        {
            Console.Write("Anna "+i+". kokonaisluku : ");
            feed = double.Parse(Console.ReadLine());
            sumTotal = sumTotal + feed;
            if (sumTotal >= limiter)
            {
                Console.WriteLine("Summa on 100. Raja on saavutettu ja ohjelma päättyy");
                break;
            }
            Console.WriteLine("Summa on tällä hetkellä " + sumTotal);
        }
    }
}