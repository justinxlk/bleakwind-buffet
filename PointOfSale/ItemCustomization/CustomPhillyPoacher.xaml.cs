/*
 * Author: Justin Kingry
 * Class name: CustomPhillyPoacher.xaml.cs
 * Purpose: Code behind CustomPhillyPoacher.xaml
 */


using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for CustomPhillyPoacher.xaml
    /// </summary>
    public partial class CustomPhillyPoacher : UserControl
    {
        /// <summary>
        /// PhillyPoacher object to be used throughout CustomPhillyPoacher
        /// </summary>
        PhillyPoacher ppCustom = new PhillyPoacher();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to ppCustom
        /// </summary>
        public CustomPhillyPoacher()
        {
            InitializeComponent();
            DataContext = ppCustom;
        }

        /*
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(ppCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        */
    }
}
