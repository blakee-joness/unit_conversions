namespace RecipeApp
{
    // | Unit              | Equivalent in Metric Units |
    // |-------------------|----------------------------|
    // | 1 cup             | 0.24 liters                |
    // | 1 gallon          | 3.79 liters                |
    // | 1 fluid ounce     | 29.57 milliliters          |
    // | 1 pint            | 0.47 liters                |
    // | 1 quart           | 0.95 liters                |
    // | 1 tablespoon      | 14.79 milliliters          |
    // | 1 teaspoon        | 4.93 milliliters           |


    /// <summary>
    /// // Holder of functions for the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        static void Main() // Entry point of the application
        {
            Console.WriteLine("Please enter teaspoons amount:");
            string? input = Console.ReadLine();

            Console.WriteLine(
                $"The conversion of {input} to milliliters is {ConvertTeaspoonsToMilliliters(input)}"
            );
        }

        /// <summary>
        /// Converts the given number of teaspoons to milliliters.
        /// </summary>
        /// <param name="teaspoons">The number of teaspoons to convert.</param>
        /// <returns>The equivalent number of milliliters.</returns>
        ///
        static void ConvertTeaspoonsToMilliliters(double teaspoons) // Function to convert Teaspoons to Milliliters
        {
            Console.WriteLine("Converting Teaspoons to Milliliters");
            const double millilitersPerTeaspoon = 4.93;
            return teaspoons * millilitersPerTeaspoon;
        }
    }
}
