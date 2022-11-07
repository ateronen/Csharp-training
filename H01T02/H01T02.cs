using System;
class MuuttujaTyypit
{
    public static void Main()
    {
        
        Console.WriteLine("Boolean= " + true);
        sbyte shortbyte = 100;
        Console.WriteLine("Shortbyte= " + shortbyte);
        ushort unsignedshort = 4096;
        Console.WriteLine("Unsignedshort= " + unsignedshort);
        int integer = -259;
        Console.WriteLine("Integer= " + integer);
        long longinteger = 1234567890;
        Console.WriteLine("Longinteger= " + longinteger);
        float floatingpoint = 2.2f;
        Console.WriteLine("Floatingpoint= " + floatingpoint);
        double doubleprecision = 2.99999;
        Console.WriteLine("Doubleprecision= " + doubleprecision);
        decimal decimalnumber = 2.99999999999M;
        Console.WriteLine("Decimalnumber= " + decimalnumber);

    }
}