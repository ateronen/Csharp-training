using System;
using System.Globalization;
using System.Text;

class H03T07
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
        double pun;
        double sivu;

        Console.WriteLine("Anna ympyrän säteen pituus (cm): ");
        double sade = double.Parse(Console.ReadLine());

        ympyra = Math.PI * (Math.Pow(sade, 2));
        sivu = Math.Sqrt(sade*(sade/2));

        Console.WriteLine("Ympyrän pinta-ala on " + Math.Round(ympyra, 2) + " neliösenttimetriä.");
        Console.WriteLine("Neliön pinta-ala on " + Math.Round((nelio = Math.Pow((sivu * 2), 2)), 2) + " neliösenttimetriä.");
        Console.WriteLine("Punaisen alueen pinta-ala on  " + Math.Round((pun = ympyra - nelio), 2) + " neliösenttimetriä.");
    }
}