using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
   class Program
   {
      static void Main(string[] args)
      {
         // 2) A one dimensional array p contains four elements.  The array access expressions
         //    to access each of the elements in p are p[0], p[1], p[2] and p[3].

         // 3) 12-element array called months.
         string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

         Console.WriteLine($"{"Number"} {"Month"}");
         for (var number = 0; number < months.Length; ++number)
         {
            Console.WriteLine($"{number + 1,4}   {months[number]}");
         }
         Console.ReadLine();  //added to pause execution

         // 4) 4-element array called seasons
         string[] seasons = { "spring", "summer", "fall", "winter" };

         foreach (string partYear in seasons)
         {
            Console.WriteLine(partYear);
         }
         Console.ReadLine();  //added to pause execution

         // 5) 1000 element array of random integers.
         int[] array1000 = new int[1000];

         Random random = new Random();
         int randomNumber;

         for (int counter = 0; counter < array1000.Length; ++counter)
         {
            randomNumber = random.Next(0, 100);
            array1000[counter] = randomNumber;
         }

         foreach (int value in array1000)
         {
            Console.WriteLine(value);
         }
         Console.ReadLine();  //added to pause execution

         // 6) Output each string in the array called names
         string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

         int i = 0;
         while (i < names.Length)
         {
            Console.WriteLine(names[i]);
            ++i;
         }

         Console.ReadLine();  //added to pause execution

         // 7) Modify #6
         // string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

         i = 0;
         while (i < names.Length)
         {
            Console.WriteLine("{0,2}. {1}", i, names[i]);
            ++i;
         }

         Console.ReadLine();  //added to pause execution

         // 8) Number 6 with a foreach loop
         // string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

         foreach (string noun in names)
         {
            Console.WriteLine(noun);
         }

         Console.ReadLine();  //added to pause execution

      }
   }
}
