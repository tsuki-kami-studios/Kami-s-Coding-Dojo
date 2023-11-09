using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    public class BasicDatatype
    {
        public static void Datatypes(string[] args)
        {
            // Declare variables
            bool myBool;

            byte myByte;
            sbyte mySbyte;
            Int16 myInt16;
            UInt16 myUint16;
            Int32 myInt32;
            UInt32 myUint32;
            Int64 myInt64;
            UInt64 myUint64;

            IntPtr myIntPtr;
            UIntPtr myUintPtr;

            double myDouble;
            float myFloat;
            decimal myDecimal;

            char myChar;
            string myString;

            // Assign values
            myBool = true;                      // true or false (0 - 1)

            mySbyte = 127;                      // -128 - 127
            myByte = 255;                       // 0 - 255
            myInt16 = 32767;                    // -32768 - 32767
            myUint16 = 65535;                   // 0 - 65535
            myInt32 = 2147483647;               // -2147483648 - 2147483647
            myUint32 = 4294967295;              // 0 - 4294967295
            myInt64 = 9223372036854775807;      // -9223372036854775808 - 9223372036854775807
            myUint64 = 18446744073709551615;    // 0 - 18446744073709551615
            //with c# also Int128, UInt128, Int512 and UInt512

            myIntPtr = new IntPtr(1);           // -2147483648 - 2147483647
            myUintPtr = new UIntPtr(1);         // 0 - 4294967295

            myDouble = 1.7976931348623157E+308; // -1.7976931348623157E+308 - 1.7976931348623157E+308
            myFloat = 3.40282347E+38F;          // -3.40282347E+38F - 3.40282347E+38F
            myDecimal = 79228162514264337593543950335m; // -79228162514264337593543950335 - 79228162514264337593543950335

            myChar = 'A';                       // Any character
            myString = "Hello, World!";         // Any string of characters

            var myCharArray = myString.ToCharArray(); 


            // Print values
            Console.WriteLine("myBool       : " + myBool);
            Console.WriteLine("mySbyte      : " + mySbyte);
            Console.WriteLine("myByte       : " + myByte);
            Console.WriteLine("myInt16      : " + myInt16);
            Console.WriteLine("myUint16     : " + myUint16);
            Console.WriteLine("myInt32      : " + myInt32);
            Console.WriteLine("myUint32     : " + myUint32);
            Console.WriteLine("myInt64      : " + myInt64);
            Console.WriteLine("myUint64     : " + myUint64);
            Console.WriteLine("myIntPtr     : " + myIntPtr);
            Console.WriteLine("myUintPtr    : " + myUintPtr);
            Console.WriteLine("myDouble     : " + myDouble);
            Console.WriteLine("myFloat      : " + myFloat);
            Console.WriteLine("myDecimal    : " + myDecimal);
            Console.WriteLine("myChar       : " + myChar);
            Console.WriteLine("myString     : " + myString);
            Console.WriteLine("myCharArray  : " + myCharArray[0]);


        }
    }
}
