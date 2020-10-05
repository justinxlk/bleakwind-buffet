/*
 * Author: Justin Kingry
 * Class name: CustomMadOtarGrits.xaml.cs
 * Purpose: Code behind CustomMadOtarGrits.xaml
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
    /// Interaction logic for CustomMadOtarGrits.xaml
    /// </summary>
    public partial class CustomMadOtarGrits : UserControl
    {
        /// <summary>
        /// MadOtarGrits object to be used thoroughout CustomMadOtarGrits
        /// </summary>
        MadOtarGrits mogCustom = new MadOtarGrits();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to mogCustom
        /// </summary>
        public CustomMadOtarGrits()
        {
            InitializeComponent();
            DataContext = mogCustom;
        }

        
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(mogCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
