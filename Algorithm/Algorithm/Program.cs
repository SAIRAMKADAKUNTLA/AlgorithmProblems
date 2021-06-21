using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to algorithm problems");
            Console.WriteLine("1.BinarySearch,2.InsertionSort");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string[] array = { "hi", "hello", "sai", "ram", "done" };
                    string data = "sai";
                    BinarySearch binary = new BinarySearch();
                    int result = binary.Search(array, data);
                    if (result == -1)
                        Console.WriteLine("NO ELEMENTS FOUND");
                    else
                        Console.WriteLine("Elements found at index" + result);
                    break;
                case 2:
                    string[] array1 = { "tom", "tommy", "john", "jamieson", "william" };
                    InsertionSort sorting = new InsertionSort();
                    sorting.Sort(array1);
                    break;
                default:
                    Console.WriteLine("INVALID SELECTION");
                    break;
            }
           
        }
    }
}
