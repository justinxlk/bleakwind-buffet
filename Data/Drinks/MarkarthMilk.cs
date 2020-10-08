/*
 * Author: Justin Kingry
 * Class name: MarkarthMilk.cs
 * Purpose: Stores all of the information and options for an order of Markarth Milk
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// the class for Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink , INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        private bool ice = false;
        /// <summary>
        /// Gets and sets if there is ice.  Initializes to false.   Updates ui to match property changes
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

        /// <summary>
        /// Gets the price based upon the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.05;
                if (Size == Enums.Size.Medium) return 1.11;
                if (Size == Enums.Size.Large) return 1.22;
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
                if (Size == Enums.Size.Small) return 56;
                if (Size == Enums.Size.Medium) return 72;
                if (Size == Enums.Size.Large) return 93;
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
        /// <returns>The size followed by "Markarth Milk"</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
