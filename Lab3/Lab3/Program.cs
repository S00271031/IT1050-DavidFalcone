using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
   class Program
   {
      static void Main(string[] args)
      {
         // question 2

         /* With the if single selection statement you are limited to a single pass with a single desicion.
          * With the while repetition statement it allows you to loop through your code segement until a desicion is true and then it end.*/

         // question 3

         int speedLimit = 35;
         int speed = 42;

         if (speed > speedLimit)
            {
            Console.WriteLine("SLOW NOW");
            }
         Console.ReadLine();  // used to pause program to check work

         // question 4

         bool isTrue = false;

         if (isTrue == true)
            {
            Console.WriteLine("It is True!");
            }
         else
            {
            Console.WriteLine("It is False!");
            }
         Console.ReadLine();  // used to pause program to check work

         // question 5

         Console.WriteLine("Type in a temperature in degrees fahrenheit:");
         double fahrenheit = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine($"That equals {(fahrenheit - 32d) * 5d / 9d} degrees celsius!");
         if (fahrenheit < 40)
            {
            Console.WriteLine("It is cold");
            }
         if (fahrenheit > 90)
            {
            Console.WriteLine("It is hot");
            }
         Console.ReadLine();  // used to pause program to check work

         // question 6

         int number1 = 1;

         while (number1 < 11)
            {
            Console.WriteLine(number1++);
            }
         Console.ReadLine();  // used to pause program to check work

         // question 7

         int number2 = 60;

         while (number2 >19)
            {
            Console.WriteLine(number2);
            number2 = number2 - 5;
            }
         Console.ReadLine();  // used to pause program to check work

         // question 8

         int number3 = 10;

         while (number3 < 21)
            {
            Console.WriteLine(number3);
            number3 = number3 + 2;
            }
         Console.ReadLine();  // used to pause program to check work



      }
   }
}
