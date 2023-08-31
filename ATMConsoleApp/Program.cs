public class CardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public string GetCardNum()
    {
        return cardNum;
    }

    public int GetPin()
    {
        return pin;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void SetCardNum(string newCardNum)
    {
        cardNum = newCardNum;
    }

    public void SetPin(int newPin)
    {
        pin = newPin;
    }

    public void SetFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void SetLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void SetBalance(double newBalance)
    {
        balance = newBalance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        void PrintOptions()
        {
            Console.WriteLine("Please choose one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit: ");
            double deposit = double.Parse(Console.ReadLine()!);
            currentUser.SetBalance(currentUser.GetBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.GetBalance());
        }

        void Withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw? ");
            double withdrawal = double.Parse(Console.ReadLine()!);

            if (currentUser.GetBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.SetBalance(currentUser.GetBalance() - withdrawal);
                Console.WriteLine("You are good to go! Thank you :)");
            }
        }

        void Balance(CardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.GetBalance());
        }

        List<CardHolder> cardHolders = new List<CardHolder>
        {
            new CardHolder("22348122456777", 4325, "Naleen", "Fernando", 300.34),
            new CardHolder("33451123567890", 1234, "Alice", "Johnson", 750.20),
            new CardHolder("44892224678901", 9876, "Bob", "Smith", 123.45),
            new CardHolder("77885528901234", 1357, "Sophia", "Martinez", 890.60),
            new CardHolder("88996620012345", 7321, "James", "Taylor", 600.15)
        };

        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please enter your debit card: ");
        string debitCardNum = "";
        CardHolder currentUser = null;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();

                currentUser = cardHolders.FirstOrDefault(a => a.GetCardNum() == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized. Please try again later."); }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again later.");
            }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());

                if (currentUser.GetPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin. Please try again later."); }
            }
            catch
            {
                Console.WriteLine("Incorrect pin. Please try again later.");
            }
        }

        Console.WriteLine("Welcome " + currentUser.GetFirstName() + " :)");
        int option = 0;

        do
        {
            PrintOptions();
            try
            {
                option = int.Parse(Console.ReadLine());

                if (option == 1) { Deposit(currentUser); }
                else if (option == 2) { Withdraw(currentUser); }
                else if (option == 3) { Balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
            catch
            {
                option = 0;
            }

        } while (option != 4);

        Console.WriteLine("Thank you! Have a nice day :)");
    }
}
