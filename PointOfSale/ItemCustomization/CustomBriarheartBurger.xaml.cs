/*
 * Author: Justin Kingry
 * Class name: CustomBriarheartBurger.xaml.cs
 * Purpose: Code behind CustomBriarheartBurger.xaml
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
    /// Interaction logic for CustomBriarheartBurger.xaml
    /// </summary>
    public partial class CustomBriarheartBurger : UserControl
    {
        /// <summary>
        /// BriarheartBurger object to be used throughout CustomBriarheartBurger
        /// </summary>
        public BriarheartBurger bbCustom = new BriarheartBurger();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to bbCustom
        /// </summary>
        public CustomBriarheartBurger()
        {
            InitializeComponent();
            DataContext = bbCustom;
        }

        /*
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(bbCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        */
    }
}
