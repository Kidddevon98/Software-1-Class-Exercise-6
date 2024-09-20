using System;

namespace PetStore
{
    /// <summary>
    /// Represents a cat food product in the PetStore.
    /// Inherits properties from the base Product class.
    /// </summary>
    public class CatFood : Product
    {
        /// <summary>
        /// Gets or sets a value indicating whether the cat food is suitable for kittens.
        /// </summary>
        public bool KittenFood { get; set; }
    }
}
