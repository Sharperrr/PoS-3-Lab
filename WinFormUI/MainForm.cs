using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderScreen = new CreateOrderForm();
            createOrderScreen.Show();
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
