using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class methodoverloading
    {
        public void Add(int i , int j)
        {
            Console.WriteLine(i + j);
            Console.ReadLine();
        }
        public void Add(int i, int j,  int s)
        {
            
            Console.WriteLine(i+j+s);
            Console.ReadLine();
        }

        public void Add(int i, int j, int s, params int[] Num)
        {

            Console.WriteLine(i + j + s);
            Console.ReadLine();
        }
    }
}
