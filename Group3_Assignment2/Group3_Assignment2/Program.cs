using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(100, "External Hard Drive", 79.99, 70);

            bool continueOperation = true;

            while (continueOperation)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Increase stock");
                Console.WriteLine("2. Decrease stock");
                Console.WriteLine("3. Exit");
                Console.WriteLine("\n");

                string operationChoice = GetStringFromConsole("Enter your choice:");

                switch (operationChoice)
                {
                    case "1":
                        IncreaseStock(product);
                        break;
                    case "2":
                        DecreaseStock(product);
                        break;
                    case "3":
                        continueOperation = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void IncreaseStock(Product product)
        {
            int increaseAmount = GetIntegerFromConsole("Enter the amount to increase stock by:");
            product.IncreaseStock(increaseAmount);
            Console.WriteLine($"Stock increased by {increaseAmount}. New stock: {product.Stock} \n");
        }

        static void DecreaseStock(Product product)
        {
            int decreaseAmount = GetIntegerFromConsole("Enter the amount to decrease stock by:");
            product.DecreaseStock(decreaseAmount);
            Console.WriteLine($"Stock decreased by {decreaseAmount}. New stock: {product.Stock} \n");
        }

        static string GetStringFromConsole(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine()?.Trim() ?? "";

            while (String.IsNullOrEmpty(userInput))
            {
                userInput = Console.ReadLine()?.Trim() ?? "";
            }
            return userInput;
        }

        static int GetIntegerFromConsole(string message)
        {
            Console.WriteLine(message);
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please provide a valid input.");
            }
            return userInput;
        }
    }
}
