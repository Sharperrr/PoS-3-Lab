using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormUI
{
    public partial class CreateOrderForm : Form
    {
        List<ItemModel> items = new List<ItemModel>();
        static List<OrderItemModel> orderItems = new List<OrderItemModel>();
        static OrderModel order = new OrderModel(orderItems);
        List<DiscountModel> discounts = new List<DiscountModel>();
        PaymentModel payment = new PaymentModel(order.Id);

        public CreateOrderForm()
        {
            InitializeComponent();

            addItemsPanel.Visible = true;
            discountsTipsPanel.Visible = false;
            orderReceiptPanel.Visible = false;

            LoadItemList();
            LoadOrderItemList();
            LoadSubtotalText();
        }

        private void LoadItemList()
        {
            items = SqliteDataAccess.LoadItems();

            WireUpItemList();
        }

        private void WireUpItemList()
        {
            fullItemList.DataSource = null;
            fullItemList.DataSource = items;
            fullItemList.DisplayMember = "FullDescription";
        }

        private void LoadOrderItemList()
        {
            WireUpOrderItemList();
        }

        private void WireUpOrderItemList()
        {
            orderItemList.DataSource = null;
            orderItemList.DataSource = orderItems;
            orderItemList.DisplayMember = "FullDescription";
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            OrderItemModel oItem = new OrderItemModel();

            ItemModel selectedItem = (ItemModel)fullItemList.SelectedItem;

            oItem.Id = selectedItem.Id;
            oItem.Name = selectedItem.Name;
            oItem.Quantity = (int)quantityPicker.Value;
            oItem.Price_Amount = selectedItem.Price_Amount * oItem.Quantity;
            oItem.Price_Currency = ItemModel.CurrencyType.EUR;

            orderItems.Add(oItem);
            LoadOrderItemList();
            UpdateSubtotal(oItem.Price_Amount, SubtotalUpdates.ADD);
        }


        private void removeItemButton_Click(object sender, EventArgs e)
        {
            OrderItemModel oItem = (OrderItemModel)orderItemList.SelectedItem;
            UpdateSubtotal(oItem.Price_Amount, SubtotalUpdates.SUBTRACT);
            orderItems.RemoveAt(orderItemList.SelectedIndex);
            LoadOrderItemList();
        }

        private void LoadSubtotalText()
        {
            subtotalPriceText.Text = order.subtotal.ToString() + "EUR";
            subtotalPriceText.ReadOnly = true;
            subtotalPriceText2.Text = order.subtotal.ToString() + "EUR";
            subtotalPriceText2.ReadOnly = true;
            //subtotalPriceText.Enabled = false;
        }

        private enum SubtotalUpdates
        {
            ADD,
            SUBTRACT,
            DISCOUNT
        }
        private void UpdateSubtotal(decimal amount, SubtotalUpdates action)
        {
            if (action == SubtotalUpdates.ADD)
            {
                order.subtotal += amount;
                LoadSubtotalText();
            }
            else if (action == SubtotalUpdates.SUBTRACT)
            {
                order.subtotal -= amount;
                LoadSubtotalText();
            }
            else if (action == SubtotalUpdates.DISCOUNT)
            {
                order.subtotal -= payment.order_price * (amount/100);
                if(order.subtotal < 0)
                {
                    order.subtotal = 0;
                }
                payment.discount += payment.order_price * (amount/100);
                LoadSubtotalText();
            }
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            payment.order_price = order.subtotal;

            addItemsPanel.Visible = false;
            discountsTipsPanel.Visible = true;

            LoadDiscountList();
        }

        private void LoadDiscountList()
        {
            discounts = SqliteDataAccess.LoadDiscounts();

            WireUpDiscountList();
        }

        private void WireUpDiscountList()
        {
            discountList.DataSource = null;
            discountList.DataSource = discounts;
            discountList.DisplayMember = "display";
        }

        private void applyDiscountButton_Click(object sender, EventArgs e)
        {
            DiscountModel d = (DiscountModel) discountList.SelectedItem;
            decimal amount = Convert.ToDecimal(d.percentage);
            UpdateSubtotal(amount, SubtotalUpdates.DISCOUNT);
        }

        private void applyTipButton_Click(object sender, EventArgs e)
        {
            decimal tip = decimal.Parse(tipAmountInputText.Text);
            payment.tip += tip;
            UpdateSubtotal(tip, SubtotalUpdates.ADD);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            discountsTipsPanel.Visible = false;
            orderReceiptPanel.Visible = true;

            LoadReceipt();
        }

        private void LoadReceipt()
        {
            orderItemsListReceipt.DataSource = null;
            orderItemsListReceipt.DataSource = orderItems;
            orderItemsListReceipt.DisplayMember = "FullDescription";

            totalPriceList.Text = payment.detailedInfo;

            decimal totalPrice = payment.order_price - payment.discount + payment.tip;
            totalPriceText.Text = totalPrice.ToString() + "EUR";
            totalPriceText.ReadOnly = true;
        }
    }
}
