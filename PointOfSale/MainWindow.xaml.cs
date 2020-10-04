/*
 * Author: Justin Kingry
 * Class name: MainWindow.xaml.cs
 * Purpose: Code behind MainWindow.xaml
 */


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
        /// MenuSelection object to be used throughout MainWindow
        /// </summary>
        public MenuSelection menu = new MenuSelection();

        /// <summary>
        /// OrderComponenet to be used throughout MainWindow
        /// </summary>
        public OrderComponent order = new OrderComponent();

        /// <summary>
        /// Constructor for the MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            biggestBorder.Child = menu;
            bigBorder.Child = order;
            //buttonCancel.IsEnabled = false;
            //buttonEnter.IsEnabled = false;
        }

        /// <summary>
        /// returns to the MenuSelection screen
        /// </summary>
        /// <param name="sender">buttonCancel aka the cancel button</param>
        /// <param name="e"></param>
        public void ClickCancel(object sender, RoutedEventArgs e)
        {
            menu = new MenuSelection();
            biggestBorder.Child = menu;
        }

        /// <summary>
        /// returns to the MenueSelection screen, will do more in the future
        /// </summary>
        /// <param name="sender">buttonEnter aka the done button</param>
        /// <param name="e"></param>
        public void ClickDone(object sender, RoutedEventArgs e)
        {
            menu = new MenuSelection();
            biggestBorder.Child = menu;
            
            
        }
    }
}
