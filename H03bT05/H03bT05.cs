using System;
using System.Globalization;
using System.Text;

class H03bT05
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

        // varsinainen pääohjelma

        int pts, i, y;

        // Luetaan syöte
        Console.Write("Anna ympyrän säteen pituus (cm): ");
        double sade = int.Parse(Console.ReadLine());

        //Laskutoimitukset
        double ympyra = Math.PI * (Math.Pow(sade, 2));
        double katA = Math.Sqrt(sade * (sade / 2));

        double sqrIn = Math.Pow((katA * 2), 2);

        //sqrIn = ympyra - katA;

        double sqrOut = Math.Pow((sade * 2), 2);
        sqrOut = s - ympyra;
    }
}