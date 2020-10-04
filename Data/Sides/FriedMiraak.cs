/*
 * Author: Justin Kingry
 * Class name: FriadMiraak.cs
 * Purpose: Stores all of the information and options for an order of Fried Miraak
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for Fried Miraak
    /// </summary>
    public class FriedMiraak : Side , INotifyPropertyChanged
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
            } 
        }

        /// <summary>
        /// Gets the price dependent uppon the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.78;
                if (Size == Enums.Size.Medium) return 2.01;
                if (Size == Enums.Size.Large) return 2.88;
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
                if (Size == Enums.Size.Small) return 151;
                if (Size == Enums.Size.Medium) return 236;
                if (Size == Enums.Size.Large) return 306;
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
        /// <returns>The size, followed by "Fried Miraak"</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
