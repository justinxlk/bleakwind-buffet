using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class Mad_Otar_Grits
    {
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.22;
                if (Size == Enums.Size.Medium) return 1.58;
                if (Size == Enums.Size.Large) return 1.93;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
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

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        public override string ToString()
        {
            return "{Size} Mad Otar Grits";
        }
    }
}
