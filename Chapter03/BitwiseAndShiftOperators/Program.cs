﻿using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // 0000 1010
            int b = 6; // 0000 0110
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}"); // 2-bit coLumn onLy
            WriteLine($"a | b = {a | b}"); // 8, 4, and 2 coLumns
            WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit coLumns
            WriteLine($" ");
            // 0101 0000 Left-shift a by three bit columns
            WriteLine($" a << 3 = {a << 3}");
            // Multiply a by 8
            WriteLine($" a * 8 = {a * 8}");
            // 0000 0011 right-shift b by one bit column
            WriteLine($" b >> 1 = {b >> 1}");

            WriteLine($" ");

            int age = 47;

            // How many operators in the following statement?
            char firstDigit = age.ToString()[0];


            //There are four operators:
            // = is the assignment operator
            // . is the member acess operator
            // () is the invocation operator
            // [] is the indexer access operator
        }
    }
}
