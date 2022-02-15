using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            string UserName;

            UserName = Console.ReadLine();
            Console.WriteLine("Welcome,"+ UserName);
            Console.Read();
            
            
        }
    }
}
