//Willow Marques
//wmarquez4@cnm.edu
//DELEGATES DEMO

using System;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace DelegatesDemo
{
    class Program
    {
        //3.1.	Inside of program.cs add the following delegate definition inside of the program class:
        //Delegate signature is return string, no arguments
        delegate void DispStrDelegate(string param);

        static void Main(string[] args)
        {
            //3.3.	Inside of the Main method add the following:
            // Get a line of text to convert
            Console.Write("Please enter some text: ");
            string text = Console.ReadLine();

            // Instantiate three delegate objects            
            DispStrDelegate saying1 = new DispStrDelegate(Capitalize);
            DispStrDelegate saying2 = new DispStrDelegate(LowerCased);
            DispStrDelegate saying3 = new DispStrDelegate(Console.WriteLine);

            // Call them one after the other
            saying1(text);
            saying2(text);
            saying3(text);

            Console.WriteLine(); // Blank line for cleaner output formatting

            //4.1.	Add the following code to Main():
            //Get another text line
            Console.Write("Please enter some text: ");
            text = Console.ReadLine();

            //Make a new delegate object and concatenate delegates
            DispStrDelegate sayings = new DispStrDelegate(Capitalize);
            sayings += new DispStrDelegate(LowerCased);
            sayings += new DispStrDelegate(Console.WriteLine);

            //Call the one delegate and run all three methods
            Console.WriteLine("Running multi cast directly: ");
            sayings(text);

            Console.WriteLine(); // Blank line for cleaner output formatting

            //5.2.	Add the following to Main():
            //Pass delegate as a method argument
            Console.WriteLine("Running by passing delegate to another method: ");
            RunMyDelegate(sayings, text);

            Console.WriteLine(); // Blank line for cleaner output formatting

            //6.1.	Add the following to Main():
            //Create and run a lambda expression
            Console.WriteLine("Running by passing in a lambda expression: ");
            RunMyDelegate((string t) => { Console.WriteLine("Lambda: " + t); }, text);

            Console.WriteLine(); // Blank line for cleaner output formatting

            //6.3.	Try the following variations on delegate syntax:
            //Remove the type and let it be infered
            Console.WriteLine("Lambda without type: ");
            RunMyDelegate((t) => { Console.WriteLine("Lambda: " + t); }, text);

            //Remove the parenthesis
            Console.WriteLine("Lambda without parenthesis: ");
            RunMyDelegate(t => { Console.WriteLine("Lambda2: " + t); }, text);

            Console.WriteLine(); // Blank line for cleaner output formatting

            //6.5.	Try the following:
            //Add a lambda expression to our delegate
            sayings += t => { Console.WriteLine("Lambda3: " + t); };
            Console.WriteLine("Three Delegates and a lambda: ");
            RunMyDelegate(sayings, text);

            Console.WriteLine(); // Blank line for cleaner output formatting

            //3.2.	Add the following method definitions:
            // Method that capatilizes a string.
            static void Capitalize(string text)
            {
                Console.WriteLine("Your input capatilized --> " + text.ToUpper());
            }

            // Method that lower cases a string.
            static void LowerCased(string text)
            {
                Console.WriteLine("Your input lower cased --> " + text.ToLower());
            }


            //5.1.	 Add the following method to the program class:
            // Method that takes a delegate as an argument
            static void RunMyDelegate(DispStrDelegate del, string textParam)
            {
                del(textParam);
            }
        }

    }

}
