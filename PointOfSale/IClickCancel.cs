/*
 * Author: Justin Kingry
 * Class name: IClickCancel.cs
 * Purpose: plan on changing this in future milestones
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// interface class for clicking the canceling 
    /// </summary>
    public interface IClickCancel
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
