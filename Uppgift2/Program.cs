using Uppgift2;

/*
 * Uppgift 2.
 *
 * Implementerar meny och användar val.
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
