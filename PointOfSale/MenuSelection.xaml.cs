/*
 * Author: Justin Kingry
 * Class name: MenuSelection.xaml.cs
 * Purpose: Code behind MenuSelection.xaml
 */


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

        
        /// <summary>
        /// Constructor for MenuSelection
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// pulls up the CustomBriarheartBurger page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickBriarheartBurger(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomBriarheartBurger();
        }

        /// <summary>
        /// pulls up the CustomDoubleDraugr page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickDoubleDraugr(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomDoubleDraugr();
        }

        /// <summary>
        /// pulls up the CustomThalmorTripple page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickThalmorTriple(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomThalmorTriple();
        }

        /// <summary>
        /// pulls up the CustomAretinoAppleJuice page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomAretinoAppleJuice();
        }

        /// <summary>
        /// pulls up the CustomCandlehearthCoffee page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomCandlehearthCoffee();
        }

        /// <summary>
        /// pulls up the CustomDragonBornWaffleFries page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomDragonbornWaffleFries();
        }

        /// <summary>
        /// pulls up the CustomFriedMiraak page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickFriedMiraak(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomFriedMiraak();
        }

        /// <summary>
        /// pulls up the CustomGardenOrcOmelette page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomGardenOrcOmelette();
        }

        /// <summary>
        /// pulls up the CustomMadOtarGrits page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickMadOtarGrits(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomMadOtarGrits();
        }

        /// <summary>
        /// pulls up the CUstomMarkarthMilk page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickMarkarthMilk(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomMarkarthMilk();
        }


        /// <summary>
        /// pulls up the CustomPhillyPoacher page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickPhillyPoacher(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomPhillyPoacher();
        }

        /// <summary>
        /// pulls up the CustomSailorSoda page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickSailorSoda(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomSailorSoda();
        }

        /// <summary>
        /// pulls up the CustomSmokehouseSkeleton page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomSmokehouseSkeleton();
        }

        /// <summary>
        /// pulls up the CustomVokunSalad page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickVokunSalad(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomVokunSalad();
        }

        /// <summary>
        /// pulls up the CustomWarriorWater page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickWarriorWater(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomWarriorWater();
        }

        /// <summary>
        /// might use later
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickThugsTBone(object sender, RoutedEventArgs e)
        {

        }




    }
}
