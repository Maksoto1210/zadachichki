using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of array elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = GenerateRandomArray(n);

            Console.WriteLine("The array is:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("Enter the number you are looking for: ");
            int target = int.Parse(Console.ReadLine());

            var result = LinearSearch(arr, target);

            Console.WriteLine($"Elements found: {result.Item1}");
            Console.WriteLine("Elements positions:");
            foreach (var index in result.Item2)
            {
                Console.WriteLine(index);
            }
        }

        static int[] GenerateRandomArray(int size)
        {
            Random rand = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(1, 101);
            }

            return arr;
        }
        static Tuple<int, List<int>> LinearSearch(int[] arr, int target)
        {
            int count = 0;
            List<int> positions = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    count++;
                    positions.Add(i+1);
                }
            }

            return Tuple.Create(count, positions);
        }
    }
}
