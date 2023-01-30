using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning
{
    class Dictionary
    {
        public void StuMarksDic()
        {
            StudentsMark StudentsMark1 = new StudentsMark()
            {
                ID = 101,
                Name = "Sonu",
                Marks = 53
            };
            StudentsMark StudentsMark2 = new StudentsMark()
            {
                ID = 102,
                Name = "Monu",
                Marks = 34
            };
            StudentsMark StudentsMark3 = new StudentsMark()
            {
                ID = 103,
                Name = "Tonu",
                Marks = 87
            };

            //Dictionary<int, StudentsMark> dictionaryMarks = new Dictionary<int, StudentsMark>();
            //dictionaryMarks.Add(StudentsMark1.ID, StudentsMark1);
            //dictionaryMarks.Add(StudentsMark2.ID, StudentsMark2);
            //dictionaryMarks.Add(StudentsMark3.ID, StudentsMark3);

            //foreach (KeyValuePair<int, StudentsMark> keyValuePair in dictionaryMarks)
            //{
            //    StudentsMark cust = (keyValuePair.Value);
            //    Console.WriteLine("ID = {0}, NAME = {1}, MARKS = {2}", cust.ID, cust.Name, cust.Marks);
            //}
            //Console.ReadLine();

            //Console.WriteLine(dictionaryMarks.Remove(103));
            //Console.ReadLine();

            //StudentsMark[] studentsMarksarray = new StudentsMark[3];
            //studentsMarksarray[0] = StudentsMark1;
            //studentsMarksarray[1] = StudentsMark2;
            //studentsMarksarray[2] = StudentsMark3;

            //Dictionary<int, StudentsMark> stuentsMarksDic = studentsMarksarray.ToDictionary(studentsMarks => studentsMarks.ID, studentsMarks => studentsMarks);
            //foreach(KeyValuePair<int, StudentsMark> kvp in stuentsMarksDic)
            //{
            //    Console.WriteLine("Key = {0}", kvp.Key);
            //    StudentsMark studentsDet = kvp.Value;
            //    Console.WriteLine("NAME = {1} MARKS = {3}", studentsDet.Name, studentsDet.Marks);
            //}

            //Console.ReadLine();
            

      


        }
    }

    class StudentsMark
    {
        public int ID {get; set;}
        public string Name { get; set; }
        public int Marks { get; set; }
    }
}

