﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.cs
{
        internal class Order
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public int Quantity { get; set; }

        }
        internal class item
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        public static void Main()
        {
            List<Order> orders = new List<Order>()
        {

            new Order(){Id = 1,Name = "madhu", Date = new DateTime(2003,12,23),Quantity = 5},
            new Order(){Id = 2,Name = "vasu", Date = new DateTime(2024,1,3),Quantity = 15},
            new Order(){Id = 3,Name = "akhil", Date = new DateTime(2009,6,17),Quantity = 52},
            new Order(){Id = 4,Name = "sandeep", Date = new DateTime(2010,8,9),Quantity = 15},
            new Order(){Id = 5,Name = "Sudheer", Date = new DateTime(2006,2,5),Quantity = 24},
            new Order(){Id = 6,Name = "prudvi", Date = new DateTime(1996,6,29),Quantity = 35},
            new Order(){Id = 7,Name = "Rohith", Date = new DateTime(1999,10,15),Quantity = 28},
            new Order(){Id = 8,Name = "radika", Date = new DateTime(2000,11,21),Quantity = 52},
            new Order(){Id = 9,Name = "Satya", Date = new DateTime(2015,3,26),Quantity = 12},
            new Order(){Id = 10,Name = "raju", Date = new DateTime(2008,12,21),Quantity =10},
            new Order(){Id = 11,Name = "ravi", Date = new DateTime(2023,1,6),Quantity = 19},
        };
            List<item> it = new List<item>()
            {
                new item(){Name = "Pen", Price = 5},
                new item(){Name = "Pencil", Price = 5},
                new item(){Name = "sketch", Price = 5},
                new item(){Name = "Box", Price = 5},
                new item(){Name = "Bag", Price = 5},

            };
            var a = from i in orders
                    from j in it
                    orderby i.Date.Month descending
                    let k = i.Quantity * j.Price
                    select new { Id = i.Id, Name = j.Name, Date = i.Date, k };
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
