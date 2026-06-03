using System;

namespace RetirementCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("     RETIREMENT CALCULATOR");
            Console.WriteLine("====================================\n");

            // Collect and validate all inputs
            string name            = ReadStringInput("Enter your name: ");
            int    currentAge      = ReadIntInput("Enter your current age: ", 1, 110);
            int    retirementAge   = ReadIntInput("Enter your retirement age: ",
                                                   currentAge + 1, 110);
            double currentSavings  = ReadDoubleInput("Enter your current savings ($): ", 0);
            double annualContrib   = ReadDoubleInput("Enter your annual contribution ($): ", 0);

            // Build the Person model
            var person = new Person(name, currentAge, retirementAge,
                                    currentSavings, annualContrib);

            // Display the results
            PrintSummary(person);
        }

        /// <summary>
        /// Displays a formatted retirement savings summary.
        /// </summary>
        static void PrintSummary(Person person)
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine("     RETIREMENT SAVINGS SUMMARY");
            Console.WriteLine("====================================");
            Console.WriteLine($"{"Name:",-28}{person.Name}");
            Console.WriteLine($"{"Current Age:",-28}{person.CurrentAge}");
            Console.WriteLine($"{"Retirement Age:",-28}{person.RetirementAge}");
            Console.WriteLine($"{"Years Until Retirement:",-28}{person.YearsUntilRetirement}");
            Console.WriteLine($"{"Current Savings:",-28}{person.CurrentSavings,10:C}");
            Console.WriteLine($"{"Annual Contribution:",-28}{person.AnnualContribution,10:C}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{"Projected Savings:",-28}{person.ProjectedSavings,10:C}");
            Console.WriteLine("====================================");
        }

        /// <summary>Reads and validates a non-empty string.</summary>
        static string ReadStringInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(input))
                    return input;
                Console.WriteLine("⚠ Input cannot be empty.");
            }
        }

        /// <summary>Reads and validates an integer within a given range.</summary>
        static int ReadIntInput(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value)
                    && value >= min && value <= max)
                    return value;
                Console.WriteLine($"⚠ Please enter a whole number between {min} and {max}.");
            }
        }

        /// <summary>Reads and validates a non-negative double.</summary>
        static double ReadDoubleInput(string prompt, double min)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double value) && value >= min)
                    return value;
                Console.WriteLine($"⚠ Please enter a number of {min} or greater.");
            }
        }
    }
}
