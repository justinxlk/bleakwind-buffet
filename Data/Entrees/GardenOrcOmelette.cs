/*
 * Author: Justin Kingry
 * Class name: GardenOrcOmelette.cs
 * Purpose: Stores all of the information and options for an order of the Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <summary>
        /// The price
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// The calories
        /// </summary>
        public uint Calories => 404;



        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        private bool broccoli = true;
        /// <summary>
        /// Gets and sets if there is Broccoli. Initializes to true.
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold broccoli");
                else specialInstructions.Remove("Hold broccoli");
                broccoli = value;
            }
        }


        private bool mushrooms = true;
        /// <summary>
        /// Gets and sets if there are mushrooms. Initializes to true.
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mushrooms");
                else specialInstructions.Remove("Hold mushrooms");
                mushrooms = value;
            }
        }


        private bool tomato = true;
        /// <summary>
        /// Gets and sets if there are tomatos. Initializes to true.
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold tomato");
                else specialInstructions.Remove("Hold tomato");
                tomato = value;
            }
        }


        private bool cheddar = true;
        /// <summary>
        /// Gets and sets if the is cheddar. Initializes to true.
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold cheddar");
                else specialInstructions.Remove("Hold cheddar");
                cheddar = value;
            }
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>Garden Orc Omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }


    }
}
