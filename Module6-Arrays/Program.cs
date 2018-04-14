using System;
using System.Linq;
using System.Collections;//Can use arrays.
using System.Collections.Generic;//can use Dictionaries

namespace Module6_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ArrayLis Code

            ArrayList aList = new ArrayList();

            aList.Add("Chris");
            aList.Add(40);
            aList.Add("coffee");

            Console.WriteLine("Count: {0}", aList.Count);

            Console.WriteLine("Capacity: {0}", aList.Capacity);//automatically increcess 

            ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] { "Chloe", "Claire", "Dog Food" });

            aList.AddRange(aList2);//adds aList2 to aList

            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(2, "Chicken");

            ArrayList range = aList2.GetRange(0, 5);

            foreach (object o in range)
            {
                Console.WriteLine(o);
            }
            #endregion
        }
    }
}


//aList2.RemoveAt(0);//Removes first in array aList2.

//aList2.RemoveRange(0, 2);//Removes everything in that range from 0-2


//#region Dictionary

//Dictionary<string, string> pets = new Dictionary<string, string>();

//pets.Add("Cedric", "Mr. Barnaby");
//pets.Add("Claire", "The Voice");
//pets.Add("Chloe", "Brown dog, white spots");

//Console.WriteLine("Count : {0}",
//    pets.Count);

//Console.WriteLine("Cedric : {0}", pets.ContainsKey("Cedric"));

//pets.TryGetValue("Cedric", out string test);

//Console.WriteLine($"Cedric : {test}");

//foreach(KeyValuePair<string, string> item in pets)
//{
//    Console.WriteLine("{0} : {1}",
//        item.Key,
//        item.Value);

//}

//Queue queue = new Queue();

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);

//Console.WriteLine("1 in Queue : {0}", queue.Contains(1));//There is a Dequeue also.

//Console.WriteLine("Peek 1:{0}", queue.Peek());

//object[] numArray = queue.ToArray();

//Console.WriteLine(string.Join(", ",
//    numArray));


//Stack stack = new Stack();//unlike queue, it is a last in first out. Opposite of queue.

//stack.Push(1);
//stack.Push(2);
//stack.Push(3);

//Console.WriteLine("Contains 1 in Stack : {0}", stack.Contains(1));//There is a Dequeue also.


//foreach (object o in stack)//replace stack with queue
//    {
//    Console.WriteLine($"Stack: {o}");
//    }

//#endregion

//string[] array1 = { "item 1", "item 2" };

// 1. Clone
//string[] array2 = (string[])array1.Clone();

// 2.Copy
//string[] array3 = new string[array1.Length];
//Array.Copy(array1, array3, array1.Length);




    
