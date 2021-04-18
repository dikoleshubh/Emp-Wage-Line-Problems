using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Cartecian
    {
                 

            
            lineCompare(line1, line2); ////cOMPARISION OF TWO LINES

        } 
          private static void lineCompare(double line1 , double line2)
        {
            double Result = line1.CompareTo(line2);
            Console.WriteLine(Result); //// RESULTS BASED UPON LENGTH
            if (Result == 0)
            {
                Console.WriteLine(" Both Lines Are Equal");
            }
            else if (Result < 0.0)
            {
                Console.WriteLine("line 1 is less than line 2 ");
            }
            else
            {
                Console.WriteLine("line 2 is less than line 1 ");
            }
        }
        

    }
}
