using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Linq_Assignment.Question_3;

namespace Linq_Assignment
{
    internal class Question_3
    {
        public class Order
        {
            public int OrderId { get; set; }
            public string ItemName { get; set; }
            public DateTime OrderDate { get; set; }
            public int Quantity { get; set; }

            public Order(int orderId, string itemName, DateTime orderDate, int quantity)
            {
                OrderId = orderId;
                ItemName = itemName;
                OrderDate = orderDate;
                Quantity = quantity;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
               
                List<Order> orders = new List<Order>
        {
            new Order(1, "Grapes", DateTime.Now.AddDays(-5), 10),
            new Order(2, "Guva", DateTime.Now.AddDays(-3), 20),
            new Order(3, "Banana", DateTime.Now, 15),
            new Order(4, "Date", DateTime.Now.AddDays(-7), 25)
        };

               
                var sortedOrders = orders.OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.Quantity);

                
                foreach (var order in sortedOrders)
                {
                    Console.WriteLine($"Order ID: {order.OrderId}, Item Name: {order.ItemName}, Date: {order.OrderDate.ToShortDateString()}, Quantity: {order.Quantity}");
                }
            }
        }


    }
}
