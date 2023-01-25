using System;


namespace Learning
{
    public class Employee
    {

        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintEmployeeDetails()
        {
            Console.WriteLine(FirstName + " " + LastName);


        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintEmployeeDetails()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Part Time");
            //Console.ReadLine();


        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintEmployeeDetails()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Full Time");
            //Console.ReadLine();

        }
    }

    public class TemprorayEmployee : Employee
    {
        public override void PrintEmployeeDetails()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Temporary ");
            Console.ReadLine();

        }
    }

    //class OPOverloading
    //{
    //    public string str;
    //    public int num;

    //    public static OPOverloading operator + (OPOverloading OP, OPOverloading OP2)
    //    {
    //        OPOverloading OP3 = new OPOverloading();
    //        OP3.str = OP.str + " " + OP2.str;
    //        OP3.num = OP.num + OP2.num;
    //        return OP3;
    //    }
    //}


    class Polymorphism
    {
        public void Ploy()
        {
            Employee[] employess = new Employee[4];

            employess[0] = new Employee();
            employess[1] = new PartTimeEmployee();
            employess[2] = new FullTimeEmployee();
            employess[3] = new TemprorayEmployee();

            foreach (Employee e in employess)
            {
                e.PrintEmployeeDetails();
                

            }


            //OPOverloading OP = new OPOverloading();
            //OP.str = "Brijesh";
            //OP.num = 32;

            //OPOverloading OP2 = new OPOverloading();
            //OP2.str = "Patel";
            //OP2.num = 3;

            //OPOverloading OP3 = new OPOverloading();
            //OP3 = OP + OP2;

            //Console.WriteLine(OP3.str);
            //Console.WriteLine(OP3.num);
            //Console.ReadLine();

        }
    }
}
