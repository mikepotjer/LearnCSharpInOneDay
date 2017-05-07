using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note the double backslashes to indicate we want a backslash, and are not specifying
            //an escape character.
            //string path = "d:\\Optimal\\Visual Studio 2017\\myFile.txt";

            //Without a path, the file is going to be created in the same folder as the .exe,
            //which will be the folder: FileHandlingDemo\FileHandlingDemo\Debug\Bin
            string path = "myFile.txt";

            //Option 1: trap for file not found
            try
            {
                WriteLine("Writing the file in try-catch.");
                // This using ensures that Dispose() method is called to release unmanaged resources,
                //even if an exception occurs before we close the file.
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
            }catch (FileNotFoundException e)
            {
                WriteLine(e.Message);
            }
            WriteLine();

            WriteLine("Creating or adding to the file");
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("ABC");
                sw.WriteLine("DEF");
                sw.Close();
            }
            WriteLine();

            //Option 2: check if file exists (faster)
            if (File.Exists(path))
            {
                WriteLine("Writing the file in File.Exists()");
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
            }
            else
            {
                //Do something else
                WriteLine("Try creating the file first.");
            }
            ReadKey();
        }
    }
}
