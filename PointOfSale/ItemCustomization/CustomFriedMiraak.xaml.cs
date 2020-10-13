/*
 * Author: Justin Kingry
 * Class name: CustomFriedMiraak.xaml.cs
 * Purpose: Code behind CustomFrieadMiraak.xaml
 */


using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for FriedMiraak.xaml
    /// </summary>
    public partial class CustomFriedMiraak : UserControl
    {
        /// <summary>
        /// FriedMiraak object to be used throughout CustomFriedMiraar
        /// </summary>
        public FriedMiraak fmCustom;

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to fmCustom
        /// </summary>
        public CustomFriedMiraak()
        {
            InitializeComponent();
            DataContext = fmCustom;
        }

        public CustomFriedMiraak(FriedMiraak fm)
        {
            InitializeComponent();
            fmCustom = fm;
            DataContext = fm;
        }

        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(fmCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
