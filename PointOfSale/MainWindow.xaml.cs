/*
 * Author: Justin Kingry
 * Class name: MainWindow.xaml.cs
 * Purpose: Code behind MainWindow.xaml
 */


using BleakwindBuffet.Data;
using PointOfSale.ItemCustomization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Constructor for the MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            //buttonCancel.IsEnabled = false;
            //buttonEnter.IsEnabled = false;
            //order.DataContext = new BleakwindBuffet.Data.OrderLogic();
            DataContext = new BleakwindBuffet.Data.OrderLogic();
        }

        /// <summary>
        /// returns to the MenuSelection screen
        /// </summary>
        /// <param name="sender">buttonCancel aka the cancel button</param>
        /// <param name="e"></param>
        public void ClickCancel(object sender, RoutedEventArgs e)
        {
            menuSelection = new MenuSelection();
            biggestBorder.Child = menuSelection;
        }

        /// <summary>
        /// returns to the MenueSelection screen, will do more in the future
        /// </summary>
        /// <param name="sender">buttonEnter aka the done button</param>
        /// <param name="e"></param>
        public void ClickAddOrder(object sender, RoutedEventArgs e)
        {   
            
            menuSelection = new MenuSelection();
            biggestBorder.Child = menuSelection;
             
            
        }

        public void ClickNewOrder(object sender, RoutedEventArgs e)
        {
            /*orderComponent.*/DataContext = new BleakwindBuffet.Data.OrderLogic();

        }

    }
}
