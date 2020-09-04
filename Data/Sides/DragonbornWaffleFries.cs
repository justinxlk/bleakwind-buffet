using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0.42;
                if (Size == Enums.Size.Medium) return 0.76;
                if (Size == Enums.Size.Large) return 0.96;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
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

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        public override string ToString()
        {
            return "{Size} Dragonborn Waffle Fries";
        }
    }
}
