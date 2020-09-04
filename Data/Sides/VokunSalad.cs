﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        public BleakwindBuffet.Data.Enums.Size Size { get; set; } = Size.Small;

        //public Size Size { get; set; } = Size.Medium

        //private Size size9 = Size.Medium;

        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.93;
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                throw new NotImplementedException("Unknown size of {Size}");
            }
        }


        //public double Price2
        //{
        //    get
        //    {
        //        switch(Size)
        //        {
        //            case Size.Small:
        //                return 0.93;
        //        }
        //    }
        //}
        private List<string> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return "{Size} Vokun Salad";
        }

    }
}
