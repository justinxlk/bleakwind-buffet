/*
 * Author: Justin Kingry
 * Class name: ThalmorTriple.cs
 * Purpose: Stores all of the information and options for an order of the Thalmor Triple
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree , INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// The calories
        /// </summary>
        public override uint Calories => 943;


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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private bool mustard = true;
        /// <summary>
        /// Gets and sets if the is mustard. Initializes to true.   Updates ui to match property changes
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
        /// Gets and sets if there are pickles. Initializes to true.  Updates ui to match property changes
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


        private bool tomato = true;
        /// <summary>
        /// Gets and sets if there is cheese. Initializes to true.   Updates ui to match property changes
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private bool bacon = true;
        /// <summary>
        /// Gets and sets if there is bacon. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold bacon");
                else specialInstructions.Remove("Hold bacon");
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private bool egg = true;
        /// <summary>
        /// Gets and sets if there are eggs. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold egg");
                else specialInstructions.Remove("Hold egg");
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>Thalmor Triple</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

        /// <summary>
        /// A description of Thalmor Tripple
        /// </summary>
        public override string Description { get { return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg."; } }

    }
}
