/*
 * Author: Justin Kingry
 * Class name: CustomDragonbornWaffleFries.xaml.cs
 * Purpose: Code behind CustomDragonbornWaffleFries.xaml
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
    /// Interaction logic for CustomDragonbornWaffleFries.xaml
    /// </summary>
    public partial class CustomDragonbornWaffleFries : UserControl
    {
        /// <summary>
        /// DragonbornWaffleFries object to be used throughout CustomDragonbornWaffleFries
        /// </summary>
        DragonbornWaffleFries dbwfCustom = new DragonbornWaffleFries();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to dbwfCustom
        /// </summary>
        public CustomDragonbornWaffleFries()
        {
            InitializeComponent();
            DataContext = dbwfCustom;
        }

        
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(dbwfCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
