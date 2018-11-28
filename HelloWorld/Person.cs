using System;

namespace HelloWorld
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public Person()
        {
            firstName = "";
            lastName = "";
        }

        public void introduce()
        {
            Console.WriteLine("Hi, I'm " + firstName + " " + lastName);
        }
    }

    public enum ShippingMethod
    {
        RegularMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class Prog 
    {
        public static void Main(String[] args)
        {
            Person p = new Person();
            p.firstName = "Lia";
            p.lastName = "Lop";
            p.introduce();
            int[] numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);
            var firstName = "Geeth";
            String str = "from .net framework";
            var lastName = "Wije";
            var fullname = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] { "Kevin", "Jill", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            Console.WriteLine(method.ToString());
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0} b: {1}", a, b));
            var array1 = new int[3]{1,2,3};
            var array2 = array1;
            array2[0] = 4;
            Console.WriteLine(string.Format("array1[0]: {0} array2[0]: {1}", array1[0], array2[0]));
            bool isGoldCust = true;
            float price = (isGoldCust) ? 19.95f : 20.95f;
            Console.WriteLine(price);
            /*Prog.taskOne();
            Prog.taskTwo();
            Prog.taskThree();
            Prog.taskFour();*/
            var random = new Random();
            const int pwLength = 10;
            var buffer = new char[pwLength];
            for (var i = 0; i < pwLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            string password = new string(buffer);
            Console.WriteLine(password);
        }

        public static void taskOne()
        {
            Console.WriteLine("Enter a number between 1 and 10.\n");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num<=10 && num>=1)
            {
                Console.WriteLine("Valid {0}", num);
            } else {
                Console.WriteLine("Invalid");
            }
        }

        public static void taskTwo()
        {
            Console.WriteLine("Enter two numbers.\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine(num1);
            } else {
                Console.WriteLine(num2);
            }
        }

        public static void taskThree()
        {
            Console.WriteLine("Enter the width.\n");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height.\n");
            int height = Convert.ToInt32(Console.ReadLine());
            if (width>height)
            {
                Console.WriteLine("Landscape\n");
            } else {
                Console.WriteLine("Portrait\n");
            }
        }

        public static void taskFour()
        {
            Console.WriteLine("Enter the speed limit.\n");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed.\n");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed<limit)
            {
                Console.WriteLine("OK\n");
            } else {
                for (int i = 0; i < 12; i++)
                {
                    if(speed<=0)
                    {
                        break;
                    }
                    Console.WriteLine("1 ");
                    speed -= 5;
                }

                if (speed>0)
                {
                    Console.WriteLine("\nLicense Suspended.");
                }
            }
        }
    }
}
