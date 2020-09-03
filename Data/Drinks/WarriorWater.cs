using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class Warrior_Water
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



        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                if (value) specialInstructions.Add("Add lemon");
                else specialInstructions.Remove("Add lemon");
                ice = value;
            }
        }




        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0;
                if (Size == Enums.Size.Medium) return 0;
                if (Size == Enums.Size.Large) return 0;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 0;
                if (Size == Enums.Size.Medium) return 0;
                if (Size == Enums.Size.Large) return 0;
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
            return "{Size} Warrior Water";
        }
    }
}
