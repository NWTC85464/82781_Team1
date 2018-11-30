using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Order
    {
        private int orderNumber;
        private int tableNumber;
        private Boolean isComplete;
        // ERROR List<OrderItem> orderItems;

        public Order(int _orderNumber, int _tableNumber)
        {
            OrderNumber = _orderNumber;
            TableNumber = _tableNumber;
           // ERROR orderItems = new List<OrderItem>();
            IsComplete = false;
        }

        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        public int TableNumber { get => tableNumber; set => tableNumber = value; }
        public bool IsComplete { get => isComplete; set => isComplete = value; }
    }
}
