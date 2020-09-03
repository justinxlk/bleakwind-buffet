using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class Aretino_Apple_Juice
    {
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        private bool ice = false;
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
            }
        }


        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0.62;
                if (Size == Enums.Size.Medium) return 0.87;
                if (Size == Enums.Size.Large) return 1.01;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
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

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        //public BleakwindBuffet.Data.Enums.SodaFlavor Flavor { get; set; } = Enums.SodaFlavor.Cherry;


        public override string ToString()
        {
            return "{Size} Aretino Apple Juice";
        }
    }
}
