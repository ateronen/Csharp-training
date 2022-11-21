using System;

class Jana
{
    private int pituus;
    // PARAMETRILLINEN MUODOSTIN
    public Jana(int ParamPituus)
    {
        Console.WriteLine("Jana on luotu, pituus = {0}", ParamPituus);
        // <-kenttä = parametri->
        pituus = ParamPituus;
    }
    // MUISTA: Void EI palauta arvoa vaan on "tyhjä"
    public void AsetaPituus(int ParamPituus)
    {
        pituus = ParamPituus;
    }
    // MUISTA: Arvon palauttamiseen käytetään metodia, jolle on määritetty tyyppi. 
    public int NoudaPituus()
    {
        return pituus;
    }
}
class H04T04
{
    //PÄÄOHJELMA
    static void Main()
    {
        //Uusi ilmentymä "jana" jolle asetetaan parametriksi 10. 
        Jana jana = new Jana(10);
        Console.WriteLine("Janan pituus on {0}", jana.NoudaPituus());
        jana.AsetaPituus(6);
        Console.WriteLine("Janan pituus on {0}", jana.NoudaPituus());
    }
}