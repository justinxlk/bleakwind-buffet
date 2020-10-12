/*
 * Author: Justin Kingry
 * Class name: CustomMarkarthMilk.xaml.cs
 * Purpose: Code behind CustomMarkarthMilk.xaml
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
    /// Interaction logic for CustomMarkarthMilk.xaml
    /// </summary>
    public partial class CustomMarkarthMilk : UserControl
    {
        /// <summary>
        /// MarkarthMilk object to be used throughout CustomMarkarthMilk
        /// </summary>
        public MarkarthMilk mmCustom = new MarkarthMilk();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to mmCustom
        /// </summary>
        public CustomMarkarthMilk()
        {
            InitializeComponent();
            DataContext = mmCustom;
        }

        
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(mmCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
