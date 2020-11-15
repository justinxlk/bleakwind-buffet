/*
 * Author: Justin Kingry
 * Class name: Combo.cs
 * Purpose: Stores all of the information and items in the combo.
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// class for the combo
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        
        private double price = 0;
        /// <summary>
        /// toatal price of the combo with a $1 discount
        /// </summary>
        public double Price
        {
            get { return -1 + Drink.Price + Entree.Price + Side.Price; }
            private set { price = value; }
        }

        
        private uint calories;
        /// <summary>
        /// total calories of the combo
        /// </summary>
        public uint Calories
        {
            get { return Drink.Calories + Entree.Calories + Side.Calories; }
            private set { calories = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        private Drink drink;
        /// <summary>
        /// Drink for the combo
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private Entree entree;
        /// <summary>
        /// entree for the combo
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private Side side;
        /// <summary>
        /// side for the combo
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Each item followed by its special instructions in the form of a List of strings
        /// </summary>
        public List<string> SpecialInstructions 
        {
            get
            {
                specialInstructions = new List<string>();
                specialInstructions.Add(Drink.ToString());
                specialInstructions.AddRange(Drink.SpecialInstructions);
                specialInstructions.Add(Entree.ToString());
                specialInstructions.AddRange(Entree.SpecialInstructions);
                specialInstructions.Add(Side.ToString());
                specialInstructions.AddRange(Side.SpecialInstructions);
                return specialInstructions;
            }
            private set { specialInstructions = value; } 
        }

        public string StringName { get { return "Don't use this"; } }

        public string Description => throw new NotImplementedException();

    }
}
