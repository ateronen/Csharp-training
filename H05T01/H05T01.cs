﻿using System;
using System.Globalization;
using System.Text;

class Kirja
{
    //Kirja luokan attribuutit
    private string nimi;
    private string kirjailija;
    private string kustantaja;
    private double kappalehinta;
    private string teema;

    //Seuraavassa määritellään oletusmuodostin ilman 
    //parametreja. Metodissa parametreille annetaan omat
    //oletusarvot. 
    public Kirja()
    {
        nimi = "Ei tiedossa.";
        kirjailija = "Ei tiedossa.";
        kustantaja = "Ei tiedossa.";
        kappalehinta = 0;
        teema = "Ei saatavilla.";
    }
    //Seuraavassa määritellään muodostin luokan kaikilla 
    //attribuuteilla. 
    public Kirja(string nimi, string kirjailija, string kustantaja, double kappalehinta, string teema)
    {
        this.nimi = nimi;
        this.kirjailija = kirjailija;
        this.kustantaja = kustantaja;
        this.kappalehinta = kappalehinta;
        this.teema = teema;
    }

    //Seuraavassa määritellään muodostin, joka saa parametrina 
    //toisen Kirja-olion. 
    public Kirja(Kirja kirja1)
    {
        //Seuraavassa kirja-olion attribuuttien arvot 
        //kopioidaan kutsuvan olion attribuutteihin.
        this.nimi = kirja1.nimi;
        this.kirjailija = kirja1.kirjailija;
        this.kustantaja = kirja1.kustantaja;
        this.kappalehinta = kirja1.kappalehinta;
        this.teema = kirja1.teema;
    }

    public void TulostaTiedot()
    {
        Console.WriteLine("\tKirjan nimi: " + nimi);
        Console.WriteLine("\tKirjailija: " +
        kirjailija);
        Console.WriteLine("\tKustantaja: " +
        kustantaja);
        Console.WriteLine("\tKappalehinta: " +
        kappalehinta);
        Console.WriteLine("\tTeema: " +
        teema);
        Console.WriteLine("\t------------------------");
    }
}

class H05T01
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

        //Tässä luodaan Kirja-olio kaikilla parametreilla.
        var kirja1 = new Kirja("Harry Potter ja Viistasten kivi", "J.K. Rowling", "Kustannusosakeyhtiö Tammi", 24.90D, "Fantasia, lasten- ja nuortenkirjallisuus");
        //Tässä tulostetaan kirjan tiedot.
        kirja1.TulostaTiedot();

        //Tässä luodaan kopio kirja-oliosta.
        var kirja2 = new Kirja(kirja1);
        Console.WriteLine("\tKopioidun Kirjan tiedot:");
        kirja2.TulostaTiedot();

        //Tässä luodaan kirja3-olio.
        var kirja3 = new Kirja();
        kirja3.TulostaTiedot();

        var kirja4 = new Kirja("Tuntematon Sotilas", "Väinö Linna", "WSOY", 29.70D, "Sotakirjallisuus");
        kirja4.TulostaTiedot();
    }
}