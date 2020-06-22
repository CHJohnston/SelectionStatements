using System;

namespace SelectionStatementsConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Selection Operators Part 1 - Guess a Number             
            Console.WriteLine("Let's Play a Game - What is my favorite number(interger format)?");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());
            if (userInput > favNumber)
            {
                Console.WriteLine("Your guess is too High!");
            }
            else
            {
                if (userInput < favNumber)
                {
                    Console.WriteLine("Your guess is too Low!");
                }
                else
                {
                    Console.WriteLine($"Wow you can read minds!! {favNumber} is my favorite number!!");
                }
            }
            //Selection Operators Part 2 - Switch Statement
            Console.WriteLine("What was your favorite subject in High School?");
            var favSubject = (Console.ReadLine());
            switch (favSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("You must like to read.");
                    break;
                case "math":
                    Console.WriteLine("Balancing your checkbook is no problem for you.");
                    break;
                case "science":
                    Console.WriteLine("You probably enjoyed watching MythBusters.");
                    break;
                case "history":
                    Console.WriteLine("You probably enjoy watching the History Channel.");
                    break;
                case "computer science":
                    Console.WriteLine("Mine too!");
                    break;
                default:
                    Console.WriteLine("Sorry, Your favorite Subject was not in our list");
                    break;
            }
        } 
    } 
}
