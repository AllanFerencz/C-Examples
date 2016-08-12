// Student Name: Allan Ferencz
// Program Name: Assignmennt2Fundamentals
//         Date: 2015-01-23
//  Description: This program is designed to have the user enter in 4 different tests. The user than enters the 2-6 results of a single test.
//               The program will output the average of each test and the average of all the test combined.
//               Requirements for this program. First, is input validation to check for non numbers. Second, to valid input being between -1 and 1.
//               Third, checking for N to be input to say the test was finished but making sure atleast 2 results for the test have been entered.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constant on all of these because they will not change
            const byte MAX_INPUTS = 6;               //byte used for MIN_INPUT since its a low number.
            const byte MIN_INPUTS = 2;               //byte used for MAX_INPUT since its a low number.
            const sbyte MIN_NUMBER = -1;            //sbyte used for MIN_NUMBER since its holds negatives that are small numbers.
            const byte MAX_NUMBER = 1;              //byte used for MAX_NUMBER since its a low number.

            const byte MAX_TESTS = 3;               //byte use for holding the max number of tests.

            const string EXIT_INPUT = "N";          //string used to hold the value required to Exit the program.
            const bool IS_EXIT = true;              //Bool Switch comparison! used to compair with my switch to check if I have to exit the test loop.

            byte testNumber;                        //Byte used for loop counter, holds what position I currently am in the loop.
            byte loopCount = 0;                     //Byte used for counting the current result I'm on. Holds the current position of the test results.
            double acumulatorTestResults = 0;       //Double used to holding the Results of a single test. Also used to calulations after its been averaged.
            double acumulatorAllTestResults = 0;    //Double used to hold the results of all the test combinded. Also used to calulations after its been averaged.

            string userInput;                       //String holds the users input to be validated and parsed into a double.
            double userConvertedInput;              //Double that is the parsed user input.

            bool isNumeric;                         //Bool that holds true if the parsed user input was actually a number. False other wise.
            bool isValidExit = false;               //Bool for exiting the input loop. Holds true if the user hit 6 results or the entered N.

            Console.WriteLine("You have 4 tests with 2-6 test results each.");      //Outputs to console to explain how the program works.
            Console.WriteLine("Enter calculation 1 for test 1 (Type N to exit).");  //Outputs to console to ask for an input.
            userInput = Console.ReadLine();                                         //waits for user to enter in input.
            Console.WriteLine("\n");                                                //formating the text in console.

            //Picked a For loop since it HAS to run 4 times
            for (testNumber = 0; testNumber <= MAX_TESTS; testNumber++)                 //TESTS LOOP: will loop through till it hits the MAX_TESTS. 
            {
                //Picked a while loop since it can run 2-6 times
                while (isValidExit != IS_EXIT)                                          //SINGLE TEST LOOP: will loop through till an exit condition is met.
                {
                    if (userInput == EXIT_INPUT && loopCount >= MIN_INPUTS)             //Checks to see if userInput is equal to the exit input and also met the minimum inputs.
                    {
                        isValidExit = true;                                             //Sets the exit condition to true to break loop.
                    }
                    else if (userInput == EXIT_INPUT)                                   //If the user only entered in N and not the minimum required inputs than this is exicuted.
                    {
                        Console.WriteLine("InValid Exit: Must enter atleast 2 numbers.");                               //Outputs to console to explain there error.
                        Console.WriteLine("Enter another calculation for test " + testNumber + " (Type N to exit).");   //Outputs to console to ask for an input.
                        userInput = Console.ReadLine();                                                                 //waits for user to enter in input.
                        Console.WriteLine("\n");                                                                        //formating the text in console.
                    }
                    else                                                                                           //If Exit validation is good will continue here.
                    {
                        isNumeric = double.TryParse(userInput, out userConvertedInput);                                 //Validation check for number.

                        if (isNumeric != true)                                                                          //Checks if its not a number.
                        {
                            Console.WriteLine("InValid Input: Must enter numeric value.");                                  //Outputs to console to explain there error.
                        }
                        else if (userConvertedInput < MIN_NUMBER || userConvertedInput > MAX_NUMBER)                    //Checks if the number is between the min and max.
                        {
                            Console.WriteLine("InValid Input: Must enter a number between -1 and 1.");                      //Outputs to console to explain there error.
                        }
                        else                                                                                            //Passed all validation.
                        {
                            acumulatorTestResults += userConvertedInput;                                                    //Adds user input to acumulator.
                            ++loopCount;                                                                                    //Adds to count to keep track of the number of input results.
                        }

                        if (loopCount == MAX_INPUTS)                                                                    //checks if MAX inputs has been entered.
                        {
                            isValidExit = true;                                                                                 //sets test to exit loop.
                        }
                        else                                                                                            //Asks for another number to be entered.
                        {
                            Console.WriteLine("Enter calculation " + (loopCount + 1) + " for test " + (testNumber + 1)+ " (Type N to exit)."); // User prompt.
                            userInput = Console.ReadLine();                                                                                    //waits for user to enter in input.
                            Console.WriteLine("\n");                                                                                           //formating the text in console.
                        }
                    }
                }
                acumulatorAllTestResults += acumulatorTestResults;                                                   //Adds the results of the single test to the entire tests.            
                acumulatorTestResults = acumulatorTestResults / loopCount;                                           //Finds the average of the single test.
                Console.WriteLine("The average of the " + loopCount + " numbers is " + acumulatorTestResults + "."); //User prompt'd the average of the tests.
                Console.WriteLine("Press a Key to continue to next test\n");                                         //User prompt to ask for input.
                Console.ReadKey(false);                                                                              //waits for user to enter in input. False so it doesn't go to the buffer   .
                acumulatorTestResults = 0;                                                                           //Reset for next test.
                loopCount = 0;                                                                                       //Reset for next test.
                isValidExit = false;                                                                                 //Reset for next test.
                Console.Clear();                                                                                     //Reset for next test.
                if (testNumber != MAX_TESTS)                                                                                 //if another atleast 1 more test is left will ask user for another input.
                {
                    Console.WriteLine("Enter calculation " + (loopCount + 1) + " for test " + (testNumber + 2) + " (Type N to exit)."); //User prompt.
                    userInput = Console.ReadLine();                                                                                     //waits for user to enter in input.
                    Console.WriteLine("\n");                                                                                            //Formating.
                }
            }
            acumulatorAllTestResults = acumulatorAllTestResults / testNumber ;                                                          //Calculate Total average.
            Console.WriteLine("The average of your 4 tests is " + acumulatorAllTestResults + ".");                                      //User prompt.
            Console.ReadKey();                                                                                                          //waits for user to enter input so they can see the average.    
        }
    }
}
