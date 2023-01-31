using System;

class Program
{
    Account account = new Account();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        int cont = 1;
        while(cont == 1){
            Console.WriteLine("1. Desposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. View Account Balance");
            Console.WriteLine("4. Quit");
            string userInput = Console.ReadLine() ?? "";
            int input = int.Parse(userInput);

            if(input == 1){
                Console.WriteLine("4. Quit");
                string userInput = Console.ReadLine() ?? "";
                int Desposit = int.Parse(userInput);
                account.Deposit(Desposit);
            }
            else if(input == 2){
                Console.WriteLine("4. Quit");
                string userInput = Console.ReadLine() ?? "";
                int Withdraw = int.Parse(userInput);
                account.Withdraw(Withdraw);
            }
            else if(input == 3){
                Console.Write($"{account.GetBalance()}");
            }

        }
    }


      
}