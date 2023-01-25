using System;
using Learning;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

namespace Learning
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            //bool Equal = Calcutor.AreEqual<int>(4, 4);
            //if (Equal)
            //{
            //    Console.WriteLine("Equals");
            //    Console.ReadLine();

            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //    Console.ReadLine();

            //}
            bool StringEqual = Calcutor.AreEqual<string>("Hello", "hello");
            if (StringEqual)
            {
                Console.WriteLine("Equals");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Equals");
                Console.ReadLine();
            }






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

            //Exception Handling
            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader(@"D:\Demo.txt");
            //    Console.WriteLine(streamReader.ReadToEnd());
            //    Console.ReadLine();
            //}
            //catch (FileNotFoundException exp)
            //{
            //    Console.WriteLine(exp.Message);
            //    Console.ReadLine();
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine(exc.Message);
            //    Console.ReadLine();
            //}
            //finally
            //{
            //    if (streamReader != null)
            //    {
            //        streamReader.Close();
            //    }
            //}


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



            //int num1 = 20;
            //int num2 = 23;

            //if (num1 == 20 || num2 == 21)
            //{
            //    Console.WriteLine("This is True");
            //    Console.ReadLine();
            //}

            //Ternary Operator
            //int x = 14;
            //bool isNumber = x == 10 ? true : false;
            //Console.WriteLine(isNumber);
            //Console.ReadLine();

            //Nullable Type    
            //bool? majorAns = false;
            //if (majorAns == true)
            //{
            //    Console.WriteLine("User is Major");
            //}
            //else if (majorAns == false)
            //{
            //    Console.WriteLine("User is Not Major");
            //}
            //else
            //{
            //    Console.WriteLine("User is not selected anything");
            //}
            //Console.ReadLine();

            //Nullable Coalescing Operators
            //int? TickestonSale = null;
            //int AvaialableTickest = TickestonSale ?? 0;
            //Console.WriteLine("Avaialable Tickest is = {0}", AvaialableTickest);
            //Console.ReadLine();

            //int[] users = new int[5];

            //users[0] = 01;
            //users[1] = 02;
            //users[2] = 03;
            //users[3] = 02;
            //users[4] = 03;

            //19th Jan 2023

            //Console.WriteLine("Please Enter a Number to Check ");
            //int num1 = int.Parse(Console.ReadLine());
            ////int num1 = 2;

            //if (num1 == 1)
            //{
            //    Console.WriteLine("Your Number is One ");
            //}
            //else if(num1 == 2)
            //{
            //    Console.WriteLine("Your Number is Two");
            //}
            //else if (num1 == 3)
            //{
            //    Console.WriteLine("Your Number is Three");
            //}
            //else
            //{
            //    Console.WriteLine("Your Number is not betwween One to Three");
            //}
            //Console.ReadLine();



            //EvenNumbers
            //int startingNumber = 0;
            //Console.WriteLine("Enter the Target Number");
            //int targetNumber = Convert.ToInt32(Console.ReadLine());

            //while (startingNumber <= targetNumber)
            //{
            //    Console.WriteLine(startingNumber);
            //    startingNumber = startingNumber + 2;
            //}

            //Console.ReadLine();
            //string userChoice = string.Empty;
            //do
            //{
            //    int startingNumber = 0;
            //    Console.WriteLine("Enter the Target Number");
            //    int targetNumber = Convert.ToInt32(Console.ReadLine());

            //    while (startingNumber <= targetNumber)
            //    {
            //        Console.WriteLine(startingNumber);
            //        startingNumber = startingNumber + 2;
            //    }
            //    do
            //    {
            //        Console.WriteLine("Do You Want Some More Even Number to Check \n Yes \n No");
            //        userChoice = Console.ReadLine().ToUpper();
            //        if (userChoice != "YES" && userChoice != "NO")
            //        {
            //            Console.WriteLine("Invalid action has been selected Please Select Yes or No");

            //        }
            //    } while (userChoice != "YES" && userChoice != "NO");
            //} while (userChoice == "YES");


            //while loop with array

            //int[] Numbers = new int[5];

            //Numbers[0] = 101;
            //Numbers[1] = 102;
            //Numbers[2] = 103;
            //Numbers[3] = 104;
            //Numbers[4] = 105;

            //int i = 0;

            //while(i < Numbers.Length)            {
            //    Console.WriteLine(Numbers[i]);
            //    i++;
            //}

            //Console.ReadLine();

            //for loop eg
            //for (int j = 0; j < Numbers.Length; j++)
            //{
            //    Console.WriteLine(Numbers[j]);
            //}
            //Console.ReadLine();

            //FOR EACH LOOP Eg

            //foreach(int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //foreach WITH STRINGS ARRAYS
            //string[] UserNames = new string[5];

            //UserNames[0] = "Admin";
            //UserNames[1] = "Suppport";
            //UserNames[2] = "Backend";
            //UserNames[3] = "Fornetend";

            //foreach (string k in UserNames)
            //{
            //    Console.WriteLine(k);
            //}
            //Console.ReadLine();

            //LOOP Break 
            //for (int l = 0; l <= 14; l++)
            //{
            //    Console.WriteLine(l);
            //    if (l == 8)
            //        break;
            //}

            //Console.ReadLine();

            //LOOP Continue Keywords
            //for (int i = 0; i <= 20; i++)
            //{
            //    if ( i % 2 == 1)
            //    continue;
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //Calling instance method or Functions 
            //Program p = new Program();
            //p.EvenNumbers();

            //Calling Static Methods or Functions

            //Program.EvenNumbers(140);

            //Program p = new Program();
            //int Addition = p.add(123, 31);
            //Console.WriteLine("Sum of Two Numbers is = {0}", Addition);


            //Pass By Value
            //int k = 123;
            //Program.SimpleMethod(k);
            //Console.WriteLine(k);
            //Console.ReadLine();


            ////Pass By Reference 
            //int i = 12;
            //SimpleMethod(ref i);
            //Console.WriteLine(i);
            //Console.ReadLine();

            //Pass By OutPut Parameter
            //int Total = 0;
            //int Multiply = 0;
            //SimpleMethod(12, 14, out Total, out Multiply);
            //Console.WriteLine("The Total = {0} and Multiply = {1}", Total, Multiply);
            //Console.ReadLine();


            // Parameter Arrays
            //int[] Num = new int[3];

            //Num[0] = 100;
            //Num[1] = 101;
            //Num[2] = 102;

            //ArrayParameter(Num);

            //NAMESPACE calling

            //Fecth.UserFetch();
            //Fecth.UserFetch();

            //CALL a Class that contain Counstuctor and Method
            //Constructor Overloading also knowns as using two Constructor in same Class
            //Constructor without any arguments
            //Customer C = new Customer();
            //C.FullName();

            //Constructor with any arguments
            //Customer P = new Customer("Atrina", "Atri");
            //P.FullName();

            //Circle C = new Circle(4);
            //C.CalculateCircle();


            //Circle D = new Circle(5);
            //D.CalculateCircle();

            //Circle E = new Circle(6);
            //E.CalculateCircle();
        }

        //public static void Hindi(string strMessage)
        //{
        //    Console.WriteLine(strMessage);

        //}

        //public static void HindiString(string message)
        //{
        //    Console.WriteLine(message);
        //    Console.ReadLine();
        //}

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
 









