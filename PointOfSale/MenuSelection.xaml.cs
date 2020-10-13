/*
 * Author: Justin Kingry
 * Class name: MenuSelection.xaml.cs
 * Purpose: Code behind MenuSelection.xaml
 */


using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.ItemCustomization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {

        //OrderLogic orderLogic = new OrderLogic();
        
        /// <summary>
        /// Constructor for MenuSelection
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
            //DataContext = new OrderLogic();
        }

        /// <summary>
        /// pulls up the CustomBriarheartBurger page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickBriarheartBurger(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            CustomBriarheartBurger cbb = new CustomBriarheartBurger(bb);
            AddToOrderPage.Child = cbb;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(bb);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
            
            
        }

        /// <summary>
        /// pulls up the CustomDoubleDraugr page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickDoubleDraugr(object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            CustomDoubleDraugr cdd = new CustomDoubleDraugr(dd);
            AddToOrderPage.Child = cdd;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(dd);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }

        }

        /// <summary>
        /// pulls up the CustomThalmorTripple page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickThalmorTriple(object sender, RoutedEventArgs e)
        {
            ThalmorTriple tt = new ThalmorTriple();
            CustomThalmorTriple ctt = new CustomThalmorTriple(tt);
            AddToOrderPage.Child = ctt;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(tt);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomAretinoAppleJuice page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aa = new AretinoAppleJuice();
            CustomAretinoAppleJuice caj = new CustomAretinoAppleJuice(aa);
            AddToOrderPage.Child = caj;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(aa);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomCandlehearthCoffee page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            CustomCandlehearthCoffee cchc = new CustomCandlehearthCoffee(chc);
            AddToOrderPage.Child = cchc;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(chc);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomDragonBornWaffleFries page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            CustomDragonbornWaffleFries cdbwf = new CustomDragonbornWaffleFries(dbwf);
            AddToOrderPage.Child = cdbwf;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(dbwf);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomFriedMiraak page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickFriedMiraak(object sender, RoutedEventArgs e)
        {
            FriedMiraak fm = new FriedMiraak();
            CustomFriedMiraak cfm = new CustomFriedMiraak(fm);
            AddToOrderPage.Child = cfm;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(fm);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomGardenOrcOmelette page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            CustomGardenOrcOmelette cgoo = new CustomGardenOrcOmelette(goo);
            AddToOrderPage.Child = cgoo;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(goo);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomMadOtarGrits page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickMadOtarGrits(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mog = new MadOtarGrits();
            CustomMadOtarGrits cmog = new CustomMadOtarGrits(mog);
            AddToOrderPage.Child = cmog;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(mog);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CUstomMarkarthMilk page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickMarkarthMilk(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            CustomMarkarthMilk cmm = new CustomMarkarthMilk(mm);
            AddToOrderPage.Child = cmm;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(mm);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }


        /// <summary>
        /// pulls up the CustomPhillyPoacher page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickPhillyPoacher(object sender, RoutedEventArgs e)
        {
            PhillyPoacher pp = new PhillyPoacher();
            CustomPhillyPoacher cpp = new CustomPhillyPoacher(pp);
            AddToOrderPage.Child = cpp;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(pp);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomSailorSoda page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickSailorSoda(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            CustomSailorSoda css = new CustomSailorSoda(ss);
            AddToOrderPage.Child = css;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(ss);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomSmokehouseSkeleton page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            CustomSmokehouseSkeleton css = new CustomSmokehouseSkeleton(ss);
            AddToOrderPage.Child = css;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(ss);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }

        }

        /// <summary>
        /// pulls up the CustomVokunSalad page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickVokunSalad(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            CustomVokunSalad cvs = new CustomVokunSalad();
            AddToOrderPage.Child = cvs;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(vs);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// pulls up the CustomWarriorWater page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickWarriorWater(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            CustomWarriorWater cww = new CustomWarriorWater(ww);
            AddToOrderPage.Child = cww;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(ww);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// might use later
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickThugsTBone(object sender, RoutedEventArgs e)
        {
            ThugsTBone ttb = new ThugsTBone();
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(ttb);

            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }




    }
}
