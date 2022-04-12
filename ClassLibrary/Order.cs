using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Order
    {
        public Order()
        {
            _totalcount++;
            No = _totalcount;
        }
        static int _totalcount;
        public int No { get; set; }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Price { get; set; }

    }
}
