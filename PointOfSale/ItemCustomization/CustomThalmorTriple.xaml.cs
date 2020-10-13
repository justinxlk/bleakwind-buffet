/*
 * Author: Justin Kingry
 * Class name: CustomThalmorTriple.xaml.cs
 * Purpose: Code behind CustomThalmorTriple.xaml
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
    /// Interaction logic for ThalmorTriple.xaml
    /// </summary>
    public partial class CustomThalmorTriple : UserControl
    {
        /// <summary>
        /// ThalmorTriple object to be used throughout CustomThalmorTriple
        /// </summary>
        public ThalmorTriple ttCustom;

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to ttCustom
        /// </summary>
        public CustomThalmorTriple()
        {
            InitializeComponent();
            DataContext = ttCustom;
        }

        public CustomThalmorTriple(ThalmorTriple tt)
        {
            InitializeComponent();
            ttCustom = tt;
            DataContext = tt;
        }

        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(ttCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
