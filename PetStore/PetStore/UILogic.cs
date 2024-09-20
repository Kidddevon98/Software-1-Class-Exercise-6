using System;

namespace PetStore
{
    public static class UILogic
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Press 1 to add a Dog Leash product");
            Console.WriteLine("Press 2 to view a Dog Leash Product");
            Console.WriteLine("Press 3 to view in-stock products");
            Console.WriteLine("Press 4 to view the total price of current inventory");
            Console.WriteLine("Type 'exit' to quit");
        }

        public static string GetUserInput()
        {
            return Console.ReadLine()?.ToLower() ?? string.Empty;
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
        }

        public static int GetIntegerInput(string prompt)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }

            DisplayMessage("Invalid input. Defaulting to 0.");
            return 0;
        }

        public static decimal GetDecimalInput(string prompt)
        {
            Console.Write(prompt);
            if (decimal.TryParse(Console.ReadLine(), out decimal value))
            {
                return value;
            }

            DisplayMessage("Invalid input. Defaulting to 0.");
            return 0m;
        }

        public static void DisplayInStockProducts(ProductLogic productLogic)
        {
            DisplayMessage("The following products are in stock: ");
            var inStock = productLogic.GetOnlyInStockProducts();
            foreach (var item in inStock)
            {
                DisplayMessage(item);
            }
        }

        public static void DisplayTotalPrice(ProductLogic productLogic)
        {
            DisplayMessage($"The total price of inventory on hand is {productLogic.GetTotalPriceOfInventory():C}");
        }
    }
}
