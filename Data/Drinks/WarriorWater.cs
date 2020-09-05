/*
 * Author: Justin Kingry
 * Class name: WariorWater.cs
 * Purpose: Stores all of the information and options for an order of Warrior Water
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Warrior Water
    /// </summary>
    public class WarriorWater
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
        /// Gets and sets if there is a lemon. Initializes to false.
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                if (value) specialInstructions.Add("Add lemon");
                else specialInstructions.Remove("Add lemon");
                lemon = value;
            }
        }

        /// <summary>
        /// Gets the price based upon the size.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0;
                if (Size == Enums.Size.Medium) return 0;
                if (Size == Enums.Size.Large) return 0;
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
                if (Size == Enums.Size.Small) return 0;
                if (Size == Enums.Size.Medium) return 0;
                if (Size == Enums.Size.Large) return 0;
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
        /// <returns>The Size followed by "Warrior Water"</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
