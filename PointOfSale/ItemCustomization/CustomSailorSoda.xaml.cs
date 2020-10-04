/*
 * Author: Justin Kingry
 * Class name: CustomSailorSoda.xaml.cs
 * Purpose: Code behind CustomSailorSoda.xaml
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
    /// Interaction logic for CustomizeSailorSoda.xaml
    /// </summary>
    public partial class CustomSailorSoda : UserControl
    {
        /// <summary>
        /// SailorSoda object that is to be used throughout CustomSailorSoda
        /// </summary>
        SailorSoda ssCustom = new SailorSoda();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to ssCustom
        /// </summary>
        public CustomSailorSoda()
        {
            InitializeComponent();
            DataContext = ssCustom;
        }

        /*
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(ssCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        */
    }
}
