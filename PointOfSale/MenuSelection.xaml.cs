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

        

        public MenuSelection()
        {
            InitializeComponent();
        }

        void ClickBriarheartBurger(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomBriarheartBurger();
        }

        void ClickDoubleDraugr(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomDoubleDraugr();
        }

        void ClickThalmorTriple(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomThalmorTriple();
        }

        void ClickAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomAretinoAppleJuice();
        }

        void ClickCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomCandlehearthCoffee();
        }

        void ClickDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomDragonbornWaffleFries();
        }

        void ClickFriedMiraak(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomFriedMiraak();
        }

        void ClickGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomGardenOrcOmelette();
        }

        void ClickMadOtarGrits(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomMadOtarGrits();
        }

        void ClickMarkarthMilk(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomMarkarthMilk();
        }

        void ClickPhillyPoacher(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomPhillyPoacher();
        }

        void ClickSailorSoda(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomSailorSoda();
        }

        void ClickSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomSmokehouseSkeleton();
        }

        void ClickVokunSalad(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomVokunSalad();
        }

        void ClickWarriorWater(object sender, RoutedEventArgs e)
        {
            AddToOrderPage.Child = new CustomWarriorWater();
        }

        void ClickThugsTBone(object sender, RoutedEventArgs e)
        {

        }




    }
}
