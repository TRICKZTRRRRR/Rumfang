using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height");
            Console.Write("> ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("\nWidht");
            Console.Write("> ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("\nLenght");
            Console.Write("> ");
            double length = double.Parse(Console.ReadLine());

            double volume = height * width * length;
            
            Console.WriteLine("\nVolume = " +  volume);
            Console.ReadLine();
        }
    }
}
