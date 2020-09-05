/*
 * Author: Justin Kingry
 * Class name: SailorSoda.cs
 * Purpose: Stores all of the information and options for an order of Sailor's Soda
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using SodaFlavor = BleakwindBuffet.Data.Enums.SodaFlavor;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Sailor's Soda
    /// </summary>
    public class SailorSoda
    {
        /// <summary>
        /// Gets and sets the size.  Initializes the size to small.
        /// </summary>
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        /// <summary>
        /// Gets and sets if there is ice.  Initializes to true.
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ice");
                else specialInstructions.Remove("Hold ice");
                ice = value;
            }
        }

        /// <summary>
        /// Gets the price based upon the size.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.42;
                if (Size == Enums.Size.Medium) return 1.74;
                if (Size == Enums.Size.Large) return 2.07;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the Calories based upon the size.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 117;
                if (Size == Enums.Size.Medium) return 153;
                if (Size == Enums.Size.Large) return 205;
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
        /// Gets and sets the Flavor. Initializes to Cherry.
        /// </summary>
        public BleakwindBuffet.Data.Enums.SodaFlavor Flavor { get; set; } = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>The Size, followed by the Flavor, then "Sailor Soda"</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }

    }
}
