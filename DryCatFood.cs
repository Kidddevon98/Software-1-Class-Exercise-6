using System;

namespace PetStore
{
    /// <summary>
    /// Represents a type of cat food that is dry.
    /// Inherits properties from the CatFood class.
    /// </summary>
    public class DryCatFood : CatFood
    {
        /// <summary>
        /// Gets or sets the weight of the dry cat food in pounds.
        /// </summary>
        public double WeightPounds { get; set; }

        /// <summary>
        /// Initializes a new instance of the DryCatFood class.
        /// </summary>
        public DryCatFood()
        {
            WeightPounds = 0.0;
        }
    }
}

