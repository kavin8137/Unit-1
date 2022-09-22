using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //void will not return anything
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Bill");
            names.Add("Sue");
            
            names.ForEach(name => Console.Write(name + " "));

            string aString = "a";
            List<string> stuff = new List<string>{aString, "b", "c", "d"};

            char aSingleCharacter = 'a'; //It takes one bite instead of 2 bites
            Console.WriteLine($"This is a single character: {aSingleCharacter}");

            int x = 5;
            int y = 7;
            int result1 = Adder(x, y);
            int result2 = Adder(10, 46);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static int Adder(int a, int b) //return integer
        {
            return a + b;
        }
    }
}
