using Uppgift2;

/*
 * Uppgift 2.
 */

const string banner =
@"          --- Main menu ---

Select an option from the alternatives below.

    1) Movie price calculator.
    2) String looper.
    3) String manipulator.
    Q) Quit application.";


// main program loop
while(true)
{
    Console.WriteLine(banner);
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            uint age;
            int price;
            do 
            {
                Console.Write("Enter age: ");
            } while (!uint.TryParse(Console.ReadLine(), out age));

            TicketCalculator calc = new TicketCalculator();
            price = calc.FindPrice(age);

            Console.WriteLine(@"The price is: {price}");
            break;

        case "2":
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(text);
            }
            Console.WriteLine();
            break;

        case "3":
            string[] words;
            do
            {
                Console.Write("Enter at least 3 words: ");
                string text2 = Console.ReadLine();
                words = text2.Split(' ');
            } while (words.Length < 3);

            Console.WriteLine($"Third word: {words[2]}");
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
