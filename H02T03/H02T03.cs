using System;
using System.Globalization;
using System.Text;

class H02T03
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


        Console.Write("Anna hinta: ");

        double hinta = double.Parse(Console.ReadLine());
        double alv = 0.22;
        double alviton = hinta/(1+alv);
        double vero = hinta - alviton;

        Console.WriteLine("Hinta ilman alvia: " + (alviton = Math.Round(alviton, 2)));

        Console.WriteLine("Alv (22%): " + (vero = Math.Round(vero, 2)));


    }
}