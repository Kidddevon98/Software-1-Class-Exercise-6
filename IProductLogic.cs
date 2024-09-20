using System;
using System.Collections.Generic;

namespace PetStore
{
    /// <summary>
    /// Provides an interface for product-related operations in the PetStore.
    /// </summary>
    public interface IProductLogic
    {
        /// <summary>
        /// Adds a product to the store inventory.
        /// </summary>
        /// <param name="product">The product to add.</param>
        void AddProduct(Product product);

        /// <summary>
        /// Retrieves all products available in the store.
        /// </summary>
        /// <returns>A list of all products.</returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// Retrieves a dog leash by its name.
        /// </summary>
        /// <param name="name">The name of the dog leash.</param>
        /// <returns>The DogLeash object matching the specified name.</returns>
        DogLeash? GetDogLeashByName(string name);

        /// <summary>
        /// Retrieves a list of only products that are in stock.
        /// </summary>
        /// <returns>A list of in-stock product names.</returns>
        List<string> GetOnlyInStockProducts();

        /// <summary>
        /// Gets the total price of the inventory for all in-stock products.
        /// </summary>
        /// <returns>The total price of the in-stock inventory.</returns>
        decimal GetTotalPriceOfInventory();
    }
}
