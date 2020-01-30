//Author : Nawras Albarwany
//Date: 1/30/2020
// Iteration Statements Delievrable 2 

using System;

namespace Deliverable2_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for input 
            Console.WriteLine("Enter an Integer value between 1 and 100.");
            /* use try catch block to calidate user input. 
            If user provides bad input, the catch block will 
            handle the error and a message will be displayed. 
            */
            try
            {
                // this variable will gather data from the user input
                string input = Console.ReadLine();
                // This variable will be use to perfom the iterative statements and is parsed as an integer. 
                int value_of_input = int.Parse(input);

                // If/Else statment is used to test the velues of the user input. If between 1 and 100 an interative statment will execute.
                // if number not between 1 and 100 an error message will displays asking user to enter different input.

                    if((value_of_input>0) && (value_of_input <=100))
                    {

                    //for Loop
                    for (int i = 1; i<=value_of_input; i++ )
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". This is the current integer value in the loop:" + i.ToString());
                        
                    }
          
                    }

               // else the user does not enter a value between 1 and 100 a message will display
                    else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again...");
                    Console.WriteLine("Press any key to exit program and try again...");
                    Console.ReadKey(true);

                }
            }// end of try
            catch
            {
                // displays error message
                Console.WriteLine("Please enter integer value between 1 and 100");
                Console.ReadKey(true);
            }// end of catch
           
        }

    }
}
