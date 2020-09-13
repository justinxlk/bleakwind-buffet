/*
 * Author: Justin Kingry
 * Class name: ThugsTBone.cs
 * Purpose: Stores all of the information and options for an order of the Thug's T-Bone
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Thug's T-Bone
    /// </summary>
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// The price
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// The calories
        /// </summary>
        public override uint Calories => 982;


        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>Thugs T-Bone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
