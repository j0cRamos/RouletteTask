using System;
using Roulette.Entities;
using Roulette.Enums;

namespace Roulette.Functions
{
    public static class PlaceBet
    {
        public static Bet GeneratePlaceAndBet()
        {
            var bet = new Bet();

            Random rnd = new Random();

            int betPlace = rnd.Next(0, 49);
            int betAmount = rnd.Next(100, 10000);

            Array values = Enum.GetValues(typeof(Places));
            string value = values.GetValue(betPlace).ToString();


            bet.Place = value;
            bet.BetAmount = betAmount;

            return bet;
        }

    }
}
