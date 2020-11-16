/*
 * Author: Justin Kingry
 * Class name: WariorWater.cs
 * Purpose: Stores all of the information and options for an order of Warrior Water
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Warrior Water
    /// </summary>
    public class WarriorWater : Drink , INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        private Enums.Size size = Enums.Size.Small;
        /// <summary>
        /// Gets and sets the size.  Initializes the size to small.   Updates ui to match property changes
        /// </summary>
        public override BleakwindBuffet.Data.Enums.Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringPrice"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// Gets and sets if there is ice.  Initializes to true.   Updates ui to match property changes
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ice");
                else specialInstructions.Remove("Hold ice");
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private bool lemon = false;
        /// <summary>
        /// Gets and sets if there is a lemon. Initializes to false.   Updates ui to match property changes
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                if (value) specialInstructions.Add("Add lemon");
                else specialInstructions.Remove("Add lemon");
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets the price based upon the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0;
                if (Size == Enums.Size.Medium) return 0;
                if (Size == Enums.Size.Large) return 0;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the Calories based upon the size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 0;
                if (Size == Enums.Size.Medium) return 0;
                if (Size == Enums.Size.Large) return 0;
                throw new NotImplementedException("Unknown size of {Size}");
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
        /// <returns>The Size followed by "Warrior Water"</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }

        /// <summary>
        /// A description of Warrior Water
        /// </summary>
        public override string Description { get { return "It’s water. Just water."; } }

    }
}
