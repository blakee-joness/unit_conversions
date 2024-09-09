﻿namespace RecipeApp
{
    // | Unit              | Equivalent in Metric Units |
    // |-------------------|----------------------------|
    // | 1 cup             | 0.24 liters                |
    // | 1 gallon          | 3.79 liters                |
    // | 1 fluid ounce     | 29.57 milliliters          |
    // | 1 pint            | 0.47 liters                |
    // | 1 quart           | 0.95 liters                |
    // | 1 tablespoon      | 14.79 milliliters          |
    // | 1 teaspoon        | 4.92892 milliliters        |


    /// <summary>
    /// Holder of functions for the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        static void Main() // Entry point of the application
        {
            double input = GetTeaspoonFromConsole();
        }

        /// <summary>
        /// Convert Teaspoons to Milliliters
        /// </summary>
        /// <param name="teaspoons"></param>
        static double ConvertTeaspoonsToMilliliters(double teaspoons) // Function to convert Teaspoons to Milliliters
        {
            Console.WriteLine("Converting Teaspoons to Milliliters");
            const double millilitersPerTeaspoon = 4.92892;
            return Math.Round(teaspoons * millilitersPerTeaspoon, 2);
        }

        /// <summary>
        /// Get Teaspoon input value from Console
        /// </summary>
        /// <returns>double</returns>
        static double GetTeaspoonFromConsole()
        {
            Console.WriteLine("Please enter teaspoons amount:");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double teaspoons))
            // Check if the input is a value that can be converted to double
            {
                double milliliters = ConvertTeaspoonsToMilliliters(teaspoons);
                Console.WriteLine(
                    $"The conversion of {teaspoons} teaspoons to milliliters is {milliliters} ml"
                );
                return milliliters; // Add a return statement for the successful conversion
            }
            else
            // It's not, so we write to the user to enter a numeric value
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                return 0.00; // Add a return statement for the invalid input
            }
        }
    }
}
