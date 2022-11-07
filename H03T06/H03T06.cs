using System;
using System.Globalization;
using System.Text;

class H03T06
{
    static void Main(string[] args)
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

        double nelio;
        double ympyra;
        double kelt;
        double sumTotal = 0;

        Console.WriteLine("Anna ympyrän säteen pituus (cm): ");
        double sade = double.Parse(Console.ReadLine());

        nelio = Math.Pow((sade * 2),2);
        ympyra = Math.PI * (Math.Pow(sade, 2));
        kelt = nelio - ympyra;

        Console.WriteLine("Neliön pinta-ala on "+ Math.Round(nelio, 2) + " neliösenttimetriä.");
        Console.WriteLine("Ympyrän pinta-ala on " + Math.Round(ympyra, 2) + " neliösenttimetriä.");
        Console.WriteLine("Keltaisen alueen pinta-ala on " + Math.Round(kelt, 2) + " neliösenttimetriä.");
    }
}