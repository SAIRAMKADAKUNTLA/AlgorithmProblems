using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to algorithm problems");
            string[] array = { "hi", "hello", "sai", "ram", "done" };
            string data = "sai";
            BinarySearch binary = new BinarySearch();
            int result = binary.search(array, data);
            if(result == -1)
                Console.WriteLine("NO ELEMENTS FOUND");
            else
                Console.WriteLine("Elements found at index"+result);
        }
    }
}
