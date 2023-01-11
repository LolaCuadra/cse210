using System;

class Program
{
    static void Main(string[] args)
    {
      Random randomGenerator = new Random(); //randomeGenerator is a variable 
      int number = randomGenerator.Next(1, 11); // specify data types so you save space  for what you need
      // Console.WriteLine($"Your random number is... {number}"); // how to write your random number is (formatted string) $$$

      bool guessed = false;
      int turns = 0;

      while(guessed == false)
      {
        Console.Write("Please enter your guess: ");
        int answer=  int.Parse(Console.ReadLine()); // Check differences between Write and WriteLine
        turns += 1;

        if (answer > number){
        Console.WriteLine("lower");
        }

        else if (answer < number){
          Console.WriteLine("higher");
        }

        else
        {
          Console.WriteLine("correct. perfect. great job!");
          guessed = true;
        }
      
      // Console.WriteLine($"They guessed: {answer}"); 
      }
  Console.WriteLine($"it took you {turns} turns to guess the number");
    }
}
