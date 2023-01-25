using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Generics
    {
        
    }

    public class Calcutor
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);

        }
    }
}

// Put in the Program Main Functions Direclty
//bool Equal = Calcutor.AreEqual(4, 1);
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
