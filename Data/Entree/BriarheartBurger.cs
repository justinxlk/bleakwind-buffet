using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class BriarheartBurger
    {
        private double price1 = 6.32;
        /// <summary>
        /// gets the price of the burger
        /// </summary>
        public double Price
        {
            get { return price1; }
            //get => 6.32;
            //public double Price => 6.32
        }

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public uint Calories => 732;


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



        //public bool Bun { get; set; } = true; //technically the same as ketchup

        //private bool mustard = true;

        //public bool Mustard
        //{
        //    get => mustard;
        //    set => mustard = value;
        //}


        private List<string> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
            // get {
            //      List<string> instructions = new List<string>();
            //      if(!Bun) instructions.Add("Hold bun");
            //      if(!Ketchup) instructions.Add("Hold Ketchup");
            //      return instructions;
            // }
        }

        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
