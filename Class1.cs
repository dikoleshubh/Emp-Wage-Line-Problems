using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Cartecian
    {
        public static void CartecianR()
        {////TAKING INPUT AS (X1,Y1) & (X2,Y2) FOR LINE 1
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
////TAKING INPUT AS (X1,Y1) & (X2,Y2) FOR LINE 2
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
            
            //// Length of a Line = sqrt( (x2 - x1) ^ 2 + (y2- y1) ^ 2)
            //// COMPUTATION
            int m = (a - x);
            int n = (b - y);
            double v = Convert.ToDouble(m); ////CONVERSION TO DOUBLE
            double w = Convert.ToDouble(n);
            double line1 = Math.Sqrt(v + w);
            int m1 = (a1 - x1);
            int n1 = (b1 - y1);
            double v1 = Convert.ToDouble(m1); ////CONVERSION TO DOUBLE
            double w1 = Convert.ToDouble(n1);
            double line2 = Math.Sqrt(v1 + w1); 

            

            
           

        } 
      


    }
}
