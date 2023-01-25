using System;
using System.IO;
namespace Learning
{
    class InnerExp
    {
        
        public static void AddExp()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the First Number");
                    int FN = Convert.ToInt32(Console.ReadLine()); 

                    Console.WriteLine("Enter the Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);

                }
                catch (Exception ex)
                {

                    string filepath = @"D:\Log.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter SW = new StreamWriter(filepath);
                        SW.Write(ex.GetType().Name);
                        SW.WriteLine();
                        SW.Write(ex.Message);
                        SW.Close();
                        Console.WriteLine("There is problem Please Try Again");
                        
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + " is not Presented in FilePath", ex);
                    }
                }
            }
            catch(Exception Exp)
            {
                Console.WriteLine("The Current Excetion is = {0}", Exp.GetType().Name);
                if (Exp.InnerException != null)
                {
                    Console.WriteLine("The Inner Exception is = {0}", Exp.InnerException.GetType().Name);
                }
                Console.ReadLine();
            }
    }
   
    }
    class ineerExp
    {

    }
}
