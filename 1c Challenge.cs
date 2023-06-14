/*
Jake Hathaway
Challenge 1c: DGM 1610
6/8/2023

Note: All code is original and has been written by me.
*/

//Objective 1: Create a game where the program generates a random number between 1 and 10. Prompt the user to guess the number. Use a loop to give the user multiple chances to guess. Provide feedback after each guess, indicating if the guess is too high or too low. When the user assumes the correct number, display a congratulatory message and the number of attempts made.

//Objective 2: Create a program that prompts the user to enter their three favorite foods. Use an array to store these food items. Display each item on a new line with a message, such as "I love [food item]!". Use a loop to iterate through the array and print the messages
using System;

class Program 
{
  public static void Main (string[] args) 
  {

      //Generate a random number
      Random rnd = new Random();
      int RNG  = rnd.Next(1, 10);
      
      //Initiate input to start the guess game (while loop)
      int input = 0;
      Console.WriteLine("\nThe Guessing Game\n");

      //Guess Game
      while (input != RNG)
      {
      try
        {
        //Get the user response each time while the game is playing (until the number is found)
        Console.WriteLine("\nGuess a number between 1-10:");
        input = Convert.ToInt32(Console.ReadLine());
      
        if (input < RNG)
          {
              Console.WriteLine("\nToo Low. Try a higher number.\nCurrent Number: " + input);
          }
        else if(input > RNG)
          {
              Console.WriteLine("\nToo High. Try a lower number.\nCurrent Number: " + input);
          }
        }
        //If user enters anything but a number
        catch
        {
          Console.WriteLine("\nInvalid Input. Please try again.");
        }
      }
    
    //Number Found!
    Console.WriteLine("\nCongragulations!\nYou found the number!\n\nThe answer was: " + RNG);

    //Food Print
    //Note: I tried to find a way to have it so each empty char (space) would separate each item as an array value. Sadly, I have to have the user input each food item one at a time :(
    Console.WriteLine("\nHave a favorite food? Great! What's your first place in food?");
    string first = Console.ReadLine();
    Console.WriteLine("\nWhat's your second favorite food?");
    string second = Console.ReadLine();
    Console.WriteLine("\nAnd finally, what's your third favorite food?");
    string third = Console.ReadLine();

    //Take inputs, store them in an array, print array
    string[] foods = {first,second,third};

    Console.WriteLine("\nYour top 3 favorite foods are: ");

    int i = 1;
    foreach(var food in foods)
    {
      Console.WriteLine(i + ". " + food.ToString());
      i++;
    }
  }
}