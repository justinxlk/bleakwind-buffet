/*
 * Author: Justin Kingry
 * Class name: PhillyPoacher.cs
 * Purpose: Stores all of the information and options for an order of the Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Philly Poacher
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// The price
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// The calories
        /// </summary>
        public uint Calories => 784;



        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        private bool sirloin = true;
        /// <summary>
        /// Gets and sets if there is sirloin. Initializes to true.
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold sirloin");
                else specialInstructions.Remove("Hold sirloin");
                sirloin = value;
            }
        }


        private bool onion = true;
        /// <summary>
        /// Gets and sets if there are onions. Initializes to true.
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold onions");
                else specialInstructions.Remove("Hold onions");
                onion = value;
            }
        }


        private bool roll = true;
        /// <summary>
        /// Gets and sets if there are rolls. Initializes to true.
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold roll");
                else specialInstructions.Remove("Hold roll");
                roll = value;
            }
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>Philly Poacher</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
