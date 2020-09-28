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

        DoubleDraugr ddCustom = new DoubleDraugr();

        public CustomDoubleDraugr()
        {
            InitializeComponent();
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
