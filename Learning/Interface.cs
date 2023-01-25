using System;

namespace Learning
{
    interface Customer
    {
        void Print();
    }
    interface Importator : Customer
    {
        void ImportatorMethod();
    }
    class CustomerDetails : Importator
    {
        public void Print()
        {
            Console.WriteLine("This is the method Implementation which is present in InterFace");

        }
        public void ImportatorMethod()
        {
            Console.WriteLine("This is Second InterFace Message");
            Console.ReadLine();
        }
    }

    class Interface
    {
    }
}
