using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// sets the price
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// sets the calories
        /// </summary>
        public uint Calories => 982;



        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// gives the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
