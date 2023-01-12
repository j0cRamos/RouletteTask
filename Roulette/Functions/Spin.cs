using System;
namespace Roulette.Functions
{
    public static class Spin
    {
        public static int GenerateSpin()
        {
            Random rnd = new Random();

            int spin = rnd.Next(0, 37);

            return spin;
        }
    }
}

