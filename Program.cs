using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {


            // 2D array
            int[,] numberGrid = {
            {1,2},
            {3,4},
            {6,9}
            };
            // int[ , , ] this means an array of arrays where each array has 3 elements
            // or int[,] arrayName = new int[2,3] this array will have 2 arrays, each with 3 elements 

            Book book1 = new Book();
            book1.title = "Os Lusíadas";
            book1.author = "Luís de Camões";
            book1.pages = 356;
            
            
            Console.WriteLine(book1.pages);

            
            Console.ReadLine();
        
        }

        static int cube(int n)
        {
            return n * n * n;

        }

        static int getMax(int n1, int n2, int n3)
        {
            int result;
            if (n1 >= n2 && n1 >= n3)
            {
                result = n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                result = n2;
            }
            else
            {
                result = n3;
            }
            return result;
        }


        static string dayOfTheWeek(int dayNumber)
        {
            string dayName;
            
            switch(dayNumber)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "The week has 7 days";
                    break;
            }


            return dayName;
        }

        static void guesstheWord()
        
        {
            string secretWord = "Learning";
            string usersGuess = "";
            int guessLimit = 5;
            int guessCount = 0;
            bool outOfGuesses = false;

            while(usersGuess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit) 
                {
                    Console.Write("ENTER A GUESS: ");
                    usersGuess = Console.ReadLine();
                    guessCount++;
                }
                else 
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("Better Luck next time!");
            }
            else 
            {
                Console.WriteLine("Congratulations! You won!!!");
            }

        }

        // exponential function - takes in 2 integers a base and an exponent and return base to the exponent power

        static double power(int b, int exponent)
        {
            double result = 1;
            if (exponent == 0)
            {
                result = result;
            }
            else if (exponent < 0)
            {
                exponent = -1*exponent;
                for(int i = 0; i < exponent; i++)
                {
                    result = result * 1/b;
                }
            }
            else
            {
               for(int i = 0; i < exponent; i++)
                {
                    result = result * b;
                }
            }
            return result;
        }
    }
}
