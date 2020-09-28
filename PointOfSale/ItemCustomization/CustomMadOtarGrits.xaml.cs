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

        MadOtarGrits mogCustom = new MadOtarGrits();

        public CustomMadOtarGrits()
        {
            InitializeComponent();
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
