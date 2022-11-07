using System;
using System.Globalization;

class H01T06
{
    public static void Main()
    {
        decimal[][] lampotilat = new decimal[3][];

        lampotilat[0] = new decimal[1];

        lampotilat[0][0] = -1.4m;

        lampotilat[1] = new decimal[2];

        lampotilat[1][0] = 4.4m;
        lampotilat[1][1] = 2.8m;

        lampotilat[2] = new decimal[3] {-6.2m, -3.1m, 0.0m};

        for (int i = 0; i < lampotilat[0].Length; i++)
        {
            System.Console.WriteLine(lampotilat[0][i].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
        }

        for (int i = 0; i < lampotilat[1].Length; i++)
        {
            System.Console.WriteLine(lampotilat[1][i].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
        }

        for (int i = 0; i < lampotilat[2].Length; i++)
        {
            System.Console.WriteLine(lampotilat[2][i].ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
        }

    }
}