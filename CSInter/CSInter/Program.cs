using System;
using Amazon;
using System.Collections;
using System.Collections.Generic;

namespace CSInter
{
    class Person
    {
        public static string Name { get; set; }
        public DateTime BirthDate { get; private set; } //must set this in construc (can't be changed)
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public static void Introduce(String to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var Person = new Person();
            Person.Name = str;
            return Person;
        }

        public Person()
        {
            BirthDate = new DateTime(1999, 1, 1);
        }

        public Person(DateTime bd)
        {
            BirthDate = bd;
        }

        public Person(String name) : this()
        {
            Person.Name = name;
        }
    }

    public class Calculator
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            //
        }
    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkflowEngine();
            workflow.AddActivity(new SendEmail());
            workflow.AddActivity(new UploadVideoActivity());

            workflow.Run();

            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

            DbConnection connection = new SQLConnection();

            var command = new DbCommand(connection, "SELECT * FROM Clients;");
            command.Execute();

            var anotherConnection = new OracleConnection();

            var anotherCommand = new DbCommand(anotherConnection, "SELECT * FROM HouseHolds");

            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Text text = new Text();
            Shape shape = new Text();

            text.Width = 200;
            shape.Width = 100;

            //StreamReader reader = new StreamReader(new MemoryStream());
            var list = new ArrayList();
            list.Add(1); //boxing happens (takes in object)

            var anotherList = new List<int>();
            anotherList.Add(1); //no boxing happens
            var number = (int)list[1]; //unboxing happens



            //can't access RateCalculator.cs here
            var customer = new Customer();
            var stopWatch = new StopWatch();
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Duration());
            var post = new StackOverflowPost();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine(post.Votes);
            var cookie = new HTTPCookie();
            cookie["name"] = "Geeth";
            Console.WriteLine(cookie["name"]);
            var result = Calculator.Add(1, 2, 3, 4);
            var p = Person.Parse("John");
            Person.Introduce("Geeth");
        }
    }
}
