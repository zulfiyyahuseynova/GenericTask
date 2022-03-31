using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask.Models
{
    class PrintFile<T>
        where T: IPrintapleFile
    {
        public PrintFile(T file)
        {
            file.Print();
        }
    }
}
