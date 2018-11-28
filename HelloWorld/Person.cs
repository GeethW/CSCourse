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
        }
    }
}
