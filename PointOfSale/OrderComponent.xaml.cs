/*
 * Author: Justin Kingry
 * Class name: OrderComponet.xaml.cs
 * Purpose: Code behind OrderComponent.xaml
 */


using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.ItemCustomization;
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

        private MainWindow Mw
        {
            get
            {
                DependencyObject parent = this;
                do
                {
                    // Get this node's parent
                    parent = LogicalTreeHelper.GetParent(parent);
                }
                // Invariant: there is a parent element, and it is not a ListSwitcher 
                while (!(parent is null || parent is MainWindow));
                return parent as MainWindow;
            }
        }

        /// <summary>
        /// goes back to the page to change the item details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickChange(object sender, RoutedEventArgs e)
        {
            //if (DataContext is OrderLogic orderLogic)
            //{
                if (orderDisplay.SelectedItem is IOrderItem item && item != null)
                {
                    if (item is BriarheartBurger bb)
                    {
                        CustomBriarheartBurger cbb = new CustomBriarheartBurger(bb);
                        Mw.biggestBorder.Child = cbb;
                    }
                    else if (item is AretinoAppleJuice aa)
                    {
                        CustomAretinoAppleJuice caa = new CustomAretinoAppleJuice(aa);
                        Mw.biggestBorder.Child = caa;
                    }
                    else if (item is CandlehearthCoffee chc)
                    {
                        CustomCandlehearthCoffee cchc = new CustomCandlehearthCoffee(chc);
                        Mw.biggestBorder.Child = cchc;
                    }
                    else if (item is DoubleDraugr dd)
                    {
                        CustomDoubleDraugr cdd = new CustomDoubleDraugr(dd);
                        Mw.biggestBorder.Child = cdd;
                    }
                    else if (item is DragonbornWaffleFries dbwf)
                    {
                        CustomDragonbornWaffleFries cdbwf = new CustomDragonbornWaffleFries();
                        Mw.biggestBorder.Child = cdbwf;
                    }
                    else if (item is FriedMiraak fm)
                    {
                        CustomFriedMiraak cfm = new CustomFriedMiraak(fm);
                        Mw.biggestBorder.Child = cfm;
                    }
                    else if (item is GardenOrcOmelette goo)
                    {
                        CustomGardenOrcOmelette cgoo = new CustomGardenOrcOmelette(goo);
                        Mw.biggestBorder.Child = cgoo;
                    }
                    else if (item is MadOtarGrits mog)
                    {
                        CustomMadOtarGrits cmog = new CustomMadOtarGrits(mog);
                        Mw.biggestBorder.Child = cmog;
                    }
                    else if (item is MarkarthMilk mm)
                    {
                        CustomMarkarthMilk cmm = new CustomMarkarthMilk(mm);
                        Mw.biggestBorder.Child = cmm;
                    }
                    else if (item is PhillyPoacher pp)
                    {
                        CustomPhillyPoacher cpp = new CustomPhillyPoacher(pp);
                        Mw.biggestBorder.Child = cpp;
                    }
                    else if (item is SailorSoda ss)
                    {
                        CustomSailorSoda css = new CustomSailorSoda(ss);
                        Mw.biggestBorder.Child = css;
                    }
                    else if (item is SmokehouseSkeleton shs)
                    {
                        CustomSmokehouseSkeleton cshs = new CustomSmokehouseSkeleton(shs);
                        Mw.biggestBorder.Child = cshs;
                    }
                    else if (item is ThalmorTriple tt)
                    {
                        CustomThalmorTriple ctt = new CustomThalmorTriple(tt);
                        Mw.biggestBorder.Child = ctt;
                    }
                    else if (item is VokunSalad vs)
                    {
                        CustomVokunSalad cvs = new CustomVokunSalad(vs);
                        Mw.biggestBorder.Child = cvs;
                    }
                    else if (item is WarriorWater ww)
                    {
                        CustomWarriorWater cww = new CustomWarriorWater(ww);
                        Mw.biggestBorder.Child = cww;
                    }
                }
            //}
            //else
            //{
                //throw new NotImplementedException("data context is not OrderLogic");
            //}
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
