using System;

class Laatikko
{
    public decimal pituus, syvyys, korkeus, tilavuus;
    public string nimi;

    public void TulostaTiedot()
    {
        decimal tilavuus = pituus * korkeus * syvyys;
        Console.WriteLine(this.nimi+": sen tilavuus on "+tilavuus);
    }

    static void Main()
    {
        Laatikko laatikko1 = new Laatikko();
        //Tässä olion attribuutit alustetaan.
        laatikko1.pituus = 6;
        laatikko1.syvyys = 7;
        laatikko1.korkeus = 5;
        laatikko1.nimi = "laatikko1";

        Laatikko laatikko2 = new Laatikko();
        //Tässä olion attribuutit alustetaan.
        laatikko2.pituus = 12;
        laatikko2.syvyys = 13;
        laatikko2.korkeus = 10;
        laatikko2.nimi = "laatikko2";

        laatikko1.TulostaTiedot();
        laatikko2.TulostaTiedot();
    }
}