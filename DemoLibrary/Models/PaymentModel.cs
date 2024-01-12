using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class PaymentModel
    {
        private const decimal TAX = 0.21m;
        public int id { get; set; }
        public int transactionId { get; set; }
        public int orderId { get; set; }

        //Vietoj amount įvedžiau order_price, discount ir tip laukus,
        //kad galėčiau pateikti detalų mokėjimo aprašymą čekyje
        //(amount bus apskaičiuojama iš šių trijų reikšmių)
        public decimal order_price { get; set; }
        public decimal discount { get; set; }
        public decimal tip { get; set; }

        public enum PaymentMethod
        {
            CASH,
            CARD,
            COUPON
        }

        public PaymentMethod method { get; set; }

        public PaymentModel(int id)
        {
            orderId = id;
            order_price = 0;
            discount = 0;
            tip = 0;
            method = PaymentMethod.CASH;
        }

        public string detailedInfo => $"Order price {order_price-order_price*TAX} EUR{Environment.NewLine}" +
            $"Tax +{order_price-order_price*(1-TAX)} EUR{Environment.NewLine}" +
            $"Discount -{discount} EUR{Environment.NewLine}" +
            $"Tip +{tip} EUR";
    }
}
