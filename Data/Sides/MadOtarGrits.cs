/*
 * Author: Justin Kingry
 * Class name: Mad Otar Grits.cs
 * Purpose: Stores all of the information and options for an order of Mad Otar Grits
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side , INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        private Enums.Size size = Enums.Size.Small;
        /// <summary>
        /// Gets and sets the size. Initializes to Small.   Updates ui to match property changes
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

        /// <summary>
        /// Gets the price depending upon the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.22;
                if (Size == Enums.Size.Medium) return 1.58;
                if (Size == Enums.Size.Large) return 1.93;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the calories depending upon the size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 105;
                if (Size == Enums.Size.Medium) return 142;
                if (Size == Enums.Size.Large) return 179;
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
        /// <returns>The size, followed by "Mad Otar Grits"</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }

        /// <summary>
        /// A description of Mad Otar Grits
        /// </summary>
        public override string Description { get { return "Cheesey Grits."; } }

    }
}
