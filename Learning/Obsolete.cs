using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Obsolete
    {

    }
    public class Add
    {
        int i;
        int k = 103;
        float e = 13.4F;

        [Obsolete("Use Multiple Varible at Time", true)]
        public static int Addition(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static int Addition(List<int> Numbers)
        {
            int sum = 0;

            foreach (int Number in Numbers)
            {
                sum = sum + Number;
            }
            return sum;
        }

    }
}
