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
            task2();
            task3();
        }

        public static void task1()
        {
            Console.WriteLine("Enter a series of numbers separated by '-'.");
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
            Console.WriteLine("Enter a series of numbers separated by a hyphen.");
            var input = Console.ReadLine();
            var nums = input.Split('-');
            for(int i = 0; i<nums.Length; i++)
            {
                for(int j =0; j<nums.Length; i++)
                {
                    if(i!=j && Convert.ToInt32(nums[i])==Convert.ToInt32(nums[j]))
                    {
                        Console.WriteLine("Duplicate.");
                        return;
                    }
                }
            }
        }

        public static void task3()
        {
            Console.WriteLine("Enter a valid time.");
            var time = Console.ReadLine();
            if(String.IsNullOrWhiteSpace(time))
            {
                Console.WriteLine("Invalid time.");
                return;
            }

            var digits = time.Split(':');
            var hour = Convert.ToInt32(digits[0]);
            var mins = Convert.ToInt32(digits[1]);
            if(hour>24 || hour<0 || mins<0 || mins>59)
            {
                Console.WriteLine("Invalid time.");
            } else
            {
                Console.WriteLine("Valid time.");
            }
        }

        public static void task4()
        {
            Console.WriteLine("Enter a series of words separated by a space.");
            var input = Console.ReadLine();
            var words = input.Split(' ');
            var builder = new StringBuilder();
            for(int i =0; i<words.Length; i++)
            {
                for(int j = 0; j < words[i].Length; i++)
                {
                    var charac = words[i].remove(1);
                    if (j==0 && (int)charac>=97)
                    {
                        builder.Append((int)charac - 32); //uppercase first letter of word
                    } else if (j == 0)
                    {
                        builder.Append((int)charac);
                    } else if ((int)charac<=90)
                    {
                        builder.Append((int)charac + 32); //make rest of charac lowercase
                    } else
                    {
                        builder.Append((int)charac);
                    }
                }
            }
            Console.WriteLine(builder);
        }

        public static void task5()
        {
            Console.WriteLine("Enter an english word.");
            var word = Console.ReadLine();
            var count = 0;

            for(int i =0; i<word.Length; i++)
            {
                var letter = word.Remove(1);
                var ascii = (int)letter;
                if(ascii==97 || ascii ==65 || ascii==69 || ascii==101 || ascii==73 || ascii==105 || ascii==79 || ascii==111 || ascii==85 || ascii==117)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }


    }
}
