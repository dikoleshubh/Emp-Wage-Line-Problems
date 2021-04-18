using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Cartecian
    {
        public static void CartecianR()
        {
            Console.WriteLine("Enter the Co Ordinates x1");
            Console.ReadLine();
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co Ordinates Y1");
            Console.ReadLine();
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co Ordinates X2");
            Console.ReadLine();
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co Ordinates Y2");
            Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Co Ordinates x1");
            Console.ReadLine();
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co Ordinates Y1");
            Console.ReadLine();
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co Ordinates X2");
            Console.ReadLine();
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co Ordinates Y2");
            Console.ReadLine();
            int b1 = Convert.ToInt32(Console.ReadLine());

            int m = (a - x);
            int n = (b - y);
            double v = Convert.ToDouble(m);
            double w = Convert.ToDouble(n);
            double line1 = Math.Sqrt(v + w);
            int m1 = (a1 - x1);
            int n1 = (b1 - y1);
            double v1 = Convert.ToDouble(m1);
            double w1 = Convert.ToDouble(n1);
            double line2 = Math.Sqrt(v1 + w1);

            

            
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
