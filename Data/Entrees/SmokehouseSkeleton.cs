﻿/*
 * Author: Justin Kingry
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Stores all of the information and options for an order of the Smokehouse Skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// The price
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// The calories
        /// </summary>
        public uint Calories => 602;


        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        private bool sausageLink = true;
        /// <summary>
        /// Gets and sets if there are sausage links. Initializes to true.
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold sausage");
                else specialInstructions.Remove("Hold suasage");
                sausageLink = value;
            }
        }


        private bool hashBrowns = true;
        /// <summary>
        /// Gets and sets if there are hash browns. Initializes to true.
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold hash browns");
                else specialInstructions.Remove("Hold hash browns");
                hashBrowns = value;
            }
        }


        private bool pancake = true;
        /// <summary>
        /// Gets and sets if there are panckaes. Initializes to true.
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold pancakes");
                else specialInstructions.Remove("Hold pancakes");
                pancake = value;
            }
        }


        private bool egg = true;
        /// <summary>
        /// Gets and sets if there are eggs. Initializes to true.
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold eggs");
                else specialInstructions.Remove("Hold eggs");
                egg = value;
            }
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>Smokehouse Skeleton</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}
