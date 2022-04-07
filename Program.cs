using System;

namespace LatihanOverloadingMethod // project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers() ;

            Console.WriteLine("Minimum #1: {0}", Numbers.FindMinimum(3,1));  //memanggil static method
            Console.WriteLine("Minimum #2: {0}", number.FindMinimum(3, 2, 4));  //memanggil overloading method
            Console.WriteLine();
            Console.WriteLine("Maksimum #1: {0}", Numbers.FindMaximum(3, 1)); //memanggil static method
            Console.WriteLine("Maksimum #2: {0}", number.FindMaximum(3, 2, 4)); //memanggil overloading method

            Console.ReadKey();
        }
    }
}
