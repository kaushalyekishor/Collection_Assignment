using System;
using System.Collections.Generic;
using System.Linq;

namespace TraningSession
{
    class Linq_Session2
    {
        public Linq_Session2()
        {
            Dictionary<string, string> LobjTest = new Dictionary<string, string>();
            LobjTest.Add("Test1","Sanket");
            LobjTest.Add("Test2", "Kishor");
            LobjTest.Add("Test3", "Arvind");
            LobjTest.Add("Test4", "Parag");
            LobjTest.Add("Test5", "Sanket");

            //This below syntax called LInQ
            //string LsOutPut = LobjTest.Where(x => x.Key.Equals("Test1")).LastOrDefault().Value;
            string LsOutPut = LobjTest.Where(x => x.Value.Equals("Sanket")).FirstOrDefault().Key;
            Console.WriteLine("This is Test msg for {0}",LsOutPut);

            //this is also called Linq
            // Console.WriteLine("This is Test msg for {0}", LobjTest.Where(x => x.Value != null && x.Value.Equals("Sanket")).FirstOrDefault().Key);
            // Console.WriteLine("This is Test msg for {0}", LobjTest.Where(x => string.IsNullOrEmpty(x.Value) && x.Value.Equals("Sanket")).FirstOrDefault().Key);

            List<KeyValuePair<string, string>> LsDemo = LobjTest.Where(x => x.Value.Equals("Sanket")).ToList();
            Console.WriteLine(LsDemo);
            //foreach (var item in LobjTest)
            //{
            //    if(item.Value.Equals("Kishor"))
            //    Console.WriteLine("This is Test msg for {0}", item.Value);
            //}

            string LsoutPut = LobjTest.Where( x => x.Key.Equals("Test1")).FirstOrDefault().Value;
        }
    }
}
