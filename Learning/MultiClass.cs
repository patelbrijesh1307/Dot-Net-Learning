using System;


namespace Learning
{
    interface IA
    {
        void Amethod();
    }
    class A : IA
    {
        public void Amethod()
        {
            Console.WriteLine("A Method");
        }
    }

    interface IB
    {
        void Bmethod();
    }
    class B : IB
    {
        public void Bmethod()
        {
            Console.WriteLine("B Method");
            Console.ReadLine();
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void Amethod()
        {
            a.Amethod();
        }
        public void Bmethod()
        {
            b.Bmethod();
        }
    }
   
    class MultiClass
    {

        
    }

    
}
