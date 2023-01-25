using System;
using System.Collections.Generic;


//public delegate void DelegatePoint(string Message);
//public delegate void DelegateHindi(string sMessage);
class Delegates
{
    //DelegatePoint del = new DelegatePoint(Hindi);
    //DelegateHindi del1 = new DelegateHindi(HindiString);

    //public static void HindiString(string message)
    //{
    //    Console.WriteLine(message);
    //    Console.ReadLine();
    //}

    //public static void Hindi(string strMessage)
    //{
    //    Console.WriteLine(strMessage);

    //}
}

public delegate bool PromotedStudents(Student stud);

public class Student

{
    

    public int ID { get; set; }
    public string Name { get; set; }
    public int CurrentStd { get; set; }
    public float Marks { get; set; }


    public void Promotetonextstd(List<Student> stulist, PromotedStudents promotedstudents)
    {
        foreach (Student student in stulist)
        {
            if (promotedstudents(student))
            {
                Console.WriteLine(student.Name + "Promoted to Next Standerd");
                
            }

        }
        Console.ReadLine();
    }

    }










