using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_inheritance.multilevel_inheritance
{
    // Super Class
    internal class Order
    {
        protected int orderId;
        protected string orderDate;

        public Order(int orderId, string orderDate)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order ID    : " + orderId);
            Console.WriteLine("Order Date  : " + orderDate);
        }
    }

    // Subclass (Level 1)
    internal class ShippedOrder : Order
    {
        protected string trackingNumber;

        public ShippedOrder(int orderId, string orderDate, string trackingNumber)
            : base(orderId, orderDate)
        {
            this.trackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }

        public void DisplayShippedDetails()
        {
            DisplayOrderDetails();
            Console.WriteLine("Tracking No : " + trackingNumber);
        }
    }

    // Subclass (Level 2)
    internal class DeliveredOrder : ShippedOrder
    {
        private string deliveryDate;

        public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            this.deliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }

        public void DisplayDeliveredDetails()
        {
            DisplayShippedDetails();
            Console.WriteLine("Delivery Date : " + deliveryDate);
        }
    }

    class OnlineRetailSystem
    {
        public static void Main(string[] args)
        {
            DeliveredOrder order1 = new DeliveredOrder(
                1001,
                "01-01-2026",
                "TRK12345",
                "03-01-2026"
            );

            Console.WriteLine("Order Details:");
            order1.DisplayDeliveredDetails();
            Console.WriteLine("Order Status : " + order1.GetOrderStatus());
        }
    }
}
