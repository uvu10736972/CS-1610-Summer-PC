/*
Jake Hathaway
DGM 1610: Unit 1.a Lab
5/23/23

All code is original and has been written by me.
*/


using System;

//Declare the class
public class Player
{
    //Class instances
    string userName;
    int playerID;
    int level;
    int defaultHealth;

    //Class Constructor
      public Player(string userName, int playerID, int level, int defaultHealth)
        {
          this.userName = userName;
          this.playerID = playerID;
          this.level = level;
          this.defaultHealth = defaultHealth;
        }
    public string getuserName()
    {
      return userName;
    }
    
    public int getplayerID()
    {
      return playerID;
    }
    
    public int getlevel()
    {
      return level;
    }
    
    public int getdefaultHealth()
    {
      return defaultHealth;
    }
    //To string method to print to console.
    public String ToString()
    {
        return ("\nWelcome " + this.getuserName() + "!\n" + "Player ID: " + this.getplayerID() + "\nCurrent Level: " + this.getlevel() + "\nHealth: " + this.getdefaultHealth());
  }

public static void Main (string[] args) 
  {
    while(true)
    {
      int searches = 0;
      Console.WriteLine("\nPlease enter your username: ");
      string input = Console.ReadLine();
        if (input == "Mootkins")
        {
          Player player1 = new Player("Mootkins",114,100,100);
          Console.WriteLine(player1.ToString());
        }
        else if(input == "Test" || input == "test")
        {
          Player test = new Player("test",0,1,100);
          Console.WriteLine(test.ToString());
        }
        else
        {
          Console.WriteLine("Sorry, that username doesn't exist. Please try again.");
        }
      searches++;
      Console.WriteLine("\nNumber of Searches: " + searches);
    }
  }
}