using System;

class H03T01
{
    public static void Main()
    {
        Random satunnaisluku = new Random();
        int arvonta = 1 + satunnaisluku.Next(100);
        string ohje = "Arvaa oikea kokonaisluku väliltä 1-100 : ";
        string suurempi = "Arvaamasi luku oli suurempi kuin arvottu luku";
        string pienempi = "Arvaamasi luku oli pienempi kuin arvottu luku";
        double num1;

        Console.Write(ohje);
        num1 = double.Parse(Console.ReadLine());

        while ((num1 < arvonta) || (num1 > arvonta)) {

            if (num1 > arvonta) {
                Console.WriteLine(suurempi);
                Console.WriteLine(ohje);
            }
            if (num1 < arvonta) {
                Console.WriteLine(pienempi);
                Console.WriteLine(ohje);
            }
            num1 = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Arvaamasi luku oli oikein, onnittelut!");
    }
 }