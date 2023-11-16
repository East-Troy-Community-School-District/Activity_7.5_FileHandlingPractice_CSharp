/*
 * Files and Streams Debug 1
 * Pawelski
 * 11/15/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndStreamsDebug1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please add the correct file path! Do not include this in your debugging.
            const string FILE_PATH = @"";
            FileStream file = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
            file.Close();
        }
    }
}