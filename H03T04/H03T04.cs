using System;

class H03T04
{
    public static void Main(string[] args)
    {

        int n;
        int Fn = 0, Fn1 = 1;
        int FnNew = Fn + Fn1;

        string ohje1 = "Kuinka monta lukua tulostetaan Fibonacci-lukusarjasta : ";

        Console.Write(ohje1);
        n = int.Parse(Console.ReadLine());

        Console.Write(Fn + ", " + Fn1);
        
        for (int i = 3; i <=n; i++)
        {
            Console.Write(", "+ FnNew);
            Fn = Fn1;
            Fn1 = FnNew;
            FnNew = Fn + Fn1;
        }

    }
}