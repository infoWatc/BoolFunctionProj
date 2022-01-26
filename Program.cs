/*
    Write a C# program to check two given integers 
    and return true if one is negative and one is positive.
*/

using System;

namespace BoolFunctionProj
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool IsNegPos(int num1, int num2) => (num1 < 0 && num2 > -1) ? true : false;

            int num1 = -1;
            int num2 = 3;
            Console.Write($"\"{num1}\" is negative & \"{num2}\" is positive: {IsNegPos(num1, num2)}\n");

            num1 = 2;
            num2 = 0;
            Console.Write($"\"{num1}\" is negative & \"{num2}\" is positive: {IsNegPos(num1, num2)}\n");

            num1 = 0;
            num2 = 1;
            Console.Write($"\"{num1}\" is negative & \"{num2}\" is positive: {IsNegPos(num1, num2)}");
            
            
        }
    }
}
