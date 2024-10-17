using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace feladat3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int i = 0;
            Random rnd = new Random();
            while (i < 5)
            {
                int number = rnd.Next(1, 101);
            }
            Console.WriteLine("A sorsolt számok: ");
            foreach (int szam in numbers)
            {
                Console.Write(numbers + "");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
