/*
 * Author: Justin Kingry
 * Class name: CustomDoubleDraugr.xaml.cs
 * Purpose: Code behind CustomDoubleDraugr.xaml
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
    /// Interaction logic for CustomDoubleDraugr.xaml
    /// </summary>
    public partial class CustomDoubleDraugr : UserControl
    {
        /// <summary>
        /// DoubleDraugr to be used throughout CustomDoubleDraugr
        /// </summary>
        DoubleDraugr ddCustom = new DoubleDraugr();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to ddCustom
        /// </summary>
        public CustomDoubleDraugr()
        {
            InitializeComponent();
            DataContext = ddCustom;
        }

        
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(ddCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
