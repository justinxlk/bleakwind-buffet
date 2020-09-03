using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class Philly_Poacher
    {
        /// <summary>
        /// sets the price
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// sets the calories
        /// </summary>
        public uint Calories => 784;



        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// gives the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }



        private bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold sirloin");
                else specialInstructions.Remove("Hold sirloin");
                sirloin = value;
            }
        }



        private bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold onion");
                else specialInstructions.Remove("Hold onion");
                onion = value;
            }
        }



        private bool roll = true;
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold roll");
                else specialInstructions.Remove("Hold roll");
                roll = value;
            }
        }


        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
