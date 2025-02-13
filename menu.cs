namespace banking;
public class WendiBankApp
{ 
    private readonly IbankManager _bankManager;

    public WendiBankApp()
    {
        _bankManager = new IbankManager();
        
    }

   public void BankMenu()
    {
        
        bool exit = false;
   
        while (!exit)
        {
            PrintbankMenu();
            Console.WriteLine("you are welcome to Wendi toothpick bank app i hope u enjoy using this app");
           
            Console.WriteLine("Enter option: ");
            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("you have entered the wrong value option");
                continue;
            }
            switch (option)
            {
             case 1:
             exit = true;
             Console.WriteLine("Exiting the Bank application");
             break;
             case 2:
             _bankManager.CreateAccount();
             break;
             case 3:
             _bankManager.LoginIntoanExistingAccount();
             break;
             case 4:
             _bankManager.SearchAccount();
             break;
             case 5:
             _bankManager.RemoveAccount();
             break;
             case 6:
             _bankManager.ListAllAccount();
             break;
             default:
             Console.WriteLine("Invalid operations");
             break;
            }
        }
    } 
      public void PrintbankMenu()
      {
        Console.WriteLine("Enter 2 to create new account");
        Console.WriteLine("Enter 3 to login into existing account");
        Console.WriteLine("Enter 4 to search account");
        Console.WriteLine("Enter 5 to  remove account");
        Console.WriteLine("Enter 6 to List all account");
        Console.WriteLine("Enter 1 to exit program");
      }
}