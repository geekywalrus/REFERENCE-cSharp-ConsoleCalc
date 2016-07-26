using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cScC // This namespace looks like I had a stroke while naming it...
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store numbers the user enters for later use
            int num01;
            int num02;

            // FIXME: Only supports multiplication
            Console.Write("Type a number to be multiplied: "); // Inform user they should type a number
            num01 = Convert.ToInt32(Console.ReadLine()); // Read entered number and store it in num01, and convert it to int32 since console expects a string.
            Console.Write("Type another number: "); // Inform user they should type another number
            num02 = Convert.ToInt32(Console.ReadLine()); // Read entered number and store it in num02, and convert it to int32 since console expects a string.
            Console.WriteLine("Result is: " + num01 * num02); // Inform user of the sum of their numbers by multiplying num01 by num02 and writing the result to the console.
            Console.ReadKey(); // Wait for user input before closing the console window
        }
    }
}
