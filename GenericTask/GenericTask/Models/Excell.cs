using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask.Models
{
    class Excell : IPrintapleFile
    {
        public string FileName { get; set; }
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }

        public Excell(string fileName, int columnCount, int rowCount)
        {
            FileName = fileName;
            ColumnCount = columnCount;
            RowCount = rowCount;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} file printed, {ColumnCount} columns, {RowCount} rows.");
        }
    }
}
