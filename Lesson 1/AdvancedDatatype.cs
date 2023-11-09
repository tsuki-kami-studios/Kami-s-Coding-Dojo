using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    public class AdvancedDatatype
    {
        public static void Datatypes()
        {


            dynamic myDynamic; 
            object myObject; 

            DateTime myDateTime; 
            TimeSpan myTimeSpan; 
            DateTimeOffset myDateTimeOffset;
            TimeOnly myTimeOnly; 
            DateOnly myDateOnly; 

            Guid myGuid; 
            
            //Assign Values
            myDynamic = 1;              // Any value
            myObject = 1;                // Any value

            myDateTime = DateTime.Now; // 01.01.0001 00:00:00 - 31.12.9999 23:59:59
            myTimeSpan = TimeSpan.Zero; // -10675199.02:48:05.4775808 - 10675199.02:48:05.4775807
            myDateTimeOffset = DateTimeOffset.Now; // 01.01.0001 00:00:00 +00:00 - 31.12.9999 23:59:59 +14:00
            myTimeOnly = TimeOnly.FromDateTime(DateTime.Now); // 00:00:00 - 23:59:59
            myDateOnly = DateOnly.FromDateTime(DateTime.Now); // 01.01.0001 - 31.12.9999

            myGuid = Guid.NewGuid();  

            // Print values
            Console.WriteLine("myDynamic        : " + myDynamic);
            Console.WriteLine("myObject         : " + myObject);
            Console.WriteLine("myDateTime       : " + myDateTime);
            Console.WriteLine("myTimeSpan       : " + myTimeSpan);
            Console.WriteLine("myDateTimeOffset : " + myDateTimeOffset);
            Console.WriteLine("myTimeOnly       : " + myTimeOnly);
            Console.WriteLine("myDateOnly       : " + myDateOnly);
            Console.WriteLine("myGuid           : " + myGuid);
        }
    }
}
