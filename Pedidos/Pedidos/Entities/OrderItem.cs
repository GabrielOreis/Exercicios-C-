using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } = new Product();

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public OrderItem()
        {
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.ToString() + ", Quantity: " + Quantity.ToString() + ",  Subtotal: $" + this.SubTotal().ToString("F2") ;
        }
    }
}
