/*
 * Author: Justin Kingry
 * Class name: Menue.cs
 * Purpose: Stores all of the information and items on the menue.
 */

using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for the Menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// returns an IEnumerable list of every entree in the form of an IOrderItem
        /// </summary>
        /// <returns>IEnumerable list of every entree in the form of an IOrderItem</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            IEnumerable<IOrderItem> entrees2 = entrees;
            return entrees2;
            
        }

        /// <summary>
        /// returns an IEnumerable list of every side in the form of an IOrderItem
        /// </summary>
        /// <returns>IEnumerable list of every side in the form of an IOrderItem</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>() { };
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                FriedMiraak fm = new FriedMiraak();
                MadOtarGrits mog = new MadOtarGrits();
                VokunSalad vs = new VokunSalad();
                dwf.Size = size;
                fm.Size = size;
                mog.Size = size;
                vs.Size = size;
                sides.Add(dwf);
                sides.Add(fm);
                sides.Add(mog);
                sides.Add(vs);
            }
            IEnumerable<IOrderItem> sides2 = sides;
            return sides2;
        }

        /// <summary>
        /// returns an IEnumerable list of every drink in the form of an IOrderItem
        /// </summary>
        /// <returns>IEnumerable list of every drink in the form of an IOrderItem</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aa = new AretinoAppleJuice();
                CandlehearthCoffee chc = new CandlehearthCoffee();
                MarkarthMilk mm = new MarkarthMilk();
                WarriorWater ww = new WarriorWater();
                aa.Size = size;
                chc.Size = size;
                mm.Size = size;
                ww.Size = size;
                drinks.Add(aa);
                drinks.Add(chc);
                drinks.Add(mm);
                drinks.Add(ww);
                foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = size;
                    ss.Flavor = flavor;
                    drinks.Add(ss);
                }
            }
            IEnumerable<IOrderItem> drinks2 = drinks;
            return drinks2;
        }

        /// <summary>
        /// returns an IEnumerable list of every item on the menu in the form of an IOrderItem
        /// </summary>
        /// <returns>IEnumerable list of every item on the menu in the form of an IOrderItem</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> all = new List<IOrderItem>();
            all.Add((IOrderItem)Entrees());
            all.Add((IOrderItem)Sides());
            all.Add((IOrderItem)Drinks());
            IEnumerable<IOrderItem> all2 = all;
            return all2;
        }
    }
}
