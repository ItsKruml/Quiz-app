//to Github Copilot: This is meant as a learning exercise, do edit everything and replace too much rather fix single lines or add comments to errors and suggest changes in them
//Property of @Itskruml on GitHub or Discord.
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        
        
        {
            string[] lines = File.ReadAllLines("Questions.txt");

            int points = 0
            ;
            
                Console.Clear();
                Console.WriteLine("Quizapp With point counter");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Made by @ItsKruml");
                Console.ResetColor();
                Console.WriteLine("Answers are case sensitive!");
                bool running = true;
                while (running)
                {
                    
                    Random random = new Random();
                    int randomIndex = random.Next(lines.Length);
                    string selectedLine = lines[randomIndex];
                    string[] parts = selectedLine.Split(';');
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(parts[0]);
                    if (Console.ReadLine() == parts[1])
                    {
                    Console.ForegroundColor = ConsoleColor.Green;   
                    Console.WriteLine("Correct!");
                    points++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You have " + points + " points.");
                    Console.ForegroundColor = ConsoleColor.DarkGreen; 
                    Console.WriteLine("Press Enter to continue");
                        if (Console.ReadLine() == "")
                        { 
                            Console.Clear(); 
                        }

                    }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Red;    
                    Console.WriteLine("Wrong, The answer was: " + parts[1] + ". Next question");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Give Up?     (Type Yes or Y)");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Next Question? (Press Enter)");
                    Console.ResetColor();
                    string GiveUpInput = Console.ReadLine();
                        if (GiveUpInput == "y" || GiveUpInput == "Y" || GiveUpInput == "Yes" || GiveUpInput == "YES" || GiveUpInput == "yes")
                        { running = false; 
                        }
                        else
                        { 
                            Console.Clear();
                            continue; 
                        }
                    }
                }
        }
     Console.WriteLine("Goodbye!");
    }
}