using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Shop
    {
        List<Order> Orders = new List<Order>();
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            double sum = 0;
            int count = 0;
            double avg = 0;
            foreach (var order in Orders)
            {
                sum += order.Price;
                count++;
            }
            if (count >0)
            {
                avg = sum / count;
            }
            
            return avg;
        }
        public double GetOrdersAvgByTime(DateTime dateTime )
        {
            double sum = 0;
            int count = 0;
            double avg = 0;
            foreach (var ord in Orders)
            {
                if (ord.CreatedAt>dateTime)
                {
                    count++;
                    sum += ord.Price;
                }
                if (count>0)
                {
                    avg=sum/count;
                }
            }
            return avg;
        }
        public void RemoveOrderByNo(int no)
        {
            foreach (var order in Orders)
            {
                if (Orders.Exists(order=>order.No==no))
                {
                    Orders.Remove(Orders.Find(order => order.No == no));
                }
            }
        }

        public List<Order> FilterOrderByPrice(double minPrice,double maxPrice)
        {
            List<Order> newList = new List<Order>();
            foreach (var order in Orders)
            {
                if (order.Price>=minPrice &order.Price<=maxPrice)
                {
                    newList.Add(order);
                }
            }
            return newList;
        }
    }
}
