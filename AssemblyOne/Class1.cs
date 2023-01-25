using System;
using AssemblyTwo;


namespace AssemblyOne
{
    public class Class1 
    {
        
    }

    public class A2 : A1
    {
        public void Methods()
        {
            base.id = 12031;

            A2 a2 = new A2();
            a2.id = 1231;  


        }
    }
}
