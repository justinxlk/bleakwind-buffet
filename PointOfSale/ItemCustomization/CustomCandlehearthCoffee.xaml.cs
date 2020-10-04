/*
 * Author: Justin Kingry
 * Class name: CustomCandlehearthCoffee.xaml.cs
 * Purpose: Code behind CustomCandlehearthCoffee.xaml
 */


using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.ItemCustomization
{
    /// <summary>
    /// Interaction logic for CustomCandlehearthCoffee.xaml
    /// </summary>
    public partial class CustomCandlehearthCoffee : UserControl
    {
        /// <summary>
        /// CandlehearthCoffee object to be used throughout CustomCandlehearthCoffee
        /// </summary>
        public CandlehearthCoffee chcCustom = new CandlehearthCoffee();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to chcCustom
        /// </summary>
        public CustomCandlehearthCoffee()
        {
            InitializeComponent();
            DataContext = chcCustom;
        }

        /*
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(chcCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        */
    }
}
