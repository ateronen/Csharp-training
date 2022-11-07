using System;

class H03T02
{
    public static void Main(string[] args)
    {
        string ohje1 = "Anna kokonaisluku : ";
        string ohje2 = "Anna toinen kokonaisluku : ";
        double summa = 0;
        double num1;
        double num2;

        Console.Write(ohje1); 
        num1 = double.Parse(Console.ReadLine());
        Console.Write(ohje2);
        num2 = double.Parse(Console.ReadLine());

        double y = num1 + 1;
        double x = num2 - 1;

        for (double i = y; i <= x; i = i + 1)
        {
            summa = summa + i;
        }
        Console.WriteLine("Lukujen " + num1 + " ja " + num2 + " välillä olevien kokonaislukujen summa on " + summa);
    }
}