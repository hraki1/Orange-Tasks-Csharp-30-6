using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class Task5Q4
    {
        static public void sortedArray(int []arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
