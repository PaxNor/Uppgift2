using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    static class TicketCalculator
    {
        private const int kidPrice = 80, pensionerPrice = 90, standardPrice = 120;
        private const int adultTier = 20, pensionerTier = 65;

        public static int FindPrice(uint age)
        {
            if (age < adultTier) return kidPrice;
            else if (age >= pensionerTier) return pensionerPrice;
            else return standardPrice;
        }

        public static void QueryForPrice()
        {
            uint age = IOUtil.GetUserInput(prompt: "Enter age: ");
            int price = TicketCalculator.FindPrice(age);
            Console.WriteLine($"The price is: {price}");
        }

        public static void QueryForGroupPrice()
        {
            uint age;
            uint groupSize;
            int ticketSumTotal = 0;
            do
            {
                groupSize = IOUtil.GetUserInput(prompt: "Enter group size: ");
            } while (groupSize < 1);

            for (int i = 0; i < groupSize; i++)
            {
                age = IOUtil.GetUserInput(prompt: $"Enter age for person {i + 1}: ");
                ticketSumTotal += TicketCalculator.FindPrice(age);
            }
            Console.WriteLine($"Group size: {groupSize}\nSum total: {ticketSumTotal}");
        }
    }
}
