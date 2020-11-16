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
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks.
    /// </summary>
    public abstract class Drink : IOrderItem , INotifyPropertyChanged
    {

        public virtual event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// The size of the drink
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

        /// <summary>
        /// makes the drinks name into a property so that it can be changed on the fly
        /// </summary>
        public virtual string StringName { get { return ToString(); } }

        /// <summary>
        /// puts a $ before the price
        /// </summary>
        public virtual string StringPrice { get { return "$" + Price; } }

        /// <summary>
        /// A description of the drink
        /// </summary>
        public abstract string Description { get; }
    }
}
