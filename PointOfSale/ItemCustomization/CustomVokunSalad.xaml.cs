/*
 * Author: Justin Kingry
 * Class name: CustomVokunSalad.xaml.cs
 * Purpose: Code behind CustomVokunSalad.xaml
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
    /// Interaction logic for VokunSalad.xaml
    /// </summary>
    public partial class CustomVokunSalad : UserControl
    {
        /// <summary>
        /// VokunSalad object to be used throughout CustomVokunSalad
        /// </summary>
        public VokunSalad vsCustom;

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to vsCustom
        /// </summary>
        public CustomVokunSalad()
        {
            InitializeComponent();
            DataContext = vsCustom;
        }

        public CustomVokunSalad(VokunSalad vs)
        {
            InitializeComponent();
            vsCustom = vs;
            DataContext = vs;
        }

        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(vsCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
