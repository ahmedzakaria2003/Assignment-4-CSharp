﻿namespace Assignment_5_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1

            Console.WriteLine("Enter an integer: ");
            int num;
            if (int.TryParse(Console.ReadLine(), out num)) {
                for (int i = 1; i <= num; i++)
                {
                    Console.Write(i + (i < num ? ", " : "\n"));

                }

            }

            
            #endregion
        }
    }
}
