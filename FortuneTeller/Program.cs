using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the first project - a fortune teller program
            //part 1 - Asks the user for input - first name, last name, age, birth month (as int), fav color, #siblings
            //part 1A - fav color help - ROYGBIV = red, orange, etc. and then ask user to input fav color again
            //part 2 - checks the input against cases to determine "fortune"
            //part 3 - prints out their fortune
            //Note: Program should be able to handle whether or not a user inputs capital or lowercase letters.
            

            Console.WriteLine("Welcome to Madame Margaret's Fortune Telling Machine!\n\n");
            
            //----------------------------------------------------------------------------------------------
            //NAME - for this program, whatever the person inputs (case-wise) doesn't matter
            Console.WriteLine("\nPlease enter your first name:");
            string firstName = Console.ReadLine();
           
            Console.WriteLine("\nPlease enter your last name:");
            string lastName = Console.ReadLine();
         

            //----------------------------------------------------------------------------
            //AGE

            Console.WriteLine("\nPlease enter your age in years:");
            int userAge = 0; //defined here in order to use in the if statement
            int age = int.Parse(Console.ReadLine());
         
            if (age<1 || age > 120)
            {
                Console.WriteLine("\nThat is not a valid age. Please re-enter your age: ");
                userAge = int.Parse(Console.ReadLine());
            }
            else
            {
                userAge = age;
            }

         
            //part 2A - If the user’s age is an odd number, then they will retire in __3__ years, 
            //      or __23_ years if their age is an even number.

            int retireYears = 40; //default definition for variable used in the if statement
            if (userAge % 2 == 0) //userAge is even
            {
                retireYears = 23;
            }
            else //userAge is odd
            {
                retireYears = 3;
            }


            //---------------------------------------------------------------------------
            //BIRTH MONTH
            Console.WriteLine("\nPlease enter your birth month as an integer (1-12): ");
            int birthMonth = int.Parse(Console.ReadLine());
            int retireMoolah = 0;

            //part 2D - f the user’s birth month is 1-4, they will have $__1,000,000__ in the bank; 
            //      if the user's birth month is 5-8, they will have $_500,000,000_ in the bank; 
            //      and if it is 9-12, then they will have $__25,000__ in the bank. 
            //      If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.

            if (birthMonth >= 1 && birthMonth <=4)
            {
                retireMoolah = 1000000;
            }
            else if (birthMonth >=5 && birthMonth <=8)
            {
                retireMoolah = 500000000;
            }
            else if (birthMonth >= 9 && birthMonth <=12)
            {
                retireMoolah = 25000;
            }

            else
            {
                retireMoolah = 0;
                Console.WriteLine("\nMadame Margaret sees your silliness. The fates will punish you, mark my words!\n");
            }


            //----------------------------------------------------------------------------
            //FAVORITE COLOR

            Console.WriteLine("\nWhat is your favorite color? Your options are ROYGBIV: ");
            string favColor = "ecru";//initializing string
            Console.WriteLine("If you do not remember what ROYGBIV is, please type 'help'");
            string answerColor = Console.ReadLine();
            
            if (answerColor.ToLower() == "help")
            {
                Console.WriteLine("\nROYGBIV are the colors of the rainbow: \nred, orange, yellow, green, blue, indigo, violet");
                Console.WriteLine("What is your favorite color (spelling counts!): ");
                favColor = Console.ReadLine();
              
            }
            else
            {
                favColor = answerColor;
            }

            //part 2C - Depending on which ROYGBIV color is the user’s favorite, 
            //they will have a specific mode of transportation (i.e. car, boat, plane, etc.)

            string modeTransport = "walking"; //initialize value outside of switch case

            switch(favColor.ToLower())
            {
                case "red":
                    modeTransport = "ferrari";
                    break;

                case "orange":
                    modeTransport = "scooter";
                    break;

                case "yellow":
                    modeTransport = "hot air balloon";
                    break;

                case "green":
                    modeTransport = "horse";
                    break;

                case "blue":
                    modeTransport = "sailboat";
                    break;

                case "indigo":
                    modeTransport = "spaceship";
                    break;

                case "violet":
                    modeTransport = "chauffeured limosine";
                    break;

                default:
                    Console.WriteLine("\nWhether you are a poor speller, or you didn't follow the directions, \nthe fates are not amused.");
                    modeTransport = "motorized wheelchair with a broken down battery";
                    break;

            }
                      
            //----------------------------------------------------------------------------
            //# SIBLINGS

            Console.WriteLine("\nHow many siblings do you have?");
            int numSibs = int.Parse(Console.ReadLine());
            string vacationHome = "cleveland";

            //part 2B - If the user’s number of siblings is 0, then they will have a vacation home in __Costa Rica__ (location), 
            //      or 1 then they will have a vacation home in __the Islands__ (location), 
            //      or 2 then they will have a vacation home in __the Mountains__ (location), 
            //      or 3 then they will have a vacation home in _Arizona__ (location), 
            //      or more than 3 then they will have a vacation home in __the Bronx Zoo___ (location). 
            //      If the user enters a number that is less than 0, they should get a bad vacation home! (punxatawney, pa)

            if (numSibs < 0)
            {
                Console.WriteLine("\nHa, ha, where did you bury the bodies?");
                vacationHome = "antarctica";
            }
            else
            {
                switch (numSibs)
                {
                    case 0:
                        vacationHome = "Costa Rica";
                        break;

                    case 1:
                        vacationHome = "Put-in-Bay";
                        break;
                    case 2:
                        vacationHome = "London";
                        break;
                    case 3:
                        vacationHome = "Arizona";
                        break;
                    default:
                        vacationHome = "the Zoo";
                        break;

                }
            }

            //-------------------------------------------------------------------------------------------
            //part 3 - Prints out the user's fortune in the following format:
            //      [First Name] [Last Name] will retire in [# of Years] 
            //      with [Amount of Money] in the bank, 
            //      a vacation home in [Location] and a [Mode of Transportation].

            Console.WriteLine("\nMadame Margaret has looked into the swirling chaos of the crystal ball...\a\a\a\n");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + retireYears + " years.");
            Console.WriteLine("You will have $" + retireMoolah + " in the bank, ");
            Console.WriteLine("a vacation home in " + vacationHome + ",");
            Console.WriteLine("and a " + modeTransport + ".");
            Console.WriteLine("\nThe fates have spoken! Have a nice day :)\n");
            //-------------------------------------------------------------------------------------------

            //Part 4 (stretch) - Give the user the ability to quit the program at any point 
            //where the program is looking for user input, by typing “Quit” (should not be case sensitive). 
            //The program should print “Nobody likes a quitter...” before ending.





            //-----------------------------------------------------------------------------------------
            //Note to self - Do not delete these last three curly brackets or you will meet your doom!
        }
    }
}
