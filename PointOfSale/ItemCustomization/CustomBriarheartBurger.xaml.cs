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

        public BriarheartBurger bbCustom = new BriarheartBurger();

        public CustomBriarheartBurger()
        {
            InitializeComponent();
        }

        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(bbCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
    }
}
