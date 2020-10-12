/*
 * Author: Justin Kingry
 * Class name: OrderLogic.cs
 * Purpose: Stores all of the information and items in the order.
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// class for the current order
    /// </summary>
    public class OrderLogic : ObservableCollection<IOrderItem> , INotifyPropertyChanged
    {

        public double SalesTaxRate { get; set; } = .12;
        /// <summary>
        /// sum of the price of all of the items in this order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in this)
                {
                    subtotal += item.Price;
                }
                return Math.Round(subtotal, 2);
            }
        }

        /// <summary>
        /// Total tax of this order
        /// </summary>
        public double Tax
        {
            get
            {
                double tax = SalesTaxRate * Subtotal;
                return Math.Round(tax, 2);
            }
        }

        /// <summary>
        /// Total cost of this order
        /// </summary>
        public double Total
        {
            get
            {
                double total = Tax + Subtotal;
                return Math.Round(total, 2);
            }
        }

        /// <summary>
        /// total Calories of this order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach (IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// Order number
        /// </summary>
        public int Number { get; }

        private static int nextOrderNumber = 1;

        /// <summary>
        /// constructor for this order
        /// </summary>
        public OrderLogic()
        {
            CollectionChanged += CollectionChangedListener;
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// updates properties when the collection has been changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("TextForSubtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("TextForTax"));
            OnPropertyChanged(new PropertyChangedEventArgs("TextForTotal"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                        //OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));//Note addition of new item
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                        OnPropertyChanged(new PropertyChangedEventArgs("TextForSubtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("TextForTax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("TextForTotal"));
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                        //OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));//Note addition of new item
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                        OnPropertyChanged(new PropertyChangedEventArgs("TextForSubtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("TextForTax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("TextForTotal"));
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    foreach (IOrderItem item in this)
                        throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
                    break;
            }
        }

        /// <summary>
        /// updates properties dependent upon the property changing
        /// </summary>
        /// <param name="listener"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object listener, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Price":
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("TextForSubtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("TextForTax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("TextForTotal"));
                    break;
                case "Calories":
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                default:
                    //throw new NotImplementedException("Something besides Price or Calories was trying to notify a change");
                    break;
            }

        }

        /// <summary>
        /// Number but labeled
        /// </summary>
        public string OrderNumber { get { return $"Order #{Number}"; } }

        /// <summary>
        /// Subtotal but labeled
        /// </summary>
        public string TextForSubtotal { get { return $"Subtotal: ${Subtotal}"; } }

        /// <summary>
        /// Tax but labeled
        /// </summary>
        public string TextForTax { get { return $"Tax: ${Tax}"; } }

        /// <summary>
        /// Total but labeled
        /// </summary>
        public string TextForTotal { get { return $"Total: ${Total}"; } }

    }
}
