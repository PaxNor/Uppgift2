/*
 * Uppgift 2.
 */

const string banner =
@"          --- Main menu ---

Select an option from the alternatives below.

    1) Movie price calculator.
    2) String manipulation.
    Q) Quit application.";


// main program loop
while(true)
{
    Console.WriteLine(banner);
    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            break;

        case "2":
            break;

        case "q":
        case "Q":
            Environment.Exit(0);
            break;

        default:
            break;
    }

    Console.Clear();
}

