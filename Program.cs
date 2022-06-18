using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
         



       //Write a program to calculate the profit between the cost price of a product of $200.876 whose selling price is $255.425. The result should be in two decimal places.
         
         Console.WriteLine("Enter the cost price:");
         int cp = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Enter the selling price");
         int sp = Convert.ToInt32(Console.ReadLine());
         double profit = sp - cp;

          Console.WriteLine($"The profit between the cost price of {cp} and sale price of {sp} is {profit} ");

         

          /* Console.WriteLine("input first number");
           int value = 5;
           double firstnum = int.Parse(Console.ReadLine());
           Console.WriteLine("input second number");
           double secnum = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the answer");
          double correct = int.Parse(Console.ReadLine());
          double result2 = firstnum + secnum - value;
          if(result2 == correct)
          {
              Console.WriteLine("Correct answer");
        
          }
          else
          
          {
              Console.WriteLine($"Wrong answer, the correct answer is {result2} ");
          }*/
        







          





        }
    }
}
