using System;

namespace AssemblyTwo
{

    public class A1
    {
       protected internal int id = 1012;
    }
    public class Class1
    {
        public void Print()
        {
            A1 a1 = new A1();
            Console.WriteLine(a1.id);
        }
    }
}
