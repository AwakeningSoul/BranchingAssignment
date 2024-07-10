using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the initial welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.Write("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the weight is greater than 50
            if (weight > 50)
            {
                // Display error message and end the program if the weight is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt the user to enter the package width
            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the package height
            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the package length
            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check if the sum of dimensions is greater than 50
            if (width + height + length > 50)
            {
                // Display error message and end the program if the dimensions are too large
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate the quote: multiply dimensions, multiply by weight, then divide by 100
            decimal quote = (width * height * length * weight) / 100.0m;

            // Display the quote as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
