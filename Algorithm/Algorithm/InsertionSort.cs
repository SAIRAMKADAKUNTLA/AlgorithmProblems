using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class InsertionSort
    {
        public int i, j;
        public string[] array = { "tom", "tommy", "john", "jamieson", "william" };
        public  void Sort()
        {
            for (i = 1; i <= array.Length; i++)
            {
                string temp = array[i];
                j = i - 1;
                while (j >= 0 && array[j].CompareTo(temp) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
   
            }
            foreach(var data in array)
            {
                Console.WriteLine(data);
            }
        }
    }
}
