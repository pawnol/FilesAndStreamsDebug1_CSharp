/*
 * Files and Streams Debug 1
 * Pawelski
 * 2/16/2022
 * This program does not work! Find and fix any bugs
 * in the code so that the program works as described
 * on the activity sheet. In addition, describe the 
 * bugs and how you fixed them on the activity sheet.
 */

using System;
using System.IO;
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
            StreamWriter reader = new StreamWriter(file);
            while(!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
            file.Close();
        }
    }
}
