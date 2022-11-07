using System;
using System.Globalization;

class H01T05
{
    public static void Main()
    {
        string[] tuote = { "Jäätelö", "Kahvi", "Pulla" };
        double[] hinta = { 3.57, 2.45, 9.99 };

        Console.WriteLine(tuote[0]+"n hinta on " + hinta[0].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
        Console.WriteLine(tuote[1]+"n hinta on " + hinta[1].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
        Console.WriteLine(tuote[2]+"n hinta on " + hinta[2].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
    }

}