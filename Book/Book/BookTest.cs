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
