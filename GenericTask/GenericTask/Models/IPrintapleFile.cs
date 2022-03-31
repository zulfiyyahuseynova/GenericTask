using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask.Models
{
    public interface IPrintapleFile
    {
        public string FileName { get; set; }
        public void Print();
    }
}
