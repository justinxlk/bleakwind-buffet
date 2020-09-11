﻿/*
 * Author: Justin Kingry
 * Class name: VokunSalad.cs
 * Purpose: Stores all of the information and options for an order of the Vokun Salad
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// Gets and sets the size. Initializes to Small.
        /// </summary>
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price dependent upon the size.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.93;
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
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
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
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
        /// <returns>The size, followed by "Vokun Salad"</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }

    }
}
