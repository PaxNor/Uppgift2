using Uppgift2;

/*
 * Uppgift 2.
 * 
 * Todo:
 *  - Add methods for menu item 1 and 2 in TicketCalculator, eg QueryForPrice, QueryForGroupPrice
 *  - Add new class for the other menu items, eg StringMachine with methods PrintTenTimes and PrintThirdWord
 *  
 *  (Alternatively, use one class eg Assignment and put all methods in this one class)
 * 
 */

const string menu =
@"
Select an option from the alternatives below.

    1) Get ticket price.
    2) Get ticket price for group.
    3) String looper.
    4) String parser.
    Q) Quit application.";


while(true)
{
    Console.WriteLine(menu);
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            TicketCalculator.QueryForPrice();
            break;

        case "2":
            TicketCalculator.QueryForGroupPrice();
            break;

        case "3":
            StringMachine.PrintTenTimes();
            break;

        case "4":
            StringMachine.PrintThirdWord();
            break;

        case "q":
        case "Q":
            Environment.Exit(0);
            break;

        default:
            break;
    }

    Console.Write("Press any key to continue.. ");
    Console.ReadKey();
    Console.Clear();
}
