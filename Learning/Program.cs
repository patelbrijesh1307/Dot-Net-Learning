using System;
using Learning;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

namespace Learning
{
    public class Program
    {
        

        public static void Main(string[] args)
        {

            //Params Function calling with Multiple Numbers to add
            //NumbersAdditions numbersAdditions = new NumbersAdditions();
            NumbersAdditions.MultiNumbersAdditions(10, 13);

            //Partialmain partialmain = new Partialmain();
            //partialmain.FirstName = "Mark";
            //partialmain.LastName = "Jesior";
            //partialmain.PrintFullName();


            //StringBuilder stringBuilder = new StringBuilder("Welcome to the StringBilder Topics");
            //stringBuilder.AppendLine();
            //stringBuilder.Append('-', 10);
            //stringBuilder.Append("String Builder");
            //stringBuilder.Append('-', 10);
            //Console.WriteLine(stringBuilder);
            //Console.ReadLine();

            //BuilderString.Builder();

            //Reflection ExampleS
            //Type T = Type.GetType("Learning.Add");
            //Console.WriteLine("Full Name = {0}", T.FullName);
            //Console.WriteLine("Full NameSpace = {0}", T.Namespace);


            //Console.WriteLine("Properties in Add");
            //MethodInfo[] methods = T.GetMethods();
            //foreach(MethodInfo method in methods)
            //{
            //    Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            //    Console.ReadLine();
            //}

            //ConstructorInfo[] constructors = T.GetConstructors();
            //foreach(ConstructorInfo constructor in constructors)
            //{
            //    Console.WriteLine(constructor.ReflectedType.Name + " " + constructor.Name);
            //    Console.ReadLine();
            //}

            //Attributes in Obsolete
            //Add.Addition();
            //Add.Addition(new List<int>() { 10, 304, 21 });

            //Enum Example 
            //EnumCustomers.Ecustomer();

            //Custom Exception With Example


            //INNER Exception Example
            //InnerExp.AddExp();




            //MulticastDelegate Problems
            //SampleDelegate del = new SampleDelegate(SampleOne);
            //del += SampleTwo;
            //int OutpulDelegate = -1;
            //del(out OutpulDelegate);
            //Console.WriteLine("This is Delegate Value {0}", OutpulDelegate);
            //Console.ReadLine();

            //MulticastDelegate Example
            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree);

            //del4 = del1 + del2 + del3 - del2;
            //del4();

            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del += SampleMethodTwo;
            //del += SampleMethodThree;
            //del();

            // Delegate with RealTime Problem

            //List<Student> Studlist = new List<Student>();
            //Studlist.Add(new Student() { ID = 10, Name = "Mark ", CurrentStd = 3, Marks = 48 });
            //Studlist.Add(new Student() { ID = 11, Name = "Jhon ", CurrentStd = 4, Marks = 40 });
            //Studlist.Add(new Student() { ID = 12, Name = "Nicole ", CurrentStd = 5, Marks = 86 });
            //Studlist.Add(new Student() { ID = 13, Name = "Alana ", CurrentStd = 3, Marks = 129 });
            //Studlist.Add(new Student() { ID = 14, Name = "Justn ", CurrentStd = 2, Marks = 70 });
            //Studlist.Add(new Student() { ID = 15, Name = "Ashley ", CurrentStd = 1, Marks = 45 });

            //Student ST = new Student();
            //ST.Promotetonextstd(Studlist, stud => stud.Marks >= 45);
            //Student.Promotetonextstd(Studlist, stud => stud.Marks >= 45);

            //Delegate Example
            //DelegatePoint del = new DelegatePoint(Hindi);
            //del("Delegate Point is Working");
            //DelegateHindi del1 = new DelegateHindi(HindiString);
            //del1("This is from HindiString Delegate");

            //Abstract Class Example 
            //CustomerExpensess CE = new CustomerExpensess();
            //CE.Print();
            //abstractclass AC = new abstractclass();
            //AC.Print();

            //Multipule Class Inheritance With InterFaces
            //AB ab = new AB();
            //ab.Amethod();
            //ab.Bmethod();

            //Interface With Example 
            //CustomerDetails CD = new CustomerDetails();
            //CD.Print();
            //CD.ImportatorMethod();
            //ExplicitInterFaces WW = new ExplicitInterFaces();
            //((Tes1)WW).MethodInterface();
            //((Tes2)WW).MethodInterface();

            ////MethodOverlaoding
            //methodoverloading MO = new methodoverloading();
            //MO.Add(2, 4, 5);

            ////Method Hiding
            //BaseClass B = new BaseClass();
            //B.print();

            ////Polymorphism Eg
            //Polymorphism P = new Polymorphism();
            //P.Ploy();

            //Properties
            //Students PB = new Students();
            //PB.SetID(134);
            //PB.SetName("Mark");
            //Console.WriteLine("The ID = {0} && Name = {1} ", PB.GetID(), PB.GetName());
            //Console.ReadLine();

            //Getter and Setter Accessors
            //StudentInformation SI = new StudentInformation();
            //SI.ID = 123;
            //SI.Name = "Mark";
            //SI.Email = "admin@arina.com";
            //Console.WriteLine("ID is = {0} && Name = {1} && Marks = {2} Email = {3}", SI.ID, SI.Name, SI.Marks, SI.Email);
            //Console.ReadLine();

            //Writing Line and Taking User Feed
            //Console.WriteLine("Enter the Fist Number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 + num2);
            //Console.ReadLine();

            //int x = 42;
            //x++;
            //Console.WriteLine(x);
            //Console.ReadLine();

            //int x = 30;
            //x &= 4;
            //Console.WriteLine(x);
            //Console.ReadLine();


            //int x = 23;
            //int y = 231;
            //Console.WriteLine(x != y);
            //Console.ReadLine();

            //const int x = 23;
            //Console.WriteLine(!(x > 26  && x < 21));
            //Console.ReadLine();

            //Ternary Operator
            //int x = 14;
            //bool isNumber = x == 10 ? true : false;
            //Console.WriteLine(isNumber);
            //Console.ReadLine();








        }

      
        

    }

    

    

    

}
 









