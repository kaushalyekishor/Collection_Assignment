using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace TraningSession
{
    class List_Assgin
    {
        public List_Assgin()
        {
            List<int> LobjNumber = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                LobjNumber.Add(i);
            }

            for (int j = 0; j <= 20; j++)
            {
                Console.WriteLine("List Element at Position {0} is {1}", j, LobjNumber[j]);
            }

            //insert method:- adds 111 at index 1
            LobjNumber.Insert(1, 111);

            //Remove method:- directly remove specified element
            LobjNumber.Remove(111);

            //Contains method:- checks whether specified element is present or not
            Boolean LsFlag = LobjNumber.Contains(111);
            Console.WriteLine(LsFlag);

            //Sortinf List
            List<string> LobjGeek = new List<string>();
            LobjGeek.Add("ABCD");
            LobjGeek.Add("QRST");
            LobjGeek.Add("XYZ");
            LobjGeek.Add("IJKL");

            LobjGeek.Sort();
            foreach (var item in LobjGeek)
            {
                Console.WriteLine(item);
            }

            //BinerySearch method to find element in a list
            int LiIndex = LobjGeek.BinarySearch("XYZ");
            Console.WriteLine(LiIndex);



            ///////***DINCTIONERY***////////
            Dictionary<int, string> LobjDays = new Dictionary<int, string>();
            LobjDays.Add(0, "Sunday");
            LobjDays.Add(1, "Monday");


            var LobjCities = new Dictionary<string, string>()
            {
                {"UK","London,Manchester,Birmingham"},
                {"USA","Chikago,New York, Washington"},
                {"INDIA","Mumbai, Delhi, Pune"}
            };

            foreach (var cities in LobjCities)
            {
                Console.WriteLine("Country: {0}, Cities: {1}", cities.Key, cities.Value);
            }

            //Accessing Dictionary Elements
            Console.WriteLine(LobjCities["UK"]);

            //ContainsKey() to check for the presence of key in Dictionery
            if (LobjCities.ContainsKey("FRANCE"))
            {
                Console.WriteLine(LobjCities["FRANCE"]);
            }

            //ElementAt() to key value pair using index
            for (int LiCounter = 0; LiCounter < LobjCities.Count; LiCounter++)
            {
                // Console.WriteLine("Key:{0} vlaue:{1}", LobjCities.ElementAt(LiCounter).Key, LobjCities.ElementAt(LiCounter).Value);
            }
        }
    }
}
