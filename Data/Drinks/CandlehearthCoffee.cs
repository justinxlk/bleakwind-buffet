using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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

        private bool roomForCream = false;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                if (value) specialInstructions.Add("Add cream");
                else specialInstructions.Remove("Add cream");
                roomForCream = value;
            }
        }




        private bool decaf = false;
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }




        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small) return 0.75;
                if (Size == Enums.Size.Medium) return 1.25;
                if (Size == Enums.Size.Large) return 1.75;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small) return 7;
                if (Size == Enums.Size.Medium) return 10;
                if (Size == Enums.Size.Large) return 20;
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
            if (Decaf == false)
            {
                return $"{Size} Candlehearth Coffee";
            }
            else
            {
                return $"{Size} Decaf Candlehearth Coffee";
            }
        }


    }
}
