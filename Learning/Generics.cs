using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Generics
    {
        Calcutor calcutor = new Calcutor();
        
    }

    public class Calcutor
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello from Virtual");
        }
   
       
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);

        }
    }

    public class Voloume
    {
        public string name { get; set; }
    }
}

// Put in the Program Main Functions Direclty
            //bool Equal = Calcutor.AreEqual<int>(4, 4);
            //if (Equal)
            //{
            //    Console.WriteLine("Equals");
            //    Console.ReadLine();

            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //    Console.ReadLine();

            //}
            //bool StringEqual = Calcutor.AreEqual<string>("Hello", "hello");
            //if (StringEqual)
            //{
            //    Console.WriteLine("Equals");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //    Console.ReadLine();
            //}