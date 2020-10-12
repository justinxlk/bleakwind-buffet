/*
 * Author: Justin Kingry
 * Class name: MenuSelection.xaml.cs
 * Purpose: Code behind MenuSelection.xaml
 */


using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
            CustomBriarheartBurger cbb = new CustomBriarheartBurger();
            AddToOrderPage.Child = cbb;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cbb.bbCustom);

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
            CustomDoubleDraugr cdd = new CustomDoubleDraugr();
            AddToOrderPage.Child = cdd;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cdd.ddCustom);

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
            CustomThalmorTriple ctt = new CustomThalmorTriple();
            AddToOrderPage.Child = ctt;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(ctt.ttCustom);

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
            CustomAretinoAppleJuice caj = new CustomAretinoAppleJuice();
            AddToOrderPage.Child = caj;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(caj.aaCustom);

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
            CustomCandlehearthCoffee cchc = new CustomCandlehearthCoffee();
            AddToOrderPage.Child = cchc;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cchc.chcCustom);

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
            CustomDragonbornWaffleFries cdbwf = new CustomDragonbornWaffleFries();
            AddToOrderPage.Child = cdbwf;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cdbwf.dbwfCustom);

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
            CustomFriedMiraak cfm = new CustomFriedMiraak();
            AddToOrderPage.Child = cfm;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cfm.fmCustom);

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
            CustomGardenOrcOmelette cgoo = new CustomGardenOrcOmelette();
            AddToOrderPage.Child = cgoo;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cgoo.gooCustom);

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
            CustomMadOtarGrits cmog = new CustomMadOtarGrits();
            AddToOrderPage.Child = cmog;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cmog.mogCustom);

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
            CustomMarkarthMilk cmm = new CustomMarkarthMilk();
            AddToOrderPage.Child = cmm;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cmm.mmCustom);

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
            CustomPhillyPoacher cpp = new CustomPhillyPoacher();
            AddToOrderPage.Child = cpp;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cpp.ppCustom);

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
            CustomSailorSoda css = new CustomSailorSoda();
            AddToOrderPage.Child = css;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(css.ssCustom);

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
            CustomSmokehouseSkeleton css = new CustomSmokehouseSkeleton();
            AddToOrderPage.Child = css;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(css.ssCustom);

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
            CustomVokunSalad cvs = new CustomVokunSalad();
            AddToOrderPage.Child = cvs;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cvs.vsCustom);

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
            CustomWarriorWater cww = new CustomWarriorWater();
            AddToOrderPage.Child = cww;
            if (DataContext is OrderLogic orderLogic)
            {
                orderLogic.Add(cww.wwCustom);

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
