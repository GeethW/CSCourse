using System;
using System.Text;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var builder = new StringBuilder();
               builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First char: " + builder[0]);
            task1();
        }

        public static void task1()
        {
            Console.WriteLine("Enter a series of numbers sperated by '-'.");
            var input = Console.ReadLine();
            var nums = input.Split('-');
            var num = Convert.ToInt32(nums[0]);
            for (int i = 1; i<nums.Length; i++)
            {
                var num2 = Convert.ToInt32(nums[i]);
                if(num>num2)
                {
                    Console.WriteLine("Not consecutive.");
                    return;
                }
            }
            Console.WriteLine("Consecutive.");
        }

        public static void task2()
        {

        }
    }
}
