using System;
using System.Collections;
using System.Text;

namespace CsharpCodeSample
{
    class HashTableExample
    {
        public HashTableExample()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Key1","Value 1");
            ht.Add("abcd", "1234");
            ht.Add("xyz", "1234");
            ht.Add("ijkl", "Tutorials");
            ht.Add("2key", "Points");

            ht.Remove("Key1");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+ ": "+item.Value);
            }
        }
    }
}
