using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DemoLibrary.ItemModel;

namespace DemoLibrary.Models
{
    public class OrderItemModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price_Amount { get; set; }
        public CurrencyType Price_Currency { get; set; }

        public string FullDescription => $"{Quantity}x{Name} {Price_Amount}EUR";
    }
}
