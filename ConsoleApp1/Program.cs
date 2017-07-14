using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Functions
    {
        public static int newRandom;

        public static void randomNumber(int inputAmount, int inputSides)
        {
            int randomNumber;
            Random rnd = new Random();
            for (int i = 0; i < inputAmount; i++)
            {
                randomNumber = rnd.Next(1, inputSides);
                Console.WriteLine(randomNumber);
            }
        }
        public static void generateRandom(int maxnumber)
        {     
            Random rnd = new Random();
            newRandom = rnd.Next(1, maxnumber);
            return;
        }
        public static void checkRange()
        {
            if (Program.inputGuess <= newRandom + (newRandom * 0.1)&& Program.inputGuess >= newRandom - (newRandom* 0.1))
            {
                if (Program.inputGuess <= newRandom + (newRandom * 0.05) && Program.inputGuess >= newRandom - (newRandom * 0.05))
                {
                    Console.WriteLine("YOU'RE SUPER CLOSE MY DUDE!");
                }
                else
                {
                    Console.WriteLine("You're getting close though!");
                }
                   
            }
        }

            class Program
            {
            public static int inputGuess;
            public static int totalGuesses;

                static void Main(string[] args)

                {
                      /*
                   int inputAmount;
                   int inputSides;
                   Console.WriteLine("How many numbers?");
                   inputAmount = Convert.ToInt32(Console.ReadLine());

                   Console.WriteLine("How many sides?");
                   inputSides = Convert.ToInt32(Console.ReadLine());

                   randomNumber(inputAmount, inputSides);
                       */
                int inputMaxNumber;
                bool numberGuessed = false;
                
                Console.WriteLine("What is your max number?");
                inputMaxNumber = Convert.ToInt32(Console.ReadLine());

                generateRandom(inputMaxNumber);
                while (numberGuessed != true)
                {
                    Console.WriteLine("Guess a number");
                    inputGuess = Convert.ToInt32(Console.ReadLine());
                    totalGuesses += 1;
                    if (inputGuess < newRandom)
                    {
                        Console.WriteLine("Your guess is too low.");
                        checkRange();
                    }
                    else if (inputGuess > newRandom)
                    {
                        Console.WriteLine("Your guess is too high.");
                        checkRange();
                    }
                    else
                    {
                        Console.WriteLine("You guessed the number!\n");
                        numberGuessed = true;
                        break;
                    }              
                }
                Console.WriteLine("You guessed the number in " + totalGuesses + " guesses");


                Console.ReadLine();
                    

                }
            }




        }
    }


        
                 


      
       


          
        
    
  

