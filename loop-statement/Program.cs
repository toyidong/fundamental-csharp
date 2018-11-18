using System;

namespace loop_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Int32 value = 11;
            if(value<10){
                Console.WriteLine("Value is less than 10");
            }
            else{
                Console.WriteLine("Value is greater than 10");
            }
            Console.Read();
        }
    }
}
