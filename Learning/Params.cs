using System;
using System.Runtime.InteropServices;
namespace Learning
{
    class Params
    {
    }

    public class NumbersAdditions{


        public static void MultiNumbersAdditions(int i, int j, [Optional] int[] MoreNumbers)
        {
            int result = i + j;
            if (MoreNumbers != null)
            {
                foreach(int num in MoreNumbers)
                {
                    result += num;
                }   
            }
            Console.WriteLine("Sum of = " + result);
            Console.ReadLine();
        }
        }

    public class CodeSnippet
    {
        
    }
}
