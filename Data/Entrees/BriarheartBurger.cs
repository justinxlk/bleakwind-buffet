/*
 * Author: Justin Kingry
 * Class name: BriarheartBurger.cs
 * Purpose: Stores all of the information and options for an order of the Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree , INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private double price1 = 6.32;
        /// <summary>
        /// gets the price of the burger
        /// </summary>
        public override double Price
        {
            get { return price1; }
            //get => 6.32;
            //public double Price => 6.32
        }

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;

        
        private bool ketchup = true;
        /// <summary>
        /// Gets and sets if there is ketchup. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else specialInstructions.Remove("Hold ketchup");
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private bool mustard = true;
        /// <summary>
        /// Gets and sets if there is mustard. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mustard");
                else specialInstructions.Remove("Hold mustard");
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private bool bun = true;
        /// <summary>
        /// Gets and sets if there is a bun. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold bun");
                else specialInstructions.Remove("Hold bun");
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private bool pickle = true;
        /// <summary>
        /// Gets and sets if there are pickles. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold pickle");
                else specialInstructions.Remove("Hold pickle");
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private bool cheese = true;
        /// <summary>
        /// Gets and sets if there is cheese. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold cheese");
                else specialInstructions.Remove("Hold cheese");
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.   
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>Briarheart Burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
