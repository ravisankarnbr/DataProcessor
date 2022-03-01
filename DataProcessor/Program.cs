
using DataApplicaton;
using DataApplicaton.Factory;
using System;

namespace DataProcessor
{
    class Program
    {
        private static void Main(string[] args)
        {
            FileDataProcessor();
            Console.ReadKey();
        }

        private static void FileDataProcessor()
        {
            var filePath = string.Empty;
            Console.Write("input data type : binary, text , textreverse\n\n");
            Console.Write("Please enter data type: ");
            string val = Console.ReadLine();
            Enum.TryParse(val.ToLower(), out FileType dt);

            if (dt == 0)
            {
                Console.Write("Invalid data Type");
            }

            switch (dt)
            {
                case FileType.binary:
                    var binaryFile = new BinaryFileProcessor("Binary_File.txt").ReadFile();
                    Console.WriteLine(binaryFile.ProcessFile());
                    break;
                case FileType.text:
                    var textFile = new TextFileProcessor("Text_File.txt").ReadFile();
                    Console.WriteLine(textFile.ProcessFile());
                    break;
                case FileType.textreverse:
                    var textRevese = new TextRevProcessor("Text_File.txt").ReadFile();
                    Console.WriteLine(textRevese.ProcessFile());
                    break;
                default:
                    break;
            }
        }
    }
}
