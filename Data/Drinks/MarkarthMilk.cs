/*
 * Author: Justin Kingry
 * Class name: MarkarthMilk.cs
 * Purpose: Stores all of the information and options for an order of Markarth Milk
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// the class for Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        /// <summary>
        /// Gets and sets the size.  Initializes the size to small.
        /// </summary>
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        
        private bool ice = false;
        /// <summary>
        /// Gets and sets if there is ice.  Initializes to false.
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (value) specialInstructions.Add("Add ice");
                else specialInstructions.Remove("Add ice");
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
                if (Size == Enums.Size.Small) return 1.05;
                if (Size == Enums.Size.Medium) return 1.11;
                if (Size == Enums.Size.Large) return 1.22;
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
                if (Size == Enums.Size.Small) return 56;
                if (Size == Enums.Size.Medium) return 72;
                if (Size == Enums.Size.Large) return 93;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>The size followed by "Markarth Milk"</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
