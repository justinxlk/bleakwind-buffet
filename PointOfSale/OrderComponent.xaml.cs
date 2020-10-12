/*
 * Author: Justin Kingry
 * Class name: OrderComponet.xaml.cs
 * Purpose: Code behind OrderComponent.xaml
 */


using BleakwindBuffet.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// constructor for OrderComponent
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// removes the selected item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickRemove(object sender, RoutedEventArgs e)
        {
            if (DataContext is OrderLogic orderLogic)
            {
                //IOrderItem i = (IOrderItem)orderDisplay.SelectedItem;
                //orderLogic.Remove(i);
                if (orderDisplay.SelectedItem is IOrderItem item && item != null)
                {
                    orderLogic.Remove(item);
                }
            }
            else
            {
                throw new NotImplementedException("data context is not OrderLogic");
            }
        }

        /// <summary>
        /// goes back to the page to change the item details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickChange(object sender, RoutedEventArgs e)
        {
            
        }







        //public List<IOrderItem> list = new List<IOrderItem>();

        /*
        public void PutInOrder(IOrderItem orderItem)
        {
            list.Add(orderItem);
            currentItemsInOrder.Items.Add(orderItem.ToString());
        }
        */
    }
}
