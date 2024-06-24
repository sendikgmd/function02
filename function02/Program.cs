using System;

namespace MyFirstApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DrawHealt();

            Console.Read();

        }
        static void GenerationHealt()
        {
            int percentHealth;
            Random rand = new Random();
            percentHealth = rand.Next(1, 101);
        }
        static int DrawHealt(int percentHealth)
        {
            string symbolBar = "#";
            string sybloBar2 = "_";
            return percentHealth;

            Console.WriteLine(percentHealth + "%");
            Console.Write("[");
            for (int i = 0; i < percentHealth; i++)
            {
                Console.Write(symbolBar);
            }

            percentHealth = 10 - percentHealth;



            Console.Write("]");
        }

    }
}