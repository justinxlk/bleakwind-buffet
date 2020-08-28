using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class Double_Drauger
    {
        /// <summary>
        /// sets the price
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// sets the calories
        /// </summary>
        public uint Calories => 843;



        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// gives the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }



        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else specialInstructions.Remove("Hold ketchup");
                ketchup = value;
            }
        }


        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mustard");
                else specialInstructions.Remove("Hold mustard");
                mustard = value;
            }
        }



        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold bun");
                else specialInstructions.Remove("Hold bun");
                bun = value;
            }
        }



        private bool pickle = true;
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold pickle");
                else specialInstructions.Remove("Hold pickle");
                pickle = value;
            }
        }




        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold cheese");
                else specialInstructions.Remove("Hold cheese");
                cheese = value;
            }
        }




        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold tomato");
                else specialInstructions.Remove("Hold tomato");
                tomato = value;
            }
        }




        private bool lettuce = true;
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold lettuce");
                else specialInstructions.Remove("Hold lettuce");
                lettuce = value;
            }
        }




        private bool mayo = true;
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mayo");
                else specialInstructions.Remove("Hold mayo");
                mayo = value;
            }
        }




    }
}
