using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int maxHealth = 100;
            int treatment = 7;
            int startHealthPoint = 5;

            for (int i = startHealthPoint; i < maxHealth; i += treatment)
            {
                Console.WriteLine(i);
            }
        }
    }
