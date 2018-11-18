
/*
An enum type is a distinct value type with a set of named constants.
You define enums when you need to define a type that can have a set of discrete values.
They use one of the integral value types as their underlying storage.
They provide semantic meaning to the discrete values.
 */
using System;

namespace HelloWorld
{
    public enum color{Red,Green,Blue};
    public class EnumExample
    {
        public static void PrintColor(color color)
        {
            switch (color)
            {
                case color.Red:
                    Console.WriteLine("red");
                    break;
                case color.Green:
                    Console.WriteLine("green");
                    break;
                case color.Blue:
                    Console.WriteLine("blue");
                    break;
                default:
                    Console.WriteLine("unknown color");
                    break;
            }
            string s = Console.ReadLine();
            Console.WriteLine(s);
        }
        public void Main(string[] args)
        {
            color c = color.Red;
            PrintColor(c);
            PrintColor(color.Blue);
            Console.WriteLine("Hello World!");
        }
    }
}
