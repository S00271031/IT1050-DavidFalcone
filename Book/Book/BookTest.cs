using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
   class BookTest
   {
      static void Main()
      {
         // 4) Creating multiple constructors of a class is is called overloading.  An 
         //    overloaded constructor enables objects of that class to be initialized in 
         //    different way.
         //
         // 5) Exception handling enables you to create fault-tolerant programs that can  
         //    resolve exceptions.
         // 6) Using the public access modifier allows access from any where while using 
         //    private restricts access to the body of the class.  Private helps to hide 
         //    data you dont want seen elsewhere.
         // 7) Composition is a 'has-a relationship' allowing you to reference objects of 
         //    other classes.  In our program we could have used composition to access the 
         //    title and author rather than calling display.
         // 8) Data abstraction is the hiding of certain information from the user.

         string title = "Goode Book!";
         string author = "Ireade Goode";
         int year = 2019;

         var book1 = new Book();

         book1.Title = title;
         book1.Author = author;
         book1.Year = year;

         Console.WriteLine($"{book1.Display()}");

         Console.ReadLine();

      }
   }
}
