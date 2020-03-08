using System;
using System.Collections.Generic;
using System.Text;
using Pedidos.Entities.Enums;

namespace Pedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public Order()
        {

        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem) 
        {
            OrderItems.Remove(orderItem);
        }

        public double Total() 
        {
            double sum = 0.0;

            foreach (OrderItem orderItem in OrderItems) {
                sum += orderItem.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nORDER SUMMARY:");
            sb.Append("Order moment: "); sb.AppendLine(Moment.ToString());
            sb.Append("Order status: "); sb.AppendLine(Status.ToString());
            sb.Append("Client: ") ;sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items: ");
            foreach (OrderItem order in OrderItems) 
            { 
              sb.AppendLine(order.ToString());
            }
            return sb.ToString();
        }
    }
}
