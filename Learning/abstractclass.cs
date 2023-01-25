using System;


namespace Learning
{
    public abstract class CustomerName 
    {
       
        public abstract void Print();

        

    }

    class CustomerExpensess : CustomerDetails
    {
        public void Print()
        {
            Console.WriteLine("This is Print Method of Abstract Class");
            Console.ReadLine();

        }

    }
    interface I1
    {
        
    }
     class abstractclass : CustomerExpensess
    {
        public void Print()
        {
            Console.WriteLine("This is Print Method of Abstract Class in Main Class");
            Console.ReadLine();

        }
    }
}
