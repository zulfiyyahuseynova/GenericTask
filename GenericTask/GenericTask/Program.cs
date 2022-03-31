using System;
using GenericTask.Models;

namespace GenericTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Excell exc = new Excell("Table", 10, 10);
            PrintFile<Excell> file = new PrintFile<Excell>(exc);
        }
    }
}
