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
            //Note: Program should be able to handle whether or not a user inputs capital or lowercase letters.
            //can do this by taking user input and converting everything to lower or upper, or in the if/else statements

            Console.WriteLine("Welcome to Madame Margaret's Fortune Telling Machine!");

            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            string firstNameLower = firstName.ToLower(); //converts to all lower case for easy comparison

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            string lastNameLower = lastName.ToLower(); //converts to all lower case for easy comparison

            Console.WriteLine("Please enter your age in years:");
            int age = int.Parse(Console.ReadLine());
            if (age<1 || age > 120)
            {
                Console.WriteLine("That is not a valid age. Please re-enter your age: ");
                int usersAge = int.Parse(Console.ReadLine());
            }
            else
            {
                int usersAge = age;
            }

            Console.WriteLine("Your age is " + usersAge); //apparently variables do not exist outside of the if statement!


            //part 2A - If the user’s age is an odd number, then they will retire in __3__ years, 
            //      or __33_ years if their age is an even number.

            if (userAge % 2 == 0) //userAge is even
            {
                int retireAge = userAge + 33;
            }
            else
            {
                int retireAge = userAge + 3;
            }
            Console.WriteLine("Please enter your birth month as an integer (1-12): ");
            int birthMonth = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter the letter of your favorite rainbow color using ROYGBIV: ");
            Console.WriteLine("If you do not remember what ROYGBIV is, please type 'help'");
            string answerColor = Console.ReadLine();
            if (answerColor.ToLower() == "help")
            {
                Console.WriteLine("ROYGBIV Help: R=red, O=orange, Y=yellow, G=green, B=blue, I=indigo, V=violet");
                Console.WriteLine("Enter the letter of your favorite rainbow color using ROYGBIV: ");
                string favColor = Console.ReadLine();
                // may want to shrink any string they input into a single character?
            }
            else
            {
                string favColor = answerColor;
            }

            Console.WriteLine("How many siblings do you have?");
            int numSibs = int.Parse(Console.ReadLine());

            

            //part 2 - checks the input against cases (if/else) to determine "fortune"

            

            //part 2B - If the user’s number of siblings is 0, then they will have a vacation home in __Costa Rica__ (location), 
            //      or 1 then they will have a vacation home in __the Islands__ (location), 
            //      or 2 then they will have a vacation home in __the Mountains__ (location), 
            //      or 3 then they will have a vacation home in _the desert_ (location), 
            //      or more than 3 then they will have a vacation home in __the Bronx Zoo___ (location). 
            //      If the user enters a number that is less than 0, they should get a bad vacation home! (punxatawney, pa)

            //part 2C - Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation (i.e. car, boat, plane, etc.)

            //part 2D - f the user’s birth month is 1-4, they will have $__1,000,000__ in the bank; 
            //      if the user's birth month is 5-8, they will have $_500,000,000_ in the bank; 
            //      and if it is 9-12, then they will have $__250,000__ in the bank. 
            //      If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.

            //part 3 - Prints out the user's fortune in the following format:
            //      [First Name] [Last Name] will retire in [# of Years - this is a calclated value] 
            //      with [Amount of Money] in the bank, 
            //      a vacation home in [Location] and a [Mode of Transportation].

            //Part 4 (stretch) - Give the user the ability to quit the program at any point 
            //where the program is looking for user input, by typing “Quit” (should not be case sensitive). 
            //The program should print “Nobody likes a quitter...” before ending.






            //Note to self - Do not delete these last three curly brackets or you will meet your doom!
        }
    }
}
