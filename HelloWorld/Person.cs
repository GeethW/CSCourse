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
        }
    }
}
