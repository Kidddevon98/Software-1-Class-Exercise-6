using PetStore;
using System.Text.Json;

var productLogic = new ProductLogic();

void DisplayMenu()
{
    Console.WriteLine("Press 1 to add a Dog Leash product");
    Console.WriteLine("Press 2 to view a Dog Leash Product");
    Console.WriteLine("Press 3 to view in-stock products");
    Console.WriteLine("Press 4 to view the total price of current inventory");
    Console.WriteLine("Type 'exit' to quit");
}

void AddDogLeash()
{
    var dogLeash = new DogLeash();

    Console.WriteLine("Creating a dog leash...");

    Console.Write("Enter the material the leash is made out of: ");
    dogLeash.Material = Console.ReadLine() ?? "Unknown";

    Console.Write("Enter the length in inches: ");
    if (int.TryParse(Console.ReadLine(), out int length))
    {
        dogLeash.LengthInches = length;
    }
    else
    {
        Console.WriteLine("Invalid input for length. Defaulting to 0.");
        dogLeash.LengthInches = 0;
    }

    Console.Write("Enter the name of the leash: ");
    dogLeash.Name = Console.ReadLine() ?? "Unknown";

    Console.Write("Give the product a short description: ");
    dogLeash.Description = Console.ReadLine() ?? "No description";

    Console.Write("Give the product a price: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal price))
    {
        dogLeash.Price = price;
    }
    else
    {
        Console.WriteLine("Invalid input for price. Defaulting to 0.");
        dogLeash.Price = 0;
    }

    Console.Write("How many products do you have on hand? ");
    if (int.TryParse(Console.ReadLine(), out int quantity))
    {
        dogLeash.Quantity = quantity;
    }
    else
    {
        Console.WriteLine("Invalid input for quantity. Defaulting to 0.");
        dogLeash.Quantity = 0;
    }

    productLogic.AddProduct(dogLeash);
    Console.WriteLine("Added a dog leash");
}

void ViewDogLeash()
{
    Console.Write("What is the name of the dog leash you would like to view? ");
    var dogLeashName = Console.ReadLine();

    if (!string.IsNullOrEmpty(dogLeashName)) // Check for null or empty input
    {
        var dogLeash = productLogic.GetDogLeashByName(dogLeashName);
        if (dogLeash != null) // Check if dogLeash is found
        {
            Console.WriteLine(JsonSerializer.Serialize(dogLeash));
        }
        else
        {
            Console.WriteLine("Dog Leash not found.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Name cannot be null or empty.");
    }
    Console.WriteLine();
}

void ViewInStockProducts()
{
    Console.WriteLine("The following products are in stock: ");
    var inStock = productLogic.GetOnlyInStockProducts();
    foreach (var item in inStock)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}

void ViewTotalPrice()
{
    Console.WriteLine($"The total price of inventory on hand is {productLogic.GetTotalPriceOfInventory():C}");
    Console.WriteLine();
}

DisplayMenu();
string? userInput = Console.ReadLine();

while (userInput?.ToLower() != "exit")
{
    switch (userInput)
    {
        case "1":
            AddDogLeash();
            break;
        case "2":
            ViewDogLeash();
            break;
        case "3":
            ViewInStockProducts();
            break;
        case "4":
            ViewTotalPrice();
            break;
        default:
            Console.WriteLine("Invalid input. Please choose a valid option.");
            break;
    }

    DisplayMenu();
    userInput = Console.ReadLine();
}
