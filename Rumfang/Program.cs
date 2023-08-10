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
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("\nWidht");
            Console.Write("> ");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("\nLenght");
            Console.Write("> ");
            float length = float.Parse(Console.ReadLine());

            float volume = height * width * length;
            
            Console.WriteLine("\nVolume = " +  volume);
            Console.ReadLine();
        }
    }
}
