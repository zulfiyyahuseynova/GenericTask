using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask.Models
{
    class Pdf : IPrintapleFile
    {
        public string FileName { get; set; }
        public int PageCount { get; set; }

        public Pdf(string fileName, int pageCount)
        {
            FileName = fileName;
            PageCount = pageCount;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} file printed, {PageCount} pages.");
        }
    }
}
