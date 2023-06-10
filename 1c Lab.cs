/*
Jake Hathaway
Lab 1c: DGM 1610
6/6/2023

Note: All code is original and has been written by me.
*/

/*Challenge: Number Pyramid
Create a program that prints a number pyramid pattern using nested loops and conditional statements. The program should prompt the user to enter a positive integer representing the number of rows in the pyramid. Each row should contain numbers in ascending order, starting from 1 and incrementing by 1. Use nested loops to achieve the pattern. For example, if the user enters 5, the program should output the following pyramid:
using System;*/

using System;
class Program 
{
  public static void Main (string[] args) 
  {
  while(true)
    {
      try
      {
        //User Prompt
        Console.WriteLine("\nPlease Enter a positive integer number to generate the number of rows for the pyramid.");
        int numPyramid = Convert.ToInt32(Console.ReadLine());
        
        //If user enters a number less than 0.
        if (numPyramid <= 0)
        {
          Console.WriteLine("Invalid Input. Please enter a positive integer number.");
        }
  
        //Print the Pyramid
        else
        {
          //Initiate variables for for loops
          int i = 0;
          int j = 0;
          int k = 0;
          //For-loop i looks at the value of numPyramid
          for (i = 1; i <= numPyramid; i++)
            {
              //For-loop j (looking at the value of numPyramid) makes the spacing starting at 1
              for (j = 1; j < numPyramid-i+1; j++)
              {
                  Console.Write(" ");
              }
              //Once the Spacing is created at index numPyramid-i+1, For-loop k prints the number
              for (k = 1; k <= i; k++)
              {
                  Console.Write(i);
                  Console.Write(" ");
              }
              Console.WriteLine();
            }
        }
     }
      //If anything but a number is entered.
      catch
      {
        Console.WriteLine("Invalid Input. Please enter a positive integer number.");
      }
    }
  }
}
