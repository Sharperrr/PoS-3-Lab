using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public List<OrderItemModel> orderItems { get; set; } //Manau logiškiau naudoti orderItem list nei itemList, kadangi turime žinoti kiekį užsakytų item objektų

        public enum OrderStatus
        {
            DONE,
            IN_PROCESS,
            FROZEN
        }

        public OrderStatus status { get; set; }

        public decimal subtotal { get; set; } //mano nuomone pravartu turėti užsakymo kainą pačiame užsakyme, taigi pridėjau subtotal lauką

        public OrderModel(List<OrderItemModel> orderItems)
        {
            this.orderItems = orderItems;
            this.status = OrderStatus.IN_PROCESS;
            this.subtotal = 0;
        }
    }
}
