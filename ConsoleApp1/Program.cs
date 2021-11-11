using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2,1,1,5,6,4,4,7,7};
            Console.WriteLine("init array");
            foreach (var item in arr)
            {
                Console.Write(item + ",");
            }
            var tmp = Sorts.CountingSort(arr, 7);
            Console.WriteLine();
            Console.WriteLine("after sort array");
            foreach (var item in tmp)
            {
                Console.Write(item + ",");
            }
        }
    }
}
