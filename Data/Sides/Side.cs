/*
 * Author: Justin Kingry
 * Class name: Side.cs
 * Purpose: Base class for each menu item classified as a side
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem , INotifyPropertyChanged
    {

        public virtual event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size 
        {
            get
            {
                return size;
            } 
            set
            {
                size = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

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

        /// <summary>
        /// makes the sides string into a property so that it may be changed on the fly
        /// </summary>
        public virtual string StringName { get { return ToString(); } }

        /// <summary>
        /// puts a $ before the price
        /// </summary>
        public virtual string StringPrice { get { return "$" + Price; } }

        public abstract string Description { get; }

    }
}
