using System;

class Menu
{

    static void Main(string[] args)
    {
        Console.Write("Welcome to the Journal Program");
        int response = 0; // Save responses

        while(response != 5){
 

            if(response == 1){ //Call Write Class Methods

            }
            else if(response == 2){ //Call Display Class Method

            }
            else if(response == 3){ //Call Load Class Method

            }
            else if(response == 4){ //Call Save Class Method

            }
            else if(response == 5){ //Quits loop with thank you message
                Console.Write("Thank you for playing!");
            }
        }
    }

    static void display_menu(){
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }    

}