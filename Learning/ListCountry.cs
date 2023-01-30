using System;
using System.Collections.Generic;

namespace Learning
{
    class ListCountry
    {
        public static void CountryCap()
        {

            CountryDetails Country1 = new CountryDetails() { ID = "IND", NAME = "INDIA", CAPITAL = "DELHI" };
            CountryDetails Country2 = new CountryDetails() { ID = "AUS", NAME = "AUSTRALIA", CAPITAL = "CANBERRA" };
            CountryDetails Country3 = new CountryDetails() { ID = "USA", NAME = "UNITED SATE OF AMERICA", CAPITAL = "WASHINGTON D.C." };
            CountryDetails Country4 = new CountryDetails() { ID = "UK", NAME = "UNITED KINGDOM", CAPITAL = "LONDON" };
            CountryDetails Country5 = new CountryDetails() { ID = "CAN", NAME = "CANADA", CAPITAL = "OTTAWA" };

            List<CountryDetails> listcountry = new List<CountryDetails>();
            listcountry.Add(Country1);
            listcountry.Add(Country2);
            listcountry.Add(Country3);
            listcountry.Add(Country4);
            listcountry.Add(Country5);

            do
            {
                Console.WriteLine("Enter the Country Code");
                string strCountryCode = Console.ReadLine().ToUpper();

                CountryDetails resultofCode = listcountry.Find(code => code.ID == strCountryCode);

                if (resultofCode == null)
                {
                    Console.WriteLine("Please Enter valid Country Code");

                }
                else
                {
                    Console.WriteLine("NAME = {0} CAPITAL = {1}", resultofCode.NAME, resultofCode.CAPITAL);
                }
                Console.ReadLine();
            } while (1 == 1);

        }


    }
    class CountryDetails
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string CAPITAL { get; set; }
    }
}
