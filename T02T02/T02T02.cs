using System;
using System.Globalization;
using System.Text;

class H02T02
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Vaihdetaan kulttuuri suomeksi
        CultureInfo culture;
        if (Thread.CurrentThread.CurrentCulture.Name == "fi-Fi")
            culture = CultureInfo.CreateSpecificCulture("en-US");
        else
            culture = CultureInfo.CreateSpecificCulture("fi-Fi");

        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;


        Console.WriteLine("Anna ensimmäinen numero");

        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen numero");

        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ensimmäinen luku on " + num1);
        Console.WriteLine("Toinen luku on " + num2);

        num1 = Math.Round(num1, 2);
        num2 = Math.Round(num2, 2);
        double vastaus;

        Console.WriteLine(num1 + " + " + num2 + " = " + (vastaus = Math.Round(num1 + num2, 2)));
        Console.WriteLine(num1 + " - " + num2 + " = " + (vastaus = Math.Round(num1 - num2, 2)));
        Console.WriteLine(num1 + " * " + num2 + " = " + (vastaus = Math.Round(num1 * num2, 2)));
        Console.WriteLine(num1 + " / " + num2 + " = " + (vastaus = Math.Round(num1 / num2, 2)));
    }
}