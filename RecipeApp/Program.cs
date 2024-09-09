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
    class Program
    {
        static void Main(string[] args) // Entry point of the application
        {
            Console.WriteLine("Please enter user input:");
            string? input = Console.ReadLine();
            Console.WriteLine($"You entered: {input}");
        }
    }
}
