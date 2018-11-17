using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = System.Environment.MachineName;
            Console.WriteLine("Hello World!" + name);
            // test T1 = new test();
            string[] t2 = new string[] {"call", "another"};
            test.main(t2);
        }
    }
}
