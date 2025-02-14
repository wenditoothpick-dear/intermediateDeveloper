namespace banking;
public class IbankManager : bankManager
{
    private readonly List<Bank> Banks;
    public IbankManager()
    {
        Banks = [];
    }
    public void CheckPassword(string EnterText)
{
    try
    {
        Console.Write(EnterText);
        var EnteredVal = "";
        ConsoleKeyInfo Key;
        
        while (true)
        {
            Key = Console.ReadKey(true);

            if (Key.Key != ConsoleKey.Backspace && Key.Key != ConsoleKey.Enter)
            {
                EnteredVal += Key.KeyChar;
                Console.Write("*");
            }
            else if (Key.Key == ConsoleKey.Backspace && EnteredVal.Length > 0)
            {
                EnteredVal = EnteredVal.Substring(0, EnteredVal.Length - 1);
                Console.Write("\b \b");
            }
            else if (Key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                
                if (string.IsNullOrWhiteSpace(EnteredVal))
                {
                    Console.WriteLine("Empty value not allowed ");
                }
                else
                {
                    break;
                }

                EnteredVal = "";
                Console.Write(EnterText);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}

    public Bank AddAccountActivities()
    {
      Bank bank = new();
      Console.WriteLine("Enter your first name");
      bank.FirstName = Console.ReadLine()!;
      Console.WriteLine("Enter your last name");
      bank.LastName = Console.ReadLine()!;
      Console.WriteLine("Enter your middle name");
      bank.MiddleName = Console.ReadLine()!;
      Console.WriteLine("Enter your password which should not be less four digit");
      CheckPassword(bank.Password);
      bank.Password = Console.ReadLine()!;
      
      if(bank.Password.Length != 4)
      {
        Console.WriteLine("the password you have entered is not accurate pls try again later");
         return bank;
      }
      Console.WriteLine("Enter your occupation");
      bank.Occupation = Console.ReadLine()!;
      Console.WriteLine("Enter your gender");
      bank.Gender = Console.ReadLine()!;
      Console.WriteLine("Enter the year you are creating this account");
      bank.Year = Console.ReadLine()!;
      if(bank.Year != "2025")
      {
        Console.WriteLine("You have entered the wrong year");
      }
      return bank;
     }
     
    
    public void CreateAccount()
    {
      int id = Banks.Count > 0 ? Banks.Count + 1 : 1;
      var bankActivities = AddAccountActivities();
      
      var bank = new Bank
      {
        Id = id,
        FirstName = bankActivities.FirstName,
        LastName = bankActivities.LastName,
        MiddleName = bankActivities.LastName,
        Password = bankActivities.Password,
        Gender = bankActivities.Gender,
        Year = bankActivities.Year,
        Occupation = bankActivities.Occupation,
        CreatedAt = DateTime.Today,
      };
      Banks.Add(bank);
      Random random = new ();
      int  AccountNumber = random.Next(1010, 5000);
      Random RanDom = new ();
      int SecondAccount = RanDom.Next(34568, 89765);
      Random RANDOM = new ();
      int ThirdAccount = RANDOM.Next(0, 9);
     Console.WriteLine($"bank account with the first name {bank.FirstName} and identity number of {bank.Id}, so therefore your account number is {ThirdAccount}{AccountNumber}{SecondAccount}");
     Console.WriteLine($"So,{bank.MiddleName} are ready to continue with the rest of the program\nif yes press 1, if no press 2 ");
     string  Reply = Console.ReadLine()!;
     if(Reply == "1")
     {
        Console.Write("thanks for choosing yes, press a to transfer money\npress b to buy data\npress c to buy prepaid");
        string review = Console.ReadLine()!;
        switch(review)
        {
            case "a":
             Console.WriteLine("Enter the person  account number you want to transfer the money to");
             string accountNumber = Console.ReadLine()!;
             if(accountNumber.Length < 10)
             {
                Console.WriteLine("pls try again because you have inputed wrong account number");
                return;
             }
             Console.WriteLine("Enter the amount you want to transfer ");
             decimal amount = Convert.ToDecimal(Console.ReadLine()!);
             Console.WriteLine("Enter your pin to continue with this operation");
             string pass = Console.ReadLine()!;
             if(pass != bank.Password)
             {
                Console.WriteLine("You have entered the wrong password");
                return;
             }
             decimal balance;
             decimal y = 0;
             balance = y - amount;
             Console.WriteLine($"You have successfully transfered this {amount} to this account {accountNumber} and your balance is {balance}");
            break;
            case "b":
            Console.WriteLine("Enter the recipeint number");
            string number = Console.ReadLine()!;
            if(number.Length != 11)
            {
                Console.WriteLine("you have entered the wrong number");
                return;
            }
             Console.WriteLine("Enter the amount of data you want to buy in either MB or GB");
             decimal Amount = Convert.ToDecimal(Console.ReadLine()!);
             
             Console.WriteLine("Enter the NetWork either MTN GLO Airtel");
             string Network =  Console.ReadLine()!;
             Console.WriteLine("Enter your password to continue with the operation");
             string PASS = Console.ReadLine()!;
             if(PASS != bank.Password)
             {
                  Console.WriteLine("you have entered incorrect password");
                  return;
             }

             Console.WriteLine($"you have successfully bought data of{Amount}in GB or MB to this phone number {number}");
            break;
            case "c":
             Console.WriteLine("Enter the prepaid number of the customer");
             string NUM = Console.ReadLine()!;
             Console.WriteLine("Enter the amount of electricity you want to pay for");
             decimal price = Convert.ToDecimal(Console.ReadLine()!);
             Console.WriteLine("Enter your password to continue with the operation");
             string pin = Console.ReadLine()!;
             if(pin != bank.Password)
             {
                  Console.WriteLine("you have entered incorrect password");
                  return;
             }
             
             Random prepaid = new ();
             int  Tprepaid = prepaid.Next(1010114, 5000129);
             Random PREPAID = new ();
             int SeconPrepaid = PREPAID.Next(345685, 897650);
             Random PREPaid = new ();
             int Thirdprepaid = PREPaid.Next(6123222, 9132456);
             Console.WriteLine($"your prepaid token is {Tprepaid}-{SeconPrepaid}-{Thirdprepaid}, and u have successfully bought prepaid to this number{NUM}");
            break;
            default :
            Console.WriteLine("pls try again later");
            break;
        }

     }
     else if(Reply == "2")
     {
       Console.WriteLine("okay good bye enjoy the rest of your day");
       return;
     }
     else 
     {
        Console.WriteLine("You have inputed the wrong option");
        return;
     }
    }
    public void RemoveAccount()
    {
     Console.WriteLine("Enter the ID of the Account  you want to remove:");
     int id = int.Parse(Console.ReadLine()!);
     var bank = Banks.Find(y => y.Id == id);
     if (bank is null)
     {
      Console.WriteLine("The Account you are trying to remove is absent");
      return;
     }
      bool isRemoved = Banks.Remove(bank);
      string result = isRemoved
      ?"task  removed successfully"
      : "Unable to remove task!";
      Console.WriteLine(result);
     
    }
    public void ListAllAccount()
    {
      if(Banks.Count == 0)
      {
        Console.WriteLine("There are no record yet pls add new record");
        return;
      }
     
      foreach (var bank in Banks)
      {
           var bankData = ($"Id:{bank.Id}\tfirst name:{bank.FirstName}\tlast name: {bank.LastName}\tMiddle name :{bank.MiddleName}\tgender{bank.Gender}Created:{bank.CreatedAt}");
            Console.WriteLine(bankData); 
            Console.WriteLine();
        } 
      }
    
    public void SearchAccount()
    {
      Console.WriteLine("Enter the id of the Account you are looking for");
      int id = int.Parse(Console.ReadLine()!);
      var bank = Banks.Find(y => y.Id == id);
      if(bank is null)
      {
        Console.WriteLine("bank account deos not exist");
        return;
      }
      var result = $"""
      =========== TASK DETAILS=========
      First name: {bank.FirstName}
      Last name:  {bank.LastName}
      Middlename: {bank.MiddleName}
      Gender:     {bank.Gender}
      Occupation: {bank.Occupation}
      """;
      Console.WriteLine(result);
    }
    public void LoginIntoanExistingAccount()
    {
        Console.Write("Enter the id of the account u want to login into");
     int id = int.Parse(Console.ReadLine()!);
     var bank = Banks.Find(y => y.Id == id);
     if(bank is null)
     {
       Console.WriteLine("the account  you are trying to login into does not exist");
       return;
     }
     var result = $"""
      =========== TASK DETAILS=========
      First name: {bank.FirstName}
      Last name:  {bank.LastName}
      Middlename: {bank.MiddleName}
      Gender:     {bank.Gender}
      Occupation: {bank.Occupation}
      """;
      Console.WriteLine(result);
      Console.WriteLine($"Welcome back {bank.FirstName}, press a to transfer money\npress b to buy data\npress c to buy prepaid");
      string replyMessages = Console.ReadLine()!;
      switch(replyMessages)
      {
        case "a":
             Console.WriteLine("Enter the person  account number you want to transfer the money to");
             string accountNumber = Console.ReadLine()!;
             if(accountNumber.Length < 10)
             {
                Console.WriteLine("pls try again because you have inputed wrong account number");
                return;
             }
             Console.WriteLine("Enter the amount you want to transfer ");
             decimal amount = Convert.ToDecimal(Console.ReadLine()!);
             Console.WriteLine("Enter your pin to continue with this operation");
             string pass = Console.ReadLine()!;
             if(pass != bank.Password)
             {
                Console.WriteLine("You have entered the wrong password"); 
                return;
             }
             decimal balance;
             decimal y = 0;
             balance = y - amount;
             Console.WriteLine($"You have successfully transfered this {amount} to this account {accountNumber} and your balance is {balance}");
            break;
            case "b":
            Console.WriteLine("Enter the recipeint number");
            string number = Console.ReadLine()!;
            if(number.Length != 11)
            {
                Console.WriteLine("you have entered the wrong number");
                return;
            }
             Console.WriteLine("Enter the amount of data you want to buy in either MB or GB");
             decimal Amount = Convert.ToDecimal(Console.ReadLine()!);
             
             Console.WriteLine("Enter the NetWork either MTN GLO Airtel");
             string Network =  Console.ReadLine()!;
             Console.WriteLine("Enter your password to continue with the operation");
             string PASS = Console.ReadLine()!;
             if(PASS != bank.Password)
             {
                  Console.WriteLine("you have entered incorrect password");
                  return;
             }

             Console.WriteLine($"you have successfully bought data of{Amount}in GB or MB to this phone number {number}");
            break;
            case "c":
             Console.WriteLine("Enter the prepaid number of the customer");
             string NUM = Console.ReadLine()!;
             Console.WriteLine("Enter the amount of electricity you want to pay for");
             decimal price = Convert.ToDecimal(Console.ReadLine()!);
             Console.WriteLine("Enter your password to continue with the operation");
             string pin = Console.ReadLine()!;
             if(pin != bank.Password)
             {
                  Console.WriteLine("you have entered incorrect password");
                  return;
             }
             
             Random prepaid = new ();
             int  Tprepaid = prepaid.Next(1010114, 5000129);
             Random PREPAID = new ();
             int SeconPrepaid = PREPAID.Next(345685, 897650);
             Random PREPaid = new ();
             int Thirdprepaid = PREPaid.Next(6123222, 9132456);
             Console.WriteLine($"your prepaid token is {Tprepaid}-{SeconPrepaid}-{Thirdprepaid}, and u have successfully bought prepaid to this number{NUM}");
            break;
            default :
            Console.Write("pls try again later");
            break;
      }
    }
}
