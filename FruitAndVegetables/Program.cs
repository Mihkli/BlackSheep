using System;
using System.IO;

namespace FruitAndVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitpath = @"C:\Users\opilane\Samples\fruit.txt";
            string[] veggiedata = File.ReadAllLines(fruitpath);

            string veggiepath = @"C:\Users\opilane\Samples\veggie.txt";
            string[] fruitdata = File.ReadAllLines(veggiepath);

            File.WriteAllLines(fruitpath, fruitdata);
            File.WriteAllLines(veggiepath, veggiedata);
        }
        
    }
}
