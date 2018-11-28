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


        }
    }
}
