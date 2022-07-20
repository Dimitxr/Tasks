using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double grossValue = int.Parse(Console.ReadLine());
            double netValue;
            double tax = 0;
            double socialContribution = 0;

            if (grossValue <= 1000)
            {
                netValue = grossValue;
            }
            // CALCULATING THE TAX 
            // If it's needed in the future, we can add more taxes with if-esle statements,depending on their specifications.
            // Another way is to create a method for the taxes like the SocialContributionRounding.
            else if (grossValue > 1000)
            {
                tax = (grossValue - 1000) * 0.1;
            }

            if (grossValue - 1000 < 3000)
            {
                double roundedValue = SocialContributionRounding(grossValue);
                socialContribution = roundedValue * 0.15;
            }

            netValue = grossValue - tax - socialContribution;

            Console.WriteLine($"Net Salary = {netValue}");
            Console.WriteLine($"Tax = {tax}");
            Console.WriteLine($"Social Contribution = {socialContribution}");
        }

        public static double SocialContributionRounding(double grossValue)
        {
            double value = 0;
            if (grossValue - 1000 > 2000 && grossValue - 1000 < 3000)
            {
                value = 2000;
            }
            else if (grossValue - 1000 > 1000 && grossValue - 1000 < 2000)
            {
                value = 1000;
            }
            return value;
        }
    }
}
