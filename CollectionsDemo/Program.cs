using System;
using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1=new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("Anupam");
            arrayList1.Add(false);
            arrayList1.Add(5.4);

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            /*Console.WriteLine(arrayList1[3]);
            Console.WriteLine(arrayList1.Contains("Anupam"));
            Console.WriteLine(arrayList1.Count);*/

            arrayList1.Insert(2, "Kumar"); //it will insert Kumar at 2nd index of the arrayList1.

            foreach(var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add("India");
            arrayList2.Add("Australia");
            arrayList2.Add("UAE");
            arrayList2.Add(230);
            arrayList2.Add(7.6);
            arrayList2.Add("France");
            arrayList2.Add("German");

            arrayList1.InsertRange(3, arrayList2);

            Console.WriteLine("\n\nAfter inserting arrayList1 values are ");
            foreach(var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            arrayList1.Remove("German");

            Console.WriteLine("\n\n After REmove German arraylist1 values are");
            foreach (var item in arrayList1)

            {
                Console.WriteLine(item);
            }

            arrayList1.RemoveAt(0);
            Console.WriteLine("\n\n After REmoveat (0) arraylistl values are");
            foreach (var item in arrayList1)
            {
            Console.WriteLine(item);
            }

            arrayList1.RemoveRange(3,2);
            Console.WriteLine("\n\n After REmoveRange (3,2) arraylistl values are"); 
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            arrayList1.Clear();
            Console.WriteLine("\n\nAfter clear all elements in arrayList1 " + arrayList1.Count);

            ArrayList clonedArrayList=(ArrayList)arrayList2.Clone();
            Console.WriteLine("\n\nColened arrayList values are ");
            foreach(var item in clonedArrayList)
            {
                Console.WriteLine(item);
            }

            int[] myarray = new int[3];
            object[] arrayListcopy = new object[arrayList2.Count];

            arrayList2.CopyTo(arrayListcopy);
            Console.WriteLine("ArrayList copy");
            foreach (var item in arrayListcopy)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sort arrayList Values");
            arrayList2.Sort();
            foreach(var item in arrayList2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
