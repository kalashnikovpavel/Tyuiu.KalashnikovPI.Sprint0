﻿namespace Tyuiu.KalashnikovPI.Sprint0.Task5.V1.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Substraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя");
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
