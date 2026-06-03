namespace RetirementCalculator
{
    /// <summary>
    /// Represents a person's personal and financial profile
    /// for retirement planning purposes.
    /// </summary>
    public class Person
    {
        /// <summary>Gets or sets the person's full name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the person's current age in years.</summary>
        public int CurrentAge { get; set; }

        /// <summary>Gets or sets the target retirement age.</summary>
        public int RetirementAge { get; set; }

        /// <summary>Gets or sets the current savings balance.</summary>
        public double CurrentSavings { get; set; }

        /// <summary>Gets or sets the yearly contribution amount.</summary>
        public double AnnualContribution { get; set; }

        /// <summary>
        /// Calculates the number of years remaining until retirement.
        /// </summary>
        public int YearsUntilRetirement => RetirementAge - CurrentAge;

        /// <summary>
        /// Projects total savings at retirement using simple (non-compound) growth.
        /// Formula: CurrentSavings + (AnnualContribution × YearsUntilRetirement)
        /// </summary>
        public double ProjectedSavings =>
            CurrentSavings + (AnnualContribution * YearsUntilRetirement);

        /// <summary>
        /// Initializes a Person with all required financial details.
        /// </summary>
        public Person(string name, int currentAge, int retirementAge,
                      double currentSavings, double annualContribution)
        {
            Name               = name;
            CurrentAge         = currentAge;
            RetirementAge      = retirementAge;
            CurrentSavings     = currentSavings;
            AnnualContribution = annualContribution;
        }
    }
}
