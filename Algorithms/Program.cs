using Algorithms._1___InsertionSort;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithms!");

            var input = new List<int>() { 5, 2, 4, 6, 1, 3 };

            input.SortByInsertionSort();

            Console.ReadKey();
        }
    }
}
