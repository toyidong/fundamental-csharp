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
            string[] t2 = new string[] { "call", "another" };
            Boolean status = true;
            test.main(t2);
            color a = color.Red;
            color b = color.Blue;
            color c = color.Green;
            int i = (int)color.Red;
            int j = (int)color.Blue;
            int k = (int)c;
            EnumExample.PrintColor(c);
            Console.WriteLine("{0} {1} {2} {3}", i,j,k, t2);
            string s = ""+i+j+k;
            Console.WriteLine("this {0}",s);
            
            // Console.WriteLine(System.ArraySegment);
        }
    }
}

