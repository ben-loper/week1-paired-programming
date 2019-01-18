using System;

namespace command_line_input_exercises_pairs
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

        C:\Users> MakeChange

        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            decimal changeRequired;
       
            //Print out a message for the total bill
            Console.Write("Please enter the total bill: ");

            //Take input from the user, parse the string to a decimal and assign to a total bill variable 

            decimal totalBill = Decimal.Parse(Console.ReadLine());        

            //Print out a message for the amount tendered

            Console.Write("Please enter the amount tendered: ");

            //Take input from the user, parse the string to a decimal and assign to an amount tendered variable 

            decimal amountTendered = Decimal.Parse(Console.ReadLine());

            //Subtract total bill by the amount tendered
            changeRequired = amountTendered - totalBill;

            //Display the result as change required
            Console.WriteLine($"The change required is {changeRequired}");               
                
            Console.ReadKey();
            
        }
    }
}
