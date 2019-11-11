using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
   class Program
   {
      static void Main(string[] args)
      {
         // The four basic elements of the counter-controlled repetition.
         // 1) a conrol variable to keep track of the number of loops
         // 2) the control variable's initial value
         // 3) the control variable's increment that's applied during each iteration of the loop
         // 4) the loop-continuation condition that determines if looping should continue

         // Compare and contrast the while and for repetition statements.
         // Typically, for statements are used for counter controlled iteration, and while 
         // statements for sentinel-controlled iteration.  However, while and for can each be 
         // used for either iteration type.

         // Do-While loops are perfered if you want your statements to execute at least one time 
         // no matter what your loop conditions dictate

         for (int i = 1; i <= 100; ++i)
         {
            if (i % 2 == 0)
            {
               Console.WriteLine($"{i} is even!");
            }
            else
            {
               Console.WriteLine($"{i} is odd!");
            }
         }

         Console.ReadLine();  // added to check output

         Console.WriteLine("Please enter a temperature:");
         int temp = Int32.Parse(Console.ReadLine());
         if (temp < 10)
         {
            Console.WriteLine("Polar Bear");
         }
         else if (temp < 20)
         {
            Console.WriteLine("Penguin");
         }
         else if (temp < 40)
         {
            Console.WriteLine("Moose");
         }
         else if (temp < 50)
         {
            Console.WriteLine("Reindeer");
         }
         else if (temp < 60)
         {
            Console.WriteLine("Deer");
         }
         else if (temp < 70)
         {
            Console.WriteLine("Turtle");
         }
         else if (temp < 80)
         {
            Console.WriteLine("Lion");
         }
         else if (temp < 90)
         {
            Console.WriteLine("Fish");
         }
         else
         {
            Console.WriteLine("Bug");
         }
         Console.ReadLine();   // added to check output

         int g = 10;
         while (g < 21)
         {
            Console.WriteLine(g);
            g++;
         }
         Console.ReadLine();   // added to check output

         for (int h = 0; h < 101; h++)
         {
            Console.WriteLine(h);
            Console.WriteLine("********");
         }

         Console.ReadLine();   // added to check output


      }
   }
}
