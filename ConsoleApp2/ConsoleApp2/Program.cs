using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenghts of the rectangle");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is ");
            var c = a * b;
            Console.WriteLine(c);

        }
    }
    
    }