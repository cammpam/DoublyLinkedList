using System;

namespace DoubleLinked
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.Add("Where");
            list.Add("In");
            list.Add("The");
            list.Add("World");
            list.Add("is");
            list.Add("Carmen");
            list.Add("San");
            list.Add("Diego");


            list.PrintList();
            list.PrintMiddle();
            Console.WriteLine();
            list.PrintNth(5);


            Console.WriteLine();
            list.PrintNthData("SEVEN");
            list.Delete("Where");


            Console.WriteLine();
            list.PrintList();
            list.Delete("Is");
            Console.WriteLine();
            list.PrintList();


            Console.ReadLine();
        }
    }
}
