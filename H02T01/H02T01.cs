using System;
using System.Globalization;

class H02T01
{
    public static void Main()
    {
        decimal[] tuoteHinta = {120, 94.90M, 20.90M };
        int[] tuoteLkm = { 6, 2, 3 };
        decimal[] tuoteYhtHinta = new decimal[3];

        tuoteYhtHinta[0] = tuoteHinta[0] * tuoteLkm[0];
        tuoteYhtHinta[1] = tuoteHinta[1] * tuoteLkm[1];
        tuoteYhtHinta[2] = tuoteHinta[2] * tuoteLkm[2];

        Console.WriteLine("Tuotteen 1 yhteishinta on " + tuoteYhtHinta[0].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
        Console.WriteLine("Tuotteen 2 yhteishinta on " + tuoteYhtHinta[1].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
        Console.WriteLine("Tuotteen 3 yhteishinta on " + tuoteYhtHinta[2].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
    }

}