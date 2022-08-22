// See https://aka.ms/new-console-template for more information
using System;
namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();
        }
    }
}