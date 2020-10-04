/*
 * Author: Justin Kingry
 * Class name: DoubleDrauger.cs
 * Purpose: Stores all of the information and options for an order of the Double Drauger
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Double Drauger
    /// </summary>
    public class DoubleDraugr : Entree , INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// The calories
        /// </summary>
        public override uint Calories => 843;


        
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        
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
            }
        }


        private bool tomato = true;
        /// <summary>
        /// Gets and sets if there are tomatos. Initializes to true.
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold tomato");
                else specialInstructions.Remove("Hold tomato");
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }


        private bool lettuce = true;
        /// <summary>
        /// Gets and sets if there is lettuce. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold lettuce");
                else specialInstructions.Remove("Hold lettuce");
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }


        private bool mayo = true;
        /// <summary>
        /// Gets and sets if there is mayo. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mayo");
                else specialInstructions.Remove("Hold mayo");
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>Double Drauger</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }


    }
}
