using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Side_Classes
{
    class Fried_Miraak
    {
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0.93;
                if (Size == Enums.Size.Medium) return 1.28;
                if (Size == Enums.Size.Large) return 1.82;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 41;
                if (Size == Enums.Size.Medium) return 52;
                if (Size == Enums.Size.Large) return 73;
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
            return "{Size} Fried Miraak";
        }
    }
}
