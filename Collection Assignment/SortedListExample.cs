using System;
using System.Collections;

namespace CsharpCodeSample
{
    class SortedListExample
    {
        public SortedListExample()
        {
            SortedList sl = new SortedList();
            sl.Add("Key1", "Value 1");
            sl.Add("abcd", "1234");
            sl.Add("xyz", "1234");
            sl.Add("ijkl", "Tutorials");
            sl.Add("2key", "Points");

           // sl.Remove("Key1");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
