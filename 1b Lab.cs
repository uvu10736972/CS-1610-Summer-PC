/*
Jake Hathaway
Lab 1b (DGM 1610)
5/31/2023
All code is original and typed by me
*/

//Objective 1: Create a program that asks the user to enter the current temperature in Celsius. Use an "if" statement to check if the temperature exceeds 30 degrees Celsius. If it is, display a message suggesting the user stay hydrated and avoid staying in the sun for too long. If the temperature is below 30 degrees Celsius, display a message suggesting the user enjoys the pleasant weather.

//Objective 2: Extend your program to prompt users to enter their exam scores as percentages. Use an "if-else" statement to check the score and provide a corresponding grade. For example, if the score is between 90 and 100, display an "A" grade message. If the score is between 80 and 89, display a "B" grade message, and so on. Provide appropriate feedback for various score ranges.
using System;

class Program {
  public static void Main (string[] args) {
    //Declare variables, get user input.
    int tooHott = 32;
    Console.WriteLine ("What is the current temperature (in celcius)?");
    //Condition check
    int userInput = Convert.ToInt32 (Console.ReadLine());
    if (userInput > tooHott)
      {
        Console.WriteLine("Woah there, it's way to hot right now. You'd best find some shade and a nice glass of lemonade pronto!");
      }
    else
    {
      Console.WriteLine("Enjoy the nice weather :)");
    }

    //Part B: Grade checker
    while (true)
    {
      //Use a try-catch condition if they type anything else other than a number.
      try
      {
        Console.WriteLine ("\nNow let's check your exam grade.\nPlease enter your exam score percentage:");
        int examResponse = Convert.ToInt32 (Console.ReadLine());
      
        //If the exam is over 100%
        if (examResponse > 100)
        {
          Console.WriteLine("No way you got over 100% on the exam. Try again.");
        }
        //A
        else if (examResponse <= 100 && examResponse >= 94)
          {
            Console.WriteLine("Final Score: A\nCongragulations!");
          }
        //A-
        else if (examResponse <= 93 && examResponse >= 90)
          {
            Console.WriteLine("Final Score: A-");
          }
        //B+
        else if (examResponse <= 89 && examResponse >= 87)
          {
            Console.WriteLine("Final Score: B+");
          }
        //B
        else if (examResponse <= 86 && examResponse >= 84)
          {
            Console.WriteLine("Final Score: B");
          }
        //B-
        else if (examResponse <= 83 && examResponse >= 80)
          {
            Console.WriteLine("Final Score: B-");
          }
        //C+
        else if (examResponse <= 79 && examResponse >= 77)
          {
            Console.WriteLine("Final Score: C+");
          }
        //C
        else if (examResponse <= 76 && examResponse >= 74)
          {
            Console.WriteLine("Final Score: C");
          }
        //C-
        else if (examResponse <= 73 && examResponse >= 70)
          {
            Console.WriteLine("Final Score: C-");
          }
        //D+
        else if (examResponse <= 69 && examResponse >= 67)
          {
            Console.WriteLine("Final Score: D+");
          }
        //D
        else if (examResponse <= 66 && examResponse >= 64)
          {
            Console.WriteLine("Final Score: D");
          }
        //D-
        else if (examResponse <= 63 && examResponse >= 60)
          {
            Console.WriteLine("Final Score: D-");
          }
        //F
        else if (examResponse <= 50 && examResponse >= 0)
          {
            Console.WriteLine("Final Score: F");
          }
        //Invalid input checker
        else
          {
            Console.WriteLine("Invalid Input. Please try again.");
          }
        }
      //Catch if anything but a number is inputed.
      catch
      {
        Console.WriteLine("Invalid Input. Please Try again");
      }
    }
  }
}