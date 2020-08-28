using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class Smokehouse_Skeleton
    {
        /// <summary>
        /// sets the price
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// sets the calories
        /// </summary>
        public uint Calories => 602;



        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// gives the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }




        private bool sausageLink = true;

        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold sausage");
                else specialInstructions.Remove("Hold suasage");
            }
        }



        private bool hashBrowns = true;

        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold hash browns");
                else specialInstructions.Remove("Hold hash browns");
            }
        }




        private bool pancake = true;

        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold pancakes");
                else specialInstructions.Remove("Hold pancakes");
            }
        }



        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold eggs");
                else specialInstructions.Remove("Hold eggs");
                egg = value;
            }
        }



        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}
