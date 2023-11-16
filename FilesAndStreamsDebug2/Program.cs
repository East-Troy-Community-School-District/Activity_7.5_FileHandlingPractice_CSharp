/*
 * Files and Streams Debug 2
 * Pawelski
 * 11/15/2023
 * Developing Desktop Applications
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndStreamsDebug2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please add the correct file path! Do not include this in your debugging.
            const string FILE_PATH = @"";
            FileStream file = new FileStream(FILE_PATH, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            string repeat;
            do
            {
                Console.Write("Enter an animal >> ");
                writer.WriteLine(Console.ReadLine());
                Console.Write("Would you like to enter another animal? (Y/N) >> ");
                repeat = Console.ReadLine();
            } while (repeat == "Y");
        }
    }
}