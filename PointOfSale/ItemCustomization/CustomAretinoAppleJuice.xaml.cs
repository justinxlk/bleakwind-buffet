/*
 * Author: Justin Kingry
 * Class name: CustomAretinoAppleJuice.xaml.cs
 * Purpose: Code behind CustomAretinoAppleJuice.xaml
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
    /// Interaction logic for CustomAretinoAppleJuice.xaml
    /// </summary>
    public partial class CustomAretinoAppleJuice : UserControl
    {
        /// <summary>
        /// AretinoAppleJuice object to be used throughout CustomAretinoAppleJuice
        /// </summary>
        public AretinoAppleJuice aaCustom = new AretinoAppleJuice();


        /// <summary>
        /// Typical custructor that also links the buttons in the ui to aaCustom
        /// </summary>
        public CustomAretinoAppleJuice()
        {
            InitializeComponent();
            DataContext = aaCustom;
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
