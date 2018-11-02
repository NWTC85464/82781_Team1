using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class OrderItem
    {
        private int quantity;
        private MenuItem menuItem;
        private int tableNumber;
        public DateTime timeOrdered;

        public OrderItem(int _quantity, MenuItem _menuItem, int _tableNumber)
        {
            TableNumber = _tableNumber;
            Quantity = _quantity;
            MenuItem = _menuItem;
            // Since the OrderItem is created when the order is placed, we set the time when we create it
            timeOrdered = System.DateTime.Now();
        }

        public int Quantity { get => quantity; set => quantity = value; }
        internal MenuItem MenuItem { get => menuItem; set => menuItem = value; }
        public int TableNumber { get => tableNumber; set => tableNumber = value; }
    }
}
