using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Queue
    {
        public static void BookPrice()
        {
            BooksDetails BooksDetails1 = new BooksDetails()
            {
                ID = 101,
                NAME = "Book1",
                PRICE = 345
            };
            BooksDetails BooksDetails2 = new BooksDetails()
            {
                ID = 102,
                NAME = "Book2",
                PRICE = 325
            };
            BooksDetails BooksDetails3 = new BooksDetails()
            {
                ID = 103,
                NAME = "Book3",
                PRICE = 432
            };
            BooksDetails BooksDetails4 = new BooksDetails()
            {
                ID = 104,
                NAME = "Book4",
                PRICE = 505
            };

            //Queue<BooksDetails> queueBooks = new Queue<BooksDetails>();
            //queueBooks.Enqueue(BooksDetails1);
            //queueBooks.Enqueue(BooksDetails2);
            //queueBooks.Enqueue(BooksDetails3);
            //queueBooks.Enqueue(BooksDetails4);


            //BooksDetails B =  queueBooks.Peek();
            //Console.WriteLine(B.ID + " - " + B.NAME);
            //Console.WriteLine("Total Number of Books are available in Queue = " + queueBooks.Count);
            //Console.ReadLine();


            //Stack Queue

            Stack<BooksDetails> stackbooks = new Stack<BooksDetails>();

            stackbooks.Push(BooksDetails1);
            stackbooks.Push(BooksDetails2);
            stackbooks.Push(BooksDetails3);
            stackbooks.Push(BooksDetails4);

            //BooksDetails B = stackbooks.Pop();
            //Console.WriteLine(B.ID + " - " + B.NAME + " - " + B.PRICE);
            //Console.WriteLine(stackbooks.Count);
            ////Console.ReadLine();

            //BooksDetails B1 = stackbooks.Pop();
            //Console.WriteLine(B1.ID + " - " + B1.NAME + " - " + B1.PRICE);
            //Console.WriteLine(stackbooks.Count);
            ////Console.ReadLine();

            //BooksDetails B3 = stackbooks.Pop();
            //Console.WriteLine(B3.ID + " - " + B3.NAME + " - " + B3.PRICE);
            //Console.WriteLine(stackbooks.Count);
            ////Console.ReadLine();

            //BooksDetails B4 = stackbooks.Pop();
            //Console.WriteLine(B4.ID + " - " + B4.NAME + " - " + B4.PRICE);
            //Console.WriteLine(stackbooks.Count);
            //Console.ReadLine();

        }
    }

    class BooksDetails
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int PRICE { get; set; }
    }
}
