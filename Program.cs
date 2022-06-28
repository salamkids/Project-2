using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        { 
        
  
    /*  var numbers = new int[]{1,2,3,4,5};
      Arrays.Reverse(numbers);
      for(int i = 0; i <= numbers.Length; i++)
      {
         Console.WriteLine(numbers[i]);
      }*/


      string[] months = {"January", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december"};
       for (int num = 0; num < months.Length; num++)
       { 
           Console.WriteLine("{1}", num, months[num]);

          Console.WriteLine(" ");
       }
        
      //Reverse the months with loop
      for (int reverse = months.Length - 1; reverse >= 0; reverse--)
      {
           Console.WriteLine(months[reverse] + " ");
           Console.WriteLine(" ");
      }

        // Reverse the months with arrays.
         /*int reverser = months.Length;
         int[] reversed = new int[reverser];
         for (int rev = 0; rev < reverser; rev++)
         {  
           reversed[reverser - rev - 1] = months[rev];
         }
         for (int rev = 0; rev < reverser; rev++)
         {   
          Console.WriteLine(reversed[rev] + " ");

         }*/



       //return the ranks.

       Console.WriteLine("The number of months is " + months.Length + ".");
       for(var i = 0; i< months.Length; i++)
       { 
           Console.WriteLine($"Element in index {i} is {months[i]}");
       }
           Console.WriteLine(" ");   


        // copy 1st 6 months to another array.
        
        string [] copy = new string[6];
        Array.Copy(months,0, copy,0, 6);
       foreach(string item in copy)
       {Console.WriteLine(item);}
        Console.WriteLine(" ");

 

         // Sort Alphabetically

        Array.Sort(months);
        Console.WriteLine(String.Join("\n", months)); 

          

        
          int indexToRemove = 6;
         months = months.Where((source, index) =>index != indexToRemove).ToArray();

          foreach(string value in months) {
          Console.WriteLine(value);
         }



        }
    }
}
