using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoLibrary.Models
{
    public class DiscountModel
    {
        public int id { get; set; }
        public float percentage { get; set; }

        public string display => $"{percentage}";
    }
}
