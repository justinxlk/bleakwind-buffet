/*
 * Author: Justin Kingry
 * Class name: BriarheartBurger.cs
 * Purpose: Stores all of the information and options for an order of the Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        private double price1 = 6.32;
        /// <summary>
        /// gets the price of the burger
        /// </summary>
        public double Price
        {
            get { return price1; }
            //get => 6.32;
            //public double Price => 6.32
        }

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public uint Calories => 743;

        /// <summary>
        /// Gets and sets if there is ketchup. Initializes to true.
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else specialInstructions.Remove("Hold ketchup");
                ketchup = value;
            }
        }

        /// <summary>
        /// Gets and sets if there is mustard. Initializes to true.
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mustard");
                else specialInstructions.Remove("Hold mustard");
                mustard = value;
            }
        }

        /// <summary>
        /// Gets and sets if there is a bun. Initializes to true.
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold bun");
                else specialInstructions.Remove("Hold bun");
                bun = value;
            }
        }

        /// <summary>
        /// Gets and sets if there are pickles. Initializes to true.
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold pickle");
                else specialInstructions.Remove("Hold pickle");
                pickle = value;
            }
        }

        /// <summary>
        /// Gets and sets if there is cheese. Initializes to true.
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold cheese");
                else specialInstructions.Remove("Hold cheese");
                cheese = value;
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
        /// <returns>Briarheart Burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
