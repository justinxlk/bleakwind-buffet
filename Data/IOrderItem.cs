/*
 * Author: Justin Kingry
 * Class name: IOrderItem.cs
 * Purpose: Iterface class for each item on the menue 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price of the ordered item
        /// </summary>
        /// <value>In Imperial Septims</value>
        double Price { get; }

        /// <summary>
        /// Calories of the ordered item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Ordered item's special instructions needed for prepparation
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
