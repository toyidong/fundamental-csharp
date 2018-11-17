using System;

namespace HelloWorld{
    public static class test{

        public static void main(string[] args){

        string message = "";
        if (args.Length < 1)
        {
            message = "Welcome to .NET Core!";
        }
        else{
            foreach(string item in args){
                message += item;
            }
        }
        Console.WriteLine(message);
        }
    }
}