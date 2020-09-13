/*
 * Author: Justin Kingry
 * Class name: Entree.cs
 * Purpose: Base class for each menue item classified as an entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>In Imperial Septims</value>
        public abstract double Price { get; }


        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The entree's special instructions needed for prepparation
        /// </summary>
        public virtual List<string> SpecialInstructions { get; }
    }
}
