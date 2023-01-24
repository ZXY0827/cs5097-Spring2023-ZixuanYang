// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            // Console.WriteLine("Hello World!");
            // int numberToGuess = new Random().Next(1,101); 
            // int currentGuess = 0; 
            // while (currentGuess != numberToGuess)
            // {
            //     Console.WriteLine("Guess the number (1 to 100): ");
            //     currentGuess = int.Parse(Console.ReadLine());
            //     if (currentGuess < numberToGuess)
            //     {
            //         Console.WriteLine("You guessed too low! Try again!");
            //     }
            //     if (currentGuess > numberToGuess)
            //     {
            //         Console.WriteLine("You guessed too high! Try again!");
            //     }
            // }
            // Console.WriteLine("You got it! Good job!");
            int[] someIntegers = { 1, 2, 3 };

            int x = 1 + someIntegers[0]; 
            Console.WriteLine(x);

            int y = 2 * someIntegers[2]; 
            Console.WriteLine(y);

            someIntegers[2] = y; 
            Console.WriteLine(someIntegers[0]);
            Console.WriteLine(someIntegers[1]);
            Console.WriteLine(someIntegers[2]);

            // following lines produces an exception
            // someIntegers[3] = 3; 
        }
    }
}
