/*
 * Author: Justin Kingry
 * Class name: AretinoAppleJuice.cs
 * Purpose: Stores all of the information and options for an order of Aretino Apple Juice
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for AretinoAppleJuice.
    /// </summary>
    public class AretinoAppleJuice : Drink , INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        private Enums.Size size = Enums.Size.Small;
        /// <summary>
        /// Gets and sets the size.  Initializes the size to small. Updates the ui to match changes.
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
        /// Gets and sets the size.  Initializes the size to small.
        /// </summary>
        //public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;


        private bool ice = false;
        /// <summary>
        /// Gets and sets if there is ice.  Initializes to false.   updates ui to match changes
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (value)
                {
                    specialInstructions.Add("Add ice");
                }
                else
                {
                    specialInstructions.Remove("Add ice");
                }
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets the Price dependent upon the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0.62;
                if (Size == Enums.Size.Medium) return 0.87;
                if (Size == Enums.Size.Large) return 1.01;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the Calories dependent upon the size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 44;
                if (Size == Enums.Size.Medium) return 88;
                if (Size == Enums.Size.Large) return 132;
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
        /// <returns>The size followed by "Aretino Apple Juice"</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }

        /// <summary>
        /// A description of Aretino Apple Juice
        /// </summary>
        public override string Description { get { return "Fresh squeezed apple juice."; } } 

    }
}
