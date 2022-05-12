using Uppgift2;

/*
 * Uppgift 2.
 */

const string menu =
@"          --- Main menu ---

Select an option from the alternatives below.

    1) Get ticket price.
    2) Get ticket price for group.
    3) String looper.
    4) String parser.
    Q) Quit application.";


// main program loop
while(true)
{
    Console.WriteLine(menu);
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            uint age = IOUtil.GetUInt32(prompt: "Enter age: ");
            int price = TicketCalculator.FindPrice(age);

            Console.WriteLine($"The price is: {price}");
            break;

        case "2":
            uint groupSize;
            int ticketSumTotal = 0;
            do
            {
                groupSize = IOUtil.GetUInt32(prompt: "Enter group size: ");
            } while (groupSize < 1);

            for(int i = 0; i < groupSize; i++)
            {
                age = IOUtil.GetUInt32(prompt: $"Enter age for person {i + 1}: ");
                ticketSumTotal += TicketCalculator.FindPrice(age);
            }
            Console.WriteLine($"Group size: {groupSize}\nSum total: {ticketSumTotal}");
            break;

        case "3":
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}{1}", text, i < 9 ? ", " : "\n");
            }
            break;

        case "4":
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
