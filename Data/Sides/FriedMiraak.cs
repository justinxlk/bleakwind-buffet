using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Enums.Size.Small;

        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 1.78;
                if (Size == Enums.Size.Medium) return 2.01;
                if (Size == Enums.Size.Large) return 2.88;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
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

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
