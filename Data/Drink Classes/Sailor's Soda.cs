using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drink_Classes
{
    class Sailor_s_Soda
    {

        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        private bool ice = true;
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
            }
        }


        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.42;
                if (Size == Enums.Size.Medium) return 1.74;
                if (Size == Enums.Size.Large) return 2.07;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
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

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public BleakwindBuffet.Data.Enums.SodaFlavor Flavor { get; set; } = Enums.SodaFlavor.Cherry;


        public override string ToString()
        {
            return "{Size} {Flavor} Sailor Soda";
        }

    }
}
