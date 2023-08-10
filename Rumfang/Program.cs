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
            // Prompt user for height input
            Console.WriteLine("Height");
            Console.Write("> ");

            // Read and parse user input into the 'height' variable
            float height = float.Parse(Console.ReadLine());

            // Prompt user for width input
            Console.WriteLine("\nWidth");
            Console.Write("> ");

            // Read and parse user input into the 'width' variable
            float width = float.Parse(Console.ReadLine());

            // Prompt user for length input
            Console.WriteLine("\nLength");
            Console.Write("> ");

            // Read and parse user input into the 'length' variable
            float length = float.Parse(Console.ReadLine());

            // Calculate the volume using the provided dimensions
            float volume = height * width * length;

            // Display the calculated volume
            Console.WriteLine("\nVolume = " + volume);

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
