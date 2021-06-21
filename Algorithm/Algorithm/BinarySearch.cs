using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class BinarySearch
    {
        public int Search(string[]array,string data)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + right / 2;
                int check = data.CompareTo(array[mid]);
                if (check == 0)                 ///or data==array[mid]
                    return mid;
                if (check > 0)
                    return mid + 1;
                else
                    return mid - 1;
            }
            return -1;
        }
    }
}
