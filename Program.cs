using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileNames_Fetcher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Put all file names in root directory into array.
            String Path = @"C:\YourPath\";
            Console.WriteLine(Path);
            string[] array1 = Directory.GetFiles(Path);

            // Put all bin files in root directory into array.
            // ... This is case-insensitive.
            string[] array2 = Directory.GetFiles(@"C:\", "*.BIN");

            // Display all files.
            Console.WriteLine("--- Files: ---");
            foreach (string name in array1)
            {
                Console.WriteLine(name);
            }

            // Display all BIN files.
            Console.WriteLine("--- BIN Files: ---");
            foreach (string name in array2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
