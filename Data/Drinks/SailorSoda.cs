/*
 * Author: Justin Kingry
 * Class name: SailorSoda.cs
 * Purpose: Stores all of the information and options for an order of Sailor's Soda
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using SodaFlavor = BleakwindBuffet.Data.Enums.SodaFlavor;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Sailor's Soda
    /// </summary>
    public class SailorSoda : Drink , INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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

        /// <summary>
        /// Gets the price based upon the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.42;
                if (Size == Enums.Size.Medium) return 1.74;
                if (Size == Enums.Size.Large) return 2.07;
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
                if (Size == Enums.Size.Small) return 117;
                if (Size == Enums.Size.Medium) return 153;
                if (Size == Enums.Size.Large) return 205;
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

        private BleakwindBuffet.Data.Enums.SodaFlavor flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
        /// <summary>
        /// Gets and sets the Flavor. Initializes to Cherry.
        /// </summary>
        public BleakwindBuffet.Data.Enums.SodaFlavor Flavor 
        {
            get
            {
                return flavor;
            } 
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StringName"));
            }
        }

        /// <summary>
        /// Overrides ToString
        /// </summary>
        /// <returns>The Size, followed by the Flavor, then "Sailor Soda"</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }

        /// <summary>
        /// A description of Sailor Soda
        /// </summary>
        public override string Description { get { return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice."; } }

    }
}
