using System;

namespace MartianWeight
{
    /*
    In case you've ever pondered how much you weight on Mars, here's the calculation:
    Wm = We* 0.378
    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

    Write a command line program which accepts a series of Earth weights from the user  
    and displays each Earth weight as itself, and its Martian equivalent.


    C:\Users> MartianWeight  
    Enter a series of Earth weights (space-separated): 98 235 185

    98 lbs.on Earth, is 37 lbs.on Mars.
    235 lbs.on Earth, is 88 lbs.on Mars.
    185 lbs.on Earth, is 69 lbs.on Mars. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            double marsConversionValue = 0.378;

            // Print the message "Enter a series of Earth weights (space-separated): 98 235 185" to the console
            Console.WriteLine("Please enter a series of weights.");

            // Assign the values entered into the numberString variable and remove the whitespaces
            string numberString = Console.ReadLine();           
            string[] numbers = numberString.Split(' ');

            double[] earthWeights = new double[numbers.Length];

            // Take each element of the string array and parse it and assign that value to the earthWeights array
            for (int i = 0; i < numbers.Length; i++)
            {                
                earthWeights[i] = int.Parse(numbers[i]);
                
            }

            Console.WriteLine();

            int[] marsWeights = new int[earthWeights.Length];

            // Take the value of each element in the earthWeights array
            for (int i = 0; i < earthWeights.Length; i++)
            {
                //Multiply the element by the conversion rate, explicitly convert to an integer, and assign it to the marsWeight array
                marsWeights[i] = (int)(earthWeights[i] * marsConversionValue);

                //Print out the values and message that given element
                Console.WriteLine($"{earthWeights[i]} lbs. on Earth, is {marsWeights[i]} on Mars.");                      
            }

            //Holds the program open
            Console.ReadKey();
        }
    }
}
 