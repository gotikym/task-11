using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int maxHealth = 100;
            int treatment = 7;

            for (int i = 5; i < maxHealth; i += treatment)
            {
                Console.WriteLine(i);
            }
        }
    }
