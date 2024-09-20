using System;
using System.Collections.Generic;
using System.Linq;

namespace PetStore
{
    /// <summary>
    /// Provides logic for handling product-related operations.
    /// </summary>
    public class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeash;
        private Dictionary<string, CatFood> _catFood;

        /// <summary>
        /// Initializes the product logic with sample data.
        /// </summary>
        public ProductLogic()
        {
            _products = new List<Product>
            {
                new DogLeash
                {
                    Description = "A rope dog leash made from strong rope.",
                    LengthInches = 60,
                    Material = "Rope",
                    Name = "Rope Dog Leash",
                    Price = 21.00m,
                    Quantity = 0
                },
                new DryCatFood
                {
                    Quantity = 6,
                    Price = 25.59m,
                    Name = "Plain 'Ol Cat Food",
                    Description = "Nothing fancy to find here. Just the basic stuff your cat needs to live a healthy life.",
                    WeightPounds = 10,
                    KittenFood = false
                },
                new CatFood
                {
                    Quantity = 48,
                    Price = 12.99m,
                    Name = "Fancy Cat Food",
                    Description = "Food that isn't only delicious, but made from the finest ingredients.",
                    KittenFood = false
                }
            };

            _dogLeash = new Dictionary<string, DogLeash>();
            _catFood = new Dictionary<string, CatFood>();
        }

        /// <summary>
        /// Adds a product to the system.
        /// </summary>
        /// <param name="product">The product to add.</param>
        public void AddProduct(Product product)
        {
            if (product is DogLeash dogLeash)
            {
                _dogLeash[product.Name] = dogLeash;
            }
            else if (product is CatFood catFood)
            {
                _catFood[product.Name] = catFood;
            }

            _products.Add(product);
        }

        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <returns>A list of all products.</returns>
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        /// <summary>
        /// Retrieves a dog leash by its name.
        /// </summary>
        /// <param name="name">The name of the dog leash.</param>
        /// <returns>The matching dog leash, or null if not found.</returns>
        public DogLeash? GetDogLeashByName(string name)
        {
            if (_dogLeash.TryGetValue(name, out var leash))
             {
                return leash;
             }
             return null; //safe null return
        }

        /// <summary>
        /// Retrieves a list of only the products that are in stock.
        /// </summary>
        /// <returns>A list of product names that are in stock.</returns>
        public List<string> GetOnlyInStockProducts()
        {
            return _products.InStock().Select(x => x.Name).ToList();
        }

        /// <summary>
        /// Gets the total price of all in-stock inventory.
        /// </summary>
        /// <returns>The total price of in-stock inventory.</returns>
        public decimal GetTotalPriceOfInventory()
        {
            return _products.InStock().Select(x => x.Price).Sum();
        }
    }
}
