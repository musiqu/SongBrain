using System;

class InputChecker
{
    public static int IntegerCheck(string prompt, int minValue, int maxValue)
    {
        bool validInput = false;
        bool validInteger = false;
        int input = 0; //chordQuantity
        int min = minValue;
        int max = maxValue;      

        while (validInput != true)
        {
            //get the input from the user
            Console.Write(prompt);

            // checks to see if input is an integer
            validInteger = int.TryParse(Console.ReadLine(), out input);

            if (validInteger)
            {
                if (input >= min && input <= max)
                {
                    validInput = true;  //input has been validated and the while loop terminates
                }
                else
                {
                    Console.WriteLine($"\n\n  ***You must choose a number between {min} and {max}." +
                                      "  Please try again!***");
                }
            }
            else
            {
                Console.WriteLine($"\n\n  ***Input must be a number.  Please try again!***");
            }
        }
        return input;
    }
}