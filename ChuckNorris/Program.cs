using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filepath = @"C:\Users\opilane\Samples\chuck.txt";
            //string[] datafromfile = File.ReadAllLines(filepath);

            //Random rnd = new Random();
            //int randomindex = rnd.Next(0, datafromfile.Length);

            //Console.WriteLine(datafromfile[randomindex]);

            Console.WriteLine(getrandonjoke());
        }

        public static string getrandonjoke()
        {
            string filepath = @"C:\Users\opilane\Samples\chuck.txt";
            string[] datafromfile = File.ReadAllLines(filepath);
            Random rnd = new Random();
            int randomindex = rnd.Next(0, datafromfile.Length);

            return datafromfile[randomindex];

        }
    }
}
