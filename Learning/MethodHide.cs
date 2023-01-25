using System;


namespace Learning
{ 
    class BaseClass
{
    public virtual void print()
    {
        Console.WriteLine("This is Base Class Message");
        Console.ReadLine();
    }
}
    class DerivedClass : BaseClass
    {
        public override void print()
        {
            Console.WriteLine("This is Derived Class Message");
            Console.ReadLine();
        }
    }
    class MethodHide
    {
        
        
    }
}
