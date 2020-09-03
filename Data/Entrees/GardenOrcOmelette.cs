using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class Garden_Orc_Omelette
    {
        /// <summary>
        /// sets the price
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// sets the calories
        /// </summary>
        public uint Calories => 404;



        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// gives the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }



        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold broccoli");
                else specialInstructions.Remove("Hold broccoli");
                broccoli = value;
            }
        }



        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mushrooms");
                else specialInstructions.Remove("Hold mushrooms");
                mushrooms = value;
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



        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold cheddar");
                else specialInstructions.Remove("Hold cheddar");
                cheddar = value;
            }
        }




        public override string ToString()
        {
            return "Garden Orc Omelette";
        }


    }
}
