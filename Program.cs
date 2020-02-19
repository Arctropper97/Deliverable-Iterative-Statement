using System;

namespace Deliverable_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to enter in a certain value. 
            Console.WriteLine("Please enter in an integer value between 2 and 10");
            int userInput;
            //Converting the users input from a string to a intger data type.
            int.TryParse(Console.ReadLine(), out userInput);
            int i;
           
                // userInput = 6
                //  0  -->  5
                for (i = 0; i < userInput + 1; i++)
                {
                    if (userInput % 2 == 0)
                    {
                        Console.WriteLine("You entered in an even number.");
                    }
                    else
                    {
                        Console.WriteLine("You entered in an odd number.");
                    }

                }
                  
                
            }
        }
    }

