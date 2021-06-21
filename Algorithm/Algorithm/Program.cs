using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to algorithm problems");
            Console.WriteLine("1.BinarySearch,2.InsertionSort,3.BubbleSort");
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
                    InsertionSort sorting = new InsertionSort();
                    sorting.Sort();
                    break;
                case 3:
                    BubbleSort bubble = new BubbleSort();
                    bubble.Bsort();
                    break;

                default:
                    Console.WriteLine("INVALID SELECTION");
                    break;
            }
           
        }
    }
}
