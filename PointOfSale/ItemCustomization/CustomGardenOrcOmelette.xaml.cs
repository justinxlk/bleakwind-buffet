/*
 * Author: Justin Kingry
 * Class name: CustomGardenOrcOmelette.xaml.cs
 * Purpose: Code behind CustomGardenOrcOmelette.xaml
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
    /// Interaction logic for CustomGardenOrcOmelette.xaml
    /// </summary>
    public partial class CustomGardenOrcOmelette : UserControl
    {
        /// <summary>
        /// GardenOrcOmelette object to be used throughout CustomGardenOrcOmelette
        /// </summary>
        public GardenOrcOmelette gooCustom = new GardenOrcOmelette();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to gooCustom
        /// </summary>
        public CustomGardenOrcOmelette()
        {
            InitializeComponent();
            DataContext = gooCustom;
        }

        
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(aaCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
