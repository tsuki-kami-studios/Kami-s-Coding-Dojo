using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Datatype
    {
        static void Datatypes(string[] args)
        {
            // Declare variables
            bool myBool;

            byte myByte;

            Int16 myInt16;
            UInt16 myUint16;
            Int32 myInt32;
            UInt32 myUint32;
            Int64 myInt64;
            UInt64 myUint64;

            double myDouble;
            float myFloat;

            char myChar;
            string myString;

            // Assign values
            myBool = true;                      // true or false (0 - 1)

            myByte = 255;                       // 0 - 255
            myInt16 = 32767;                    // -32768 - 32767
            myUint16 = 65535;                   // 0 - 65535
            myInt32 = 2147483647;               // -2147483648 - 2147483647
            myUint32 = 4294967295;              // 0 - 4294967295
            myInt64 = 9223372036854775807;      // -9223372036854775808 - 9223372036854775807
            myUint64 = 18446744073709551615;    // 0 - 18446744073709551615

            myDouble = 1.7976931348623157E+308; // -1.7976931348623157E+308 - 1.7976931348623157E+308
            myFloat = 3.40282347E+38F;          // -3.40282347E+38F - 3.40282347E+38F

            myChar = 'A';                       // Any character
            myString = "Hello, World!";         // Any string of characters

            char[] myCharArray = myString.ToCharArray(); 


            // Print values
            Console.WriteLine(myInt16);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);
            Console.WriteLine(myDouble);
            Console.WriteLine(myFloat);
            Console.WriteLine(myChar);
        }
    }
}
