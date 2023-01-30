using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning
{
    class ListEg
    {
       

        public void Emplist()
        {

            //List<int> Number = new List<int>() { 1, 4, 3, 2, 5, 6, 8, 7, 9 };

            //Console.WriteLine("Normal Number Printing");
            //foreach(int num in Number)
            //{
            //    Console.WriteLine(num);
            //}
            //Number.Sort();
            //Console.WriteLine("Sort Number Printing");

            //foreach (int num in Number)
            //{
            //    Console.WriteLine(num);
            //}

            //Number.Reverse();
            //Console.WriteLine("Reverse Number Printing");
            //foreach (int num in Number)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.ReadLine();


            EmployeeSalary employeeSalary1 = new EmployeeSalary()
            {
                ID = 101,
                Name = "Sonu",
                Marks = 53,
                Impression = "Bad"
            };
            EmployeeSalary employeeSalary2 = new EmployeeSalary()
            {
                ID = 102,
                Name = "Monu",
                Marks = 34,
                Impression = "Bad"
            };
            EmployeeSalary employeeSalary3 = new EmployeeSalary()
            {
                ID = 103,
                Name = "Tonu",
                Marks = 76,
                Impression = "Bad"
            };
            EmployeeSalary employeeSalary4 = new EmployeeSalary()
            {
                ID = 104,
                Name = "Mark",
                Marks = 72,
                Impression = "Good"
            };
            //EmployeeSalary employeeSalary5 = new EmployeeSalary()
            //{
            //    ID = 104,
            //    Name = "Mark",
            //    Marks = 72,
            //    Impression = "Good"
            //};

            List<EmployeeSalary> employeeSalaries = new List<EmployeeSalary>(10);
            employeeSalaries.Add(employeeSalary1);
            employeeSalaries.Add(employeeSalary2);
            employeeSalaries.Add(employeeSalary3);
            employeeSalaries.Add(employeeSalary4);

            //employeeSalaries.Sort(delegate(EmployeeSalary e1, EmployeeSalary e2) { return e1.ID.CompareTo(e2.ID); });

            //IReadOnlyCollection<EmployeeSalary> realonlyEmp =  employeeSalaries.AsReadOnly();
            //Console.WriteLine(realonlyEmp.Count);
            //Console.ReadLine();

            //Before Trim
            //Console.WriteLine(employeeSalaries.Capacity);
            //employeeSalaries.TrimExcess();
            ////After Trim
            //Console.WriteLine(employeeSalaries.Capacity);
            //Console.ReadLine();

            //Console.WriteLine("Before Fillter");
            //foreach(EmployeeSalary em in employeeSalaries)
            //{
            //    Console.WriteLine(em.Name);
            //}


            //employeeSalaries.Sort();
            //Console.WriteLine("Before Fillter");
            //foreach (EmployeeSalary em in employeeSalaries)
            //{
            //    Console.WriteLine(em.Name);
            //}



            //employeeSalaries.Reverse();
            //Console.WriteLine("Before Fillter");
            //foreach (EmployeeSalary em in employeeSalaries)
            //{
            //    Console.WriteLine(em.Name);
            //}
            //Console.ReadLine();

            //List<EmployeeSalary> employeeSalariesGood = new List<EmployeeSalary>(3);
            //employeeSalariesGood.Add(employeeSalary4);
            //employeeSalariesGood.Add(employeeSalary5);


            //EmployeeSalary[] employeeSalariesArray = new EmployeeSalary[4];
            //employeeSalariesArray[0] = employeeSalary1;
            //employeeSalariesArray[1] = employeeSalary2;
            //employeeSalariesArray[2] = employeeSalary3;
            //employeeSalariesArray[3] = employeeSalary4;

            //List<EmployeeSalary> emplist = employeeSalariesArray.ToList();
            //foreach (EmployeeSalary em in employeeSalariesArray)
            //{
            //    Console.WriteLine("Name = {0}", em.Name);
            //}
            //Console.ReadLine();

            //int index = employeeSalaries.FindIndex(emp => emp.Marks > 70);
            //Console.WriteLine("Index  = " + index);
            //Console.ReadLine();

            //if (employeeSalaries.Contains(employeeSalary4))
            //{
            //    Console.WriteLine("Employee Exists");
            //}
            //else
            //{
            //    Console.WriteLine("Employee Does not Exists");
            //}
            //Console.ReadLine();




        }
    }

    class EmployeeSalary : IComparable<EmployeeSalary>
    {
        public int ID {get; set;}
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Impression { get; set; }

        public int CompareTo(EmployeeSalary other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
