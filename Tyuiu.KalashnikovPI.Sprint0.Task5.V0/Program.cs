﻿using Tyuiu.KalashnikovPI.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KalashnikovPI.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Substraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataService.Division(5, 0));
            Console.ReadKey();
        }
    }
}
