/*
 * Author: Justin Kingry
 * Class name: Drink.cs
 * Purpose: Base class for each menue item classified as a drink
 */

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks.
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>In Imerial Septums</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The drink's special instructions needed for prepperation
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
