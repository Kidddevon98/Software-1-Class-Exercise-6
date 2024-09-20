using System;

namespace PetStore
{
    /// <summary>
    /// Represents a dog leash product in the PetStore.
    /// Inherits properties from the base Product class.
    /// </summary>
    public class DogLeash : Product
    {
        /// <summary>
        /// Gets or sets the length of the dog leash in inches.
        /// </summary>
        public int LengthInches { get; set; }

        /// <summary>
        /// Gets or sets the material of the dog leash.
        /// </summary>
        public string Material { get; set; } = string.Empty; // Ensures it's never null

        /// <summary>
        /// Initializes a new instance of the DogLeash class.
        /// </summary>
        public DogLeash()
        {
            Material = "Unknown";
            LengthInches = 0;
        }
    }
}
