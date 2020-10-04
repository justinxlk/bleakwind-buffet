/*
 * Author: Justin Kingry
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Stores all of the information and options for an order of Dragonborn Waffle Fries
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side , INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private Enums.Size size = Enums.Size.Small;
        /// <summary>
        /// Gets and sets the size.  Initializes the size to small.  Updates ui to match property changes
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
            }
        }

        /// <summary>
        /// Gets the price dependent upon the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0.42;
                if (Size == Enums.Size.Medium) return 0.76;
                if (Size == Enums.Size.Large) return 0.96;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the claories dependent upon the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 77;
                if (Size == Enums.Size.Medium) return 89;
                if (Size == Enums.Size.Large) return 100;
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
        /// <returns>The size, followed by "Dragonborn Waffle Fries"</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
