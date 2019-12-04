using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
   public class Book
   {
      public string Title { get; set; }
      public string Author { get; set; }
      public int Year { get; set; }

      public string Display() =>
         $"{"Title = ",10}: {this.Title}" +
         $"\n{"Author = ",10}: {this.Author}";

   }
}
