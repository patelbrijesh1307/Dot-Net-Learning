using System;

namespace Learning

{
    public struct Employess
    {
        private int _id;
        private string _name;
        private float _RollNo;


        public int ID { get; set; }
        public string NAME { get; set; }
        public float RollNo { get; set; }

        //public Employess(int Id, float RollNo, string Name)
        //{
        //    _id = Id;
        //    _name = Name;
        //    _RollNo = RollNo;
        //}


        public void PrintEmployess()
        {
            Console.WriteLine("Employee ID = {0} \nEmployee Number = {1} \nEmployee Name = {2}", ID, RollNo, NAME);
            Console.ReadLine();
        }
    }
    class @struct
    {
    }
}
