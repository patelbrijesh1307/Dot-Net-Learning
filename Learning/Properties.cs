using System;


namespace Learning
{
    //public class ParentClass
    //{
    //    public ParentClass()
    //    {
    //        //Console.WriteLine("Parent Class Constructor");
    //        //Console.ReadLine();
    //    }
    //    public ParentClass(string Message)
    //    {
    //        Console.WriteLine(Message);
    //        Console.ReadLine();
    //    }
    //}
    //public class ChildClass : ParentClass
    //{
    //    public ChildClass() 
    //    {
    //        Console.WriteLine("Child Class Constructor");
    //        Console.ReadLine();
    //    }
    //}

    public class Students
{
       private int _id;
       private string _Name;

        public void SetID(int Id )
        {

            if (Id <= 0)
            {
                throw new Exception("ID should be in Positive Number");
            }
            this._id = Id;
        }

        public int GetID()
        {
            return this._id;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name should not be Null");
            }
            this._Name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
}



    class Properties
    {
       
        
    }
}
