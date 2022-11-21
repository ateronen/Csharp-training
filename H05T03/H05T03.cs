using System;
using System.Globalization;
using System.Text;

class Firma
{
    private string firma_nimi;
    private string osoite;
    private string puhelin;
    private decimal tulot;
    private decimal menot;

    public Firma()
    {
        firma_nimi = "Ei tiedossa";
        osoite = "Ei tiedossa";
        puhelin = "Ei tiedossa";
        tulot = 0.0m;
        menot = 0.0m;
    }

    public Firma(string firma_nimi, string osoite, string puhelin, decimal tulot, decimal menot)
    {
        this.firma_nimi = firma_nimi;
        this.osoite = osoite;
        this.puhelin = puhelin;
        this.tulot = tulot;
        this.menot = menot;
    }

    public void TulostaTiedot()
    {
        Console.WriteLine("\tFirman nimi: " + firma_nimi);
        Console.WriteLine("\tOsoite: " +
        osoite);
        Console.WriteLine("\tPuhelin: " +
        puhelin);
        Console.WriteLine("\tTulot: " +
        Math.Round(tulot, 2) + "€");
        Console.WriteLine("\tMenot: " +
        Math.Round(menot, 2) + "€");
    }

    public void LaskeVoitto()
    {
            if ((this.tulot == 0) || (this.menot == 0))
            {
                Console.WriteLine("\tFirmalla ei ole tuloja tai menoja tai firma tekee tappiota.");
                Console.WriteLine("\t------------------------");
                return;
            }
            decimal voittopros = (this.tulot - this.menot) / this.menot * 100;
            if (voittopros > 0 && voittopros <= 200)
            {
                Console.WriteLine("\t" + this.firma_nimi + ":lla menee kehnosti.");
            }
            if (voittopros > 200 && voittopros <= 300)
            {
                Console.WriteLine("\t" + this.firma_nimi + ":lla menee tyydyttävästi.");
            }
            if (voittopros > 300)
            {
                Console.WriteLine("\t" + this.firma_nimi + ":lla menee hyvin.");
            }
        Console.WriteLine("\t------------------------");
    }
}
class H05T03
{
    static void Main()
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

        var firma1 = new Firma("Pasilan Putkityöt Oy","Radanrakentajantie 13 A 1, 00520 Helsinki","+358 10 1234567",752032.467m,331444.760m);
        firma1.TulostaTiedot();
        firma1.LaskeVoitto();

        var firma2 = new Firma("Soppa-Seppo Oy","Helsinginkatu 12 B 9, 00500 Helsinki","+358 50 1234567",61432.156m,52879.310m);
        firma2.TulostaTiedot();
        firma2.LaskeVoitto();

        var firma3 = new Firma();
        firma3.TulostaTiedot();
        firma3.LaskeVoitto();

        var firma4 = new Firma("Xcode Oy","Narinkkatori 2, 00100 Helsinki","+358 09 1234567",3537555.294m,701173.930m);
        firma4.TulostaTiedot();
        firma4.LaskeVoitto();
    }
}