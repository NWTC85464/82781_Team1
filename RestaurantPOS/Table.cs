using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Table
    {
        private int tableNumber;
        private int numberOfGuests;
        public List<Order> TableOrders;
        public Boolean isActive = false;

        public int TableNumber { get => tableNumber; set => tableNumber = value; }
        public int NumberOfGuests { get => numberOfGuests; set => numberOfGuests = value; }

        public Table(int _tableNumber, int _numberOfGuests)
        {
            TableNumber = _tableNumber;
            NumberOfGuests = _numberOfGuests;
            TableOrders = new List<Order>();
        }
    }
}
