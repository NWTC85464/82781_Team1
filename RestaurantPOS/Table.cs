using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Table
    {
        public int TableNumber;
        public int NumberOfGuests;
        public List<OrderItem> TableOrders;

        public Table(int _tableNumber, int _numberOfGuests)
        {
            TableNumber = _tableNumber;
            NumberOfGuests = _numberOfGuests;
        }
    }
}
