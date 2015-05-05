using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsorted = { 4, 2, 9, 20, 15, 8, 2, 4, 5, 16, 23 };
            bool swapped;
            int temp;
            do
            {
                swapped = false;

                for (int i = 0; i < unsorted.Length-1; i++)         //Length minus 1 is needed because array will become out of bounds and give a null exception
                {
                    if (unsorted[i] > unsorted[i + 1])
                    {
                        temp = unsorted[i + 1];
                        unsorted[i + 1] = unsorted[i];
                        unsorted[i] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped);

            for (int i = 0; i < unsorted.Length; i++)
                Console.WriteLine(unsorted[i]+ " ");
            
        }
    }
}
