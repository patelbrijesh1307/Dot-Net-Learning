using System;

namespace Learning
{
    class ExplicitInterFaces : Tes1, Tes2
    {
         void Tes1.MethodInterface()
        {
            Console.WriteLine("This is InterFace Tes1");
            
        }
        void Tes2.MethodInterface()
        {
            Console.WriteLine("This is InterFace Tes2");
            Console.ReadLine();
        }
    }
    interface Tes1
    {
        void MethodInterface();
    }

    interface Tes2
    {
        void MethodInterface();
    }
}
