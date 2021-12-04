using System;
using static System.Console;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            WriteLine($"AND | a     | b ");
            WriteLine($"a   | {a & a,-5} | {a & b,-5}");
            WriteLine($"b   | {b & a,-5} | {b & b,-5}");
            WriteLine($" ");
            WriteLine($"OR  | a     | b ");
            WriteLine($"a   | {a | a,-5} | {a | b,-5}");
            WriteLine($"b   | {b | a,-5} | {b | b,-5}");
            WriteLine($" ");
            WriteLine($"XOR | a     | B ");
            WriteLine($"a   | {a ^ a,-5} | {a ^ b,-5}");
            WriteLine($"b   | {b ^ a,-5} | {b ^ b,-5}");
            WriteLine($" ");
            WriteLine($"a && Dostuff*() = {a && DoStuff()}");
            WriteLine($"b && Dostuff*() = {b && DoStuff()}");

        }

            
         private static bool DoStuff()
         {
            WriteLine("I am doing some stuff.");
            return true;
         }

            
    }
}
