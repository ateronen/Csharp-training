using System;


class Laatikko
{
    // Yksityiset muuttujat
    private decimal pituus, syvyys, korkeus;
    // Julkiset muuttujat
    public decimal tilavuus;
    public string nimi;

    // Setterit  
    public void AsetaPituus(decimal pituus)
    {
        //kenttä ja parametri
        this.pituus = pituus;
    }
    public void AsetaSyvyys(decimal syvyys)
    {
        //kenttä ja parametri
        this.syvyys = syvyys;
    }
    public void AsetaKorkeus(decimal korkeus)
    {
        //kenttä ja parametri
        this.korkeus = korkeus;
    }

    //Getteri
    public void NoudaTilavuus()
    {
        // Julkinen muuttuja "tilavuus" joka lasketaan kenttiin saatujen arvojen mukaan
        decimal tilavuus = this.pituus * this.korkeus * this.syvyys;
        // "nimi"-kenttä saa arvonsa julkisesta kentästä
        System.Console.WriteLine(this.nimi + ": sen tilavuus on " + tilavuus);
    }
}
class H04T02
{
    //PÄÄOHJELMA
    static void Main()
    {
        // Uusi ilmentymä "laatikko1"
        Laatikko laatikko1 = new Laatikko();
        laatikko1.AsetaPituus(6);
        laatikko1.AsetaSyvyys(7);
        laatikko1.AsetaKorkeus(5);
        laatikko1.nimi = "laatikko1";

        // Uusi ilmentymä "laatikko2"
        Laatikko laatikko2 = new Laatikko();
        laatikko2.AsetaPituus(12);
        laatikko2.AsetaSyvyys(13);
        laatikko2.AsetaKorkeus(10);
        laatikko2.nimi = "laatikko2";

        // Ilmentymien tilavuuden noutaminen
        laatikko1.NoudaTilavuus();
        laatikko2.NoudaTilavuus();
    }
}