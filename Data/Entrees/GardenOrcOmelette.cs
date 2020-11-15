/*
 * Author: Justin Kingry
 * Class name: GardenOrcOmelette.cs
 * Purpose: Stores all of the information and options for an order of the Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree , INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// The calories
        /// </summary>
        public override uint Calories => 404;



        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Gets the special instructions in a list of strings. Initializes an empty list of strings.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        private bool broccoli = true;
        /// <summary>
        /// Gets and sets if there is Broccoli. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold broccoli");
                else specialInstructions.Remove("Hold broccoli");
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private bool mushrooms = true;
        /// <summary>
        /// Gets and sets if there are mushrooms. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mushrooms");
                else specialInstructions.Remove("Hold mushrooms");
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        private bool tomato = true;
        /// <summary>
        /// Gets and sets if there are tomatos. Initializes to true.   Updates ui to match property changes
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


        private bool cheddar = true;
        /// <summary>
        /// Gets and sets if the is cheddar. Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold cheddar");
                else specialInstructions.Remove("Hold cheddar");
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>Garden Orc Omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

        public override string Description { get { return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese."; } }

    }
}
