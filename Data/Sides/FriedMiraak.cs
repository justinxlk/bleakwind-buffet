/*
 * Author: Justin Kingry
 * Class name: FriadMiraak.cs
 * Purpose: Stores all of the information and options for an order of Fried Miraak
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        /// <summary>
        /// Gets and sets the size.  Initializes the size to small.
        /// </summary>
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        /// <summary>
        /// Gets the price dependent uppon the size.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.78;
                if (Size == Enums.Size.Medium) return 2.01;
                if (Size == Enums.Size.Large) return 2.88;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the calories dependent upon the size.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 151;
                if (Size == Enums.Size.Medium) return 236;
                if (Size == Enums.Size.Large) return 306;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>The size, followed by "Fried Miraak"</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
