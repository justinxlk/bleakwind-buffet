/*
 * Author: Justin Kingry
 * Class name: Side.cs
 * Purpose: Base class for each menu item classified as a side
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>In Imperial Septims</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The side's special instructions needed for prepparation
        /// </summary>
        public virtual List<string> SpecialInstructions{ get; }
    }
}
