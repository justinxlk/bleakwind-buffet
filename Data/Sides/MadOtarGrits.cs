/*
 * Author: Justin Kingry
 * Class name: Mad Otar Grits.cs
 * Purpose: Stores all of the information and options for an order of Mad Otar Grits
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Gets and sets the size. Initializes to Small.
        /// </summary>
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        /// <summary>
        /// Gets the price depending upon the size.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.22;
                if (Size == Enums.Size.Medium) return 1.58;
                if (Size == Enums.Size.Large) return 1.93;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the calories depending upon the size.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 105;
                if (Size == Enums.Size.Medium) return 142;
                if (Size == Enums.Size.Large) return 179;
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
        /// <returns>The size, followed by "Mad Otar Grits"</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
