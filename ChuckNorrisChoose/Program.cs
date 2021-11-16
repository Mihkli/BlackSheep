using System;
using System.IO;

namespace ChuckNorrisChoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Chuck Norris jokes would u like? 1-10.");
            int useramount = int.Parse(Console.ReadLine());

            getjokes(useramount);
        }

        private static void getjokes(int jokesnumber)
        {
            string filepath = @"C:\Users\opilane\Samples\chuck.txt";
            string[] datafromfile = File.ReadAllLines(filepath);

            if (jokesnumber > datafromfile.Length)
            {
                jokesnumber = datafromfile.Length;
            }

            for (int i = 0; i < jokesnumber; i++)
            {
                Console.WriteLine(datafromfile[i]);
            }

        }

    }
}
