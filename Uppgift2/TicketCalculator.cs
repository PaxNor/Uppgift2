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
    }
}
