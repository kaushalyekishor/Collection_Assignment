using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

//Assignment on Collection
namespace TraningSession
{
    class Assign_session2
    {
        public Assign_session2()
        {
            //Declaring list
            List<int> primeNumbers = new List<int>();

            //Adding elemetn to the list
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            //printing list element using simple for loop
            Console.WriteLine("Simple for Loop");
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.WriteLine(primeNumbers[i]);
            }

            //printing list elemetn using Linq
            Console.WriteLine();
            Console.WriteLine("Using Linq");
            primeNumbers.ForEach(num => Console.WriteLine(num));

            //Declaring a Dictionery
            Dictionary<int, string> numbersName = new Dictionary<int, string>();

            //Adding elemetn to the Dictionery
            numbersName.Add(1, "one");
            numbersName.Add(2, "Two");
            numbersName.Add(3, "Three");
            numbersName.Add(4, "Four");

            //printing Dictinery using for loop
            Console.WriteLine();
            Console.WriteLine("Simple for Loop");
            foreach (KeyValuePair<int, string> kvp in numbersName)
            {
                Console.WriteLine("Key:{0} , Value:{1}", kvp.Key, kvp.Value);
            }

            // Console.WriteLine();
            //  Console.WriteLine("Usinf Linq");
            //  numbersName.Select(i => $"Key {i.key}, Value {i.Value}").ToList().forEach(Console.WriteLine);


            //List Methods
            Console.WriteLine();
            Console.WriteLine("List Methods");

            //1.Count
            Console.WriteLine("\n 1.count No. of elements in the list");
            Console.WriteLine("No. of prim Numbers:" + primeNumbers.Count);

            //2.Capacity
            Console.WriteLine("\n 2.Capacity of  the list");
            Console.WriteLine("Capacity of the list "+primeNumbers.Capacity);

            //3.Contains
            Console.WriteLine("\n 3.check's whether elemtn present in the list or not");
            Console.WriteLine("Is the element present: "+primeNumbers.Contains(5));

            //4.RemoveAt
            //Console.WriteLine("\n 4. Remove element at specified index from the list");
            //Console.WriteLine("List before Removal:");
            //primeNumbers.ForEach(num => Console.Write(num + ","));
            //Console.WriteLine("\nList After Removal");
            //primeNumbers.RemoveAt(2);
            //primeNumbers.ForEach(num => Console.Write(num + ","));

            //5.Remove
            //Console.WriteLine("\n 5.Remove particular element from the List");
            //Console.WriteLine("List before Removal:");
            //primeNumbers.ForEach(num => Console.Write(num + ","));
            //primeNumbers.Remove(7);
            //Console.WriteLine("\nList After Removal");
            //primeNumbers.ForEach(num => Console.Write(num + ","));

            //6.Reverse
            Console.WriteLine("\n 6.Reverse the list");
            Console.WriteLine("\nList before Reversal:");
            primeNumbers.ForEach(num => Console.Write(num+ ","));
            primeNumbers.Reverse();
            Console.WriteLine("\nList After Reversal:");
            primeNumbers.ForEach(num => Console.Write(num+ ","));

            Console.WriteLine("\n\n..............................");

            Console.WriteLine("Dictionary methods:");

            //count
            Console.WriteLine("\n1.Count No. of element in the Dictionary");
            Console.WriteLine("No. of elements in Dictionary is: " + numbersName.Count);

            //Contains Key
            Console.WriteLine("\n2.checks whether the Dictionary contains particuar Key or Not");
            Console.WriteLine("Does the dictionary conains 1 as Key:" +numbersName.ContainsKey(1));

            //contains Value
            Console.WriteLine("\n3.checks whether the Dictionary contains particuar Value or Not");
            Console.WriteLine("Does the dictionary conains \'one\' as Value:" + numbersName.ContainsValue("one"));


            //Remove
            Console.WriteLine("\n4.Remove element with specified key");
            Console.WriteLine("\ndictionary before Removal");
            foreach (KeyValuePair<int, string> kvp in numbersName)
            {
                Console.WriteLine("Key:{0}, Value:{1}",kvp.Key,kvp.Value);
            }

            Console.WriteLine("\nDictionary After Removal");
            numbersName.Remove(2);
            foreach ( KeyValuePair<int, string> kvp in numbersName)
            {
                Console.WriteLine("Key:{0}, Value:{1}",kvp.Key,kvp.Value);
            }

            primeNumbers.Clear(); 
            

            Console.WriteLine("\nAfter Clear primenumber list");
            primeNumbers.ForEach(num => Console.Write(num + ","));
        }

        

    }
}
