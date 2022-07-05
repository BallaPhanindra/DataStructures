using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======UC1========");
            List<int> list = new List<int>();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            Console.WriteLine(list);

            Console.WriteLine("======UC2========");
            List<int> list2 = new List<int>();
            list2.Add(56);
            list2.Add(30);
            list2.Add(70);
            Console.WriteLine(list2);

            Console.WriteLine("======UC3========");
            List<int> list3 = new List<int>();
            list3.Append(56);
            list3.Append(30);
            list3.Append(70);
            Console.WriteLine(list3);

            Console.WriteLine("=======UC4=======");
            List<int> list4 = new List<int>();
            list4.Append(56);
            list4.Append(70);
            Console.WriteLine("Before insertion: " + list4);
            list4.Insert(1, 30);
            Console.WriteLine("Status post to Insertion: " + list4);

            Console.WriteLine("=======UC5========");
            Console.WriteLine("Initial Sequence is :" + list);
            list.Pop();
            Console.WriteLine("final sequence post to the pop operation: " + list);

            Console.WriteLine("=======UC6========");
            list.Append(70);
            Console.WriteLine("initial sequence is :" + list);
            list.Remove(70);
            Console.WriteLine("final sequence post to the PopLast operation: " + list);

            Console.WriteLine("========UC7=======");
            list.Search(30);


            Console.WriteLine("========UC8=======");
            list.Insert(40, 0);
            Console.WriteLine("final sequence post to the Insert operation: " + list);

            Console.WriteLine("========UC9=======");
            list.Remove(40);
            Console.WriteLine("final sequence post to the Delete operation: " + list);


            Console.WriteLine("========UC10=======");
            int[] listForSorting = list.ToArray();
            Array.Sort(listForSorting);
            Console.WriteLine("\nSorted List");
            for (int i = 0; i < listForSorting.Length; i++)
            {
                Console.Write(listForSorting[i] + " ");

            }
        }
    }
}
