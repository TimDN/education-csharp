using System;
using System.Diagnostics;
using System.IO;

namespace file_handling
{
    class Program
    {
        static void FileDemo()
        {
            string path = "test2.log";
            // Check if file does not exist
            if (!File.Exists(path))
            {
                //Creats file and opens with string stream 
                using (StreamWriter stream = File.CreateText(path))
                {
                    stream.WriteLine("Hello world");
                }
            }
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                // Reads to end of file and print
                Console.WriteLine(sr.ReadToEnd());
            }
        }

        static void UsingDemo()
        {
            string path = "test.log";
            using (StreamWriter stream = File.AppendText(path))
            {
                stream.WriteLine("Hello World");
            }
            // Not accesible here stream
            using (StreamReader stream = File.OpenText(path))
            {
                Console.WriteLine(stream.ReadToEnd()); // prints Hello World
            }
            
        }

        static void DirectoryDemo()
        {
            string logDirectory = "logs";
            string logPath = "logs/log.txt";
            if (!Directory.Exists(logDirectory))
            {
                //Creates directory if it does not exist
                Directory.CreateDirectory(logDirectory);
            }
            // Creates and opens the log file for appending
            using (StreamWriter stream = File.AppendText(logPath))
            {
                stream.WriteLine("Log line");
            }
            // Delete a directory and everything in it. A recursive delete
            Directory.Delete(logDirectory, true);
        }

        static void PathCombindDemo()
        {
            string logDirectory = "path";
            string logsPath = Path.Join(logDirectory, "logs.txt");
            // Windows path\logs.txt Linux path/logs.txt
            Console.WriteLine(logsPath);
            Console.WriteLine(Path.GetFullPath(logsPath)); // prints abs path
        }

        static void Main(string[] args)
        {
            //UsingDemo();
            //FileDemo();
            PathCombindDemo();
        }
    }
}
