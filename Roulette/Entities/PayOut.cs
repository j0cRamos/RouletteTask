using System;
namespace Roulette.Entities
{
    public static class Payout
    {
        public static double GeneratePayout(string place, int bet, int spin)
        {
            double amount = 0;

            switch (spin)
            {
                case 0:
                    if (place == "G0")
                    {
                        amount = bet * 36;
                    }
                    break;
                case 1:
                    if (place == "B1")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 2:
                    if (place == "R2")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 3:
                    if (place == "B3")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }

                    break;
                case 4:
                    if (place == "R4")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 5:
                    if (place == "B5")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 6:
                    if (place == "R6")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 7:
                    if (place == "B7")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 8:
                    if (place == "R8")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 9:
                    if (place == "B9")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 10:
                    if (place == "R10")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 11:
                    if (place == "B11")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 12:
                    if (place == "R12")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From1To12" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 13:
                    if (place == "B13")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 14:
                    if (place == "R14")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 15:
                    if (place == "B15")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 16:
                    if (place == "R16")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 17:
                    if (place == "B17")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From1To18" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 18:
                    if (place == "R18")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From1To18" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 19:
                    if (place == "B19")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 20:
                    if (place == "R20")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 21:
                    if (place == "B21")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 22:
                    if (place == "R22")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 23:
                    if (place == "B23")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 24:
                    if (place == "R24")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From13To24" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 25:
                    if (place == "B25")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 26:
                    if (place == "R26")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 27:
                    if (place == "B27")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 28:
                    if (place == "R28")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 29:
                    if (place == "B29")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 30:
                    if (place == "R30")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 31:
                    if (place == "B31")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 32:
                    if (place == "R32")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 33:
                    if (place == "B33")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 34:
                    if (place == "R34")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "FirstColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 35:
                    if (place == "B35")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "SecondColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Odd" || place == "From19To36" || place == "Black")
                    {
                        amount = bet * 1.06;
                    }
                    break;
                case 36:
                    if (place == "R36")
                    {
                        amount = bet * 36;
                    }
                    else if (place == "From25To36" || place == "ThirdColumn")
                    {
                        amount = bet * 2.08;
                    }
                    else if (place == "Even" || place == "From19To36" || place == "Red")
                    {
                        amount = bet * 1.06;
                    }
                    break;
            }

            return amount;
        }
    }
}

