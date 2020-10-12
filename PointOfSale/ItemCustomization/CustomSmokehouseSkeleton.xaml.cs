/*
 * Author: Justin Kingry
 * Class name: CustomSmokehouseSkeleton.xaml.cs
 * Purpose: Code behind CustomSmokehouseSkeleton.xaml
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
    /// Interaction logic for SmokehouseSkeleton.xaml
    /// </summary>
    public partial class CustomSmokehouseSkeleton : UserControl
    {
        /// <summary>
        /// SmokehouseSkeleton object to be used throughout CustomSmokehouseSkeleton
        /// </summary>
        public SmokehouseSkeleton ssCustom = new SmokehouseSkeleton();

        /// <summary>
        /// Typical custructor that also links the buttons in the ui to ssCustom
        /// </summary>
        public CustomSmokehouseSkeleton()
        {
            InitializeComponent();
            DataContext = ssCustom;
        }

        
        void ClickDone(object sender, RoutedEventArgs e)
        {
            //OrderComponent.PutInOrder(ssCustom);
        }

        void ClickCancel(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
