using System;
using System.Collections.Generic;

public delegate void SampleDelegate(out int Integer);

    class multicastdelegate
    {

    public static void SampleMethodOne()
    {
        Console.WriteLine("This Sample Method One");
    }
    public static void SampleMethodTwo()
    {
        Console.WriteLine("This Sample Method Two");
    }
    public static void SampleMethodThree()
    {
        Console.WriteLine("This Sample Method Three");
        Console.ReadLine();
    }

    public static void SampleOne(out int Number)
    {
        Number = 2;
    }

    public static void SampleTwo(out int Number)
    {
        Number = 6;
    }
}

