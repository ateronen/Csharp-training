using System;
class Jana
{
    public string teksti;

    private int pituus;

    public Jana()
    {
        Console.WriteLine("Jana on luotu");
    }
    // MUISTA: Void EI palauta arvoa vaan on "tyhjä"
    public void AsetaPituus(int pituus)
    {
        this.pituus = pituus;
    }
    // MUISTA: Arvon palauttamiseen käytetään metodia, jolle on määritetty tyyppi. 
    public int NoudaPituus()
    {
        return pituus;
    }
}
class H04T03
{    
    //PÄÄOHJELMA
    static void Main()
    {
        Jana jana = new Jana();
        jana.AsetaPituus(6);
        Console.WriteLine("Janan pituus on " + jana.NoudaPituus());
    }
}