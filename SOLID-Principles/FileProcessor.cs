using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public interface IFileReader
    {
        string ReadFile(string filePath);
    }

    public interface IFileWriter
    {
        void WriteFile(string filePath, string content);
    }

    public class FileReader : IFileReader
    {
        public string ReadFile(string filePath)
        {
            // Code to read file
            return "File Content";
        }
    }

    public class FileWriter : IFileWriter
    {
        public void WriteFile(string filePath, string content)
        {
            // Code to write file
        }
    }

    public class FileProcessor
    {
        IFileReader fileReader;
        IFileWriter fileWriter;

        public FileProcessor(IFileReader fileReader, IFileWriter fileWriter)
        {
            this.fileReader = fileReader;
            this.fileWriter = fileWriter;
        }

        public void ProcessFile(string inputFilePath, string outputFilePath)
        {
            string fileContent = fileReader.ReadFile(inputFilePath);
            // Process file content
            fileWriter.WriteFile(outputFilePath, fileContent);
        }
    }
}

//The FileProcessor class directly depends on the concrete implementations of FileReader and FileWriter, which are low-level modules. This direct dependency violates the DIP