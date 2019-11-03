using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   class Program
   {
      static void Main(string[] args)
      {

         int number1;   // declare first integer to multiply
         int number2;   // declare second integer to multiply
         int product;   // declare product of number1 and number 2

         Console.WriteLine("Enter first integer: ");  // prompt user
         number1 = Convert.ToInt32(Console.ReadLine());  // read first number from user

         Console.WriteLine("Enter second integer: "); // prompt user
         number2 = Convert.ToInt32(Console.ReadLine());  // read second number from user

         product = number1 * number2;  // multiply the numbers

         Console.WriteLine("The product of {0} * {1} = {2}", number1, number2, product);  // display the product
         Console.ReadLine();  // pause between steps to see the output

         Console.WriteLine("{0}\n{1}", "Hello World!", "From David Falcone");
         Console.ReadLine();  // pause between steps to see the output

         /* a) The program execution begins with the Main method
          * b) int - stores only whole numbers in the range from -2,147,483,648 to 2,147,483,647
          *    double - stores whole and fractional values in the range from -1.79769313486232e308 to 1.79769313486232e308
          * c) SetName and GetName are examples of methods from chapter 4
          * d) To read the value of an instance value, we create a method called a get accessor.
          *    To assign a value to an instance valriable, we use a method called a set accessor.
          * e) A class sets up the properties and methods that will be used in the class.
          *    An object is an instance of the class.
          *    You can technically have an unlimited number of instances of a class as long as you have free memory.
          */
      }
   }
}
