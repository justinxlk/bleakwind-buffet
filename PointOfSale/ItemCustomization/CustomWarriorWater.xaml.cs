/*
 * Author: Justin Kingry
 * Class name: CustomWarriorWater.xaml.cs
 * Purpose: Code behind CustomWarriorWater.xaml
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
    /// Interaction logic for CustomWarriorWater.xaml
    /// </summary>
    public partial class CustomWarriorWater : UserControl
    {
        /// <summary>
        /// WarriorWater object to be used throughout CustomWarriorWater
        /// </summary>
        WarriorWater wwCustom = new WarriorWater();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to wwCustom
        /// </summary>
        public CustomWarriorWater()
        {
            InitializeComponent();
            DataContext = wwCustom;
        }

        
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(wwCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
