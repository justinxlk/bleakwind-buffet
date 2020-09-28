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

        FriedMiraak fmCustom = new FriedMiraak();

        public CustomFriedMiraak()
        {
            InitializeComponent();
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
