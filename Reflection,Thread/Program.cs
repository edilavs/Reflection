
using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Reflection_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> Orders = new List<Order>();
            Order ord1 = new Order();
            ord1.ProductCount = 25;
            DateTime dateTime = new DateTime(2022, 3, 15);
            ord1.CreatedAt = dateTime;
            ord1.Price = 5;


            Order ord2 = new Order();
            ord1.ProductCount = 22;
            DateTime dateTime2 = new DateTime(2022, 3, 18);
            ord2.CreatedAt = dateTime2;
            ord2.Price =5;


            Order ord3 = new Order();
            ord3.ProductCount = 25;
            DateTime dateTime3= new DateTime(2022, 4, 15);
            ord3.CreatedAt = dateTime3;
            ord3.Price = 2;

            Shop shop = new Shop();
            shop.AddOrder(ord1);
            shop.AddOrder(ord2);
            shop.AddOrder(ord3);

            foreach (var item in shop.FilterOrderByPrice(1,4))
            {
                Console.WriteLine(item.No);
            }


            Console.WriteLine(shop.GetOrdersAvg());
            
        }
    }
}
