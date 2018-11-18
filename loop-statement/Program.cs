using System;

namespace loop_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Int32 value = 11;
            // try if-else
            if (value < 10)
            {
                Console.WriteLine("Value is less than 10");
            }
            else
            {
                Console.WriteLine("Value is greater than 10");
            }
            //try switch and case, break;
            switch (value)
            {
                case 11:
                    Console.WriteLine("Value is 11");
                    break;
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                default:
                    Console.WriteLine("other number");
                    break;
            }
            // try while loop
            Int32 i = 0, j = 0;
            while (i + j < value)
            {
                Console.WriteLine(i++ + ++j + " ");
            }
            // try for loop
            for(Int32 k = 0; k<10;k++){
                if(k%7 == 0){
                    Console.WriteLine("k is {0}", k);
                }
            }

            Console.Read();
        }
    }
}
