using System;

namespace CodeCalisthenics.Operations
{
    public class Operators
    {
        public double Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tipAmount = GetPercentage(meal_cost, tip_percent);

            var priceAfterTax = GetMealPriceAfterTax(meal_cost, tax_percent) + tipAmount;

            priceAfterTax = RoundNumber(priceAfterTax, 0.5);

            Console.WriteLine(priceAfterTax);

            return priceAfterTax;
        }

        private static double GetPercentage(double price, double percentage)
        {
            return price * percentage / 100;
        }

        private static double RoundNumber(double finalPrice, double rounding)
        {
            var truncatedPrice = (int) finalPrice;
            if ((finalPrice - truncatedPrice) > rounding)
                finalPrice = truncatedPrice + 1;
            else
                finalPrice = truncatedPrice;
            return finalPrice;
        }

        private static double GetMealPriceAfterTax(double basePrice, double percentageIncrease)
        {
            var increase = percentageIncrease / 100;
            return basePrice * (1 + increase);
        }
    }
}
