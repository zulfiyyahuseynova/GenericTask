using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask.Models
{
    class Word : IPrintapleFile
    {
        public string FileName { get; set; }
        public int WordCount { get; set; }

        public Word(string fileName, int wordCount)
        {
            FileName = fileName;
            WordCount = wordCount;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} file printed, {WordCount} words.");
        }
    }
}
