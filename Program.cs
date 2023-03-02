using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachazaIzpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chisla: ");
            List <int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            PrintNums(nums);

            Console.Write("Vuvedi chisla v arr1: ");
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            AddArray1ToList(nums, arr1);

            Console.Write("Vuvedi chislo za proverka: ");
            int num = int.Parse(Console.ReadLine());
            NumsInlist(nums , num);

            Console.Write("Vuvedi chislo v arr2: ");
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            AddArra2ToList(nums, arr2);

            //Console.WriteLine();
            
        }

        private static void AddArra2ToList(List<int> nums, int[] arr2)
        {
            nums.InsertRange(3, arr2);
            Console.WriteLine($"Chislata na masiv 2 sa: {string.Join(" ", nums)}");
            nums.Sort();
            Console.WriteLine($"Chislata na lista sa: {string.Join("*", nums)}");
        }

        private static void NumsInlist(List<int> nums , int num)
        {
            if (nums.Contains(num))
            {
                Console.WriteLine($"{num} e {nums.IndexOf(num)}");
            }
           
        }

        private static void AddArray1ToList(List<int> nums, int[] arr1)
        {
            nums.AddRange(arr1);
            nums.Sort();
            Console.WriteLine($"Chislata na msiv edno sa:{string.Join(" ", nums)}");
        }

        private static void PrintNums(List<int> nums)
        {
            Console.WriteLine($"Chislata v masivav sa {nums.Count}");
        }
    }
}
