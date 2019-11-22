using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
   class Program
   {
      static void Main(string[] args)
      {
         // 2) 3 types of control structures
         //    i)    Sequence structure - The built in structure where the computer executes
         //          the commands in the order that they were written.
         //    ii)   Selection statements - These include the if, if--else and switch statments.
         //          Used to do an operation based on a condition. 
         //    iii)  Iteration - repetition or looping  statements.  These include the while,
         //          do--while, for and foreach statements.  
         
         // 3) Create an infinite while loop.
         // bool keepLooping = true;   // commented out to run other steps
         // while (keepLooping == true)
         // {
         // 
         // }

         // 4) Write a while loop to print 2 through 128 in brackets. 
         //    Writen based on the instructions.
         int loop128 = 2;
         while (loop128 <= 128)
         {
            Console.WriteLine($"[{loop128}]");
            ++loop128;
            if (loop128 == 65)
            {
               break;
            }
         }
         Console.ReadLine();  // added to pause execution

         // 4) Write a while loop to print 2 through 128 in brackets. 
         //    Writen based on the example.

         int power2 = 1;
         while (power2 <= 7)
         {
            Console.WriteLine("[" + Math.Pow(2, power2++) + "]");
         }
         Console.ReadLine();  // added to pause execution


         // 5) Write a loop that prints 49 through 1 seperated by a comma
         int loop49 = 49;
         while (loop49 >= 1)
         {
            if (loop49 == 49)
            {
               Console.Write(loop49--);
            }
            else
            {
               Console.Write($", {loop49--}");
            }
         }
         Console.WriteLine();
         Console.ReadLine();  // added to pause execution

         // 6) Write a while loop that prints all odd numbers 1 through 21
         int loop21 = 1;
         while (loop21 <= 21)
         {
            Console.Write($"{loop21} ");
            loop21 += 2;
         }
         Console.WriteLine();
         Console.ReadLine();  // added to pause execution

         // 7) When you use the DO statement the included logic is executed even though the
         //    statement is false.  So you will get one * as an output.  If you change and use
         //    a WHILE statement then you get no ouput.

         // 8) Explain how do we combine multiple Boolean values?
         //    You can combine multiple Boolean values by using logical operators like AND
         //    and OR.
         Boolean icyRain = false;
         Boolean tornadoWarning = false;
         if (icyRain == false && tornadoWarning == false)
         {
            Console.WriteLine("Let's go outside!");
         }
         Console.ReadLine();  // added to pause execution

         // 9) Extra credit
         int loop5 = 5;
         int space;
         int number5;
         int number;
         while (loop5 >= 1)
         {
            space = 5 - loop5;
            while (space >= 1)
            {
               Console.Write(" ");
               --space;
            }
            number5 = 1;
            while (number5 < loop5)
            {
               Console.Write(number5++);
            }
            while (number5 >= 1)
            {
               Console.Write(number5--);
            }
            --loop5;
            Console.WriteLine();
         }
         Console.ReadLine();  // added to pause execution


      }
   }
}
