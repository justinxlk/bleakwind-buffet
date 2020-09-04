using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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
                if (Size == Enums.Size.Small) return 1.05;
                if (Size == Enums.Size.Medium) return 1.11;
                if (Size == Enums.Size.Large) return 1.22;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
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

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        //public BleakwindBuffet.Data.Enums.SodaFlavor Flavor { get; set; } = Enums.SodaFlavor.Cherry;


        public override string ToString()
        {
            return "{Size} Markarth Milk";
        }
    }
}
