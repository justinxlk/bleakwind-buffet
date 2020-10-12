/*
 * Author: Justin Kingry
 * Class name: CandlehearthCoffee.cs
 * Purpose: Stores all of the information and options for an order of Candlehearth Coffee
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for CandleHearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink , INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        private Enums.Size size = Enums.Size.Small;
        /// <summary>
        /// Gets and sets the size.  Initializes the size to small.   Updates the ui to match property changes
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringPrice"));
            }
        }


        private bool ice = false;
        /// <summary>
        /// Gets and sets if there is ice.  Initializes to false.   Updates the ui to match property changes.
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (value) specialInstructions.Add("Add ice");
                else specialInstructions.Remove("Add ice");
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private bool roomForCream = false;
        /// <summary>
        /// Gets and sets a bool for if there is any room for cream. Initializes to false.   Updates ui to match property changes
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                if (value) specialInstructions.Add("Add cream");
                else specialInstructions.Remove("Add cream");
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        private bool decaf = false;
        /// <summary>
        /// Gets and stes a bool for if it is decaf.  Initializes to false.   Updates ui to match property changes
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            }
        }

        /// <summary>
        /// Gets the price based upon the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0.75;
                if (Size == Enums.Size.Medium) return 1.25;
                if (Size == Enums.Size.Large) return 1.75;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the calories dependent upon the size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 7;
                if (Size == Enums.Size.Medium) return 10;
                if (Size == Enums.Size.Large) return 20;
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
        /// <returns>The size, followed by Decaf if its decaf, then Candlehearth Coffee</returns>
        public override string ToString()
        {
            if (Decaf == false)
            {
                return $"{Size} Candlehearth Coffee";
            }
            else
            {
                return $"{Size} Decaf Candlehearth Coffee";
            }
        }


    }
}
