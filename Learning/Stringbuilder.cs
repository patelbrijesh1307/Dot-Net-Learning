using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Stringbuilder
    {


    }

    public class BuilderString
    {

        public static void Builder()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            string numbers = Console.ReadLine();
            string[] numbersList = numbers.Split('-');
            int[] numbersInt = Array.ConvertAll(numbersList, int.Parse);

            bool isConsecutive = true;
            for (int i = 1; i < numbersInt.Length; i++)
            {
                if (numbersInt[i] - numbersInt[i - 1] != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            if (isConsecutive)
            {
                Console.WriteLine("The numbers are consecutive.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The numbers are not consecutive.");
                Console.ReadLine();
            }
        }
    }
}