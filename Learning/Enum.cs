using System;


namespace Learning
{
    public class EnumCustomers
    {
        public static void Ecustomer()
        {
            Enum[] customer = new Enum[3];

            customer[0] = new Enum
            {
                Name = "Mark",
                Gender = Gender.Unknown
            };
            customer[1] = new Enum
            {
                Name = "Nicole",
                Gender = Gender.Female
            };
            customer[2] = new Enum
            {
                Name = "Ashley",
                Gender = Gender.Male
            };

            foreach (Enum cust in customer)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", cust.Name, Getgender(cust.Gender));
            }
            Console.ReadLine();
        }

        public static string Getgender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "This is an Invalid Gender";
            }
        }
    }
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    //Unkown = 0
    // Male = 1 
    // Femal = 2
    public class Enum
    {
        public string Name { set; get; }
        public Gender Gender { set; get; }
    }
}
