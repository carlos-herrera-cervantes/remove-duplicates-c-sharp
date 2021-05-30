using System;
using RemoveDuplicatesDomain.Models;

namespace RemoveDuplicatesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new[] { 1, 1, 2 };
            var length = SuperArray.RemoveDuplicates<int>(elements);

            Console.WriteLine($"The length of distinct array: {length}");
        }
    }
}
