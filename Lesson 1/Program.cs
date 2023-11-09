using System.Runtime.InteropServices;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lesson 1");
            Console.WriteLine("                 by Tsuki Kami\n\n\n");

            Console.WriteLine("Datatypes:\n");
            BasicDatatype.Datatypes(args);

            Console.WriteLine("Advanced Datatypes:\n");
            AdvancedDatatype.Datatypes();

            Console.WriteLine("Enumerable Datatypes:\n");
            EnumerationDatatype.Datatypes();

        }
    }
}