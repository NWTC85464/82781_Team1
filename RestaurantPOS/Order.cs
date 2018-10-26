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

        public OrderItem(int _quantity, MenuItem _menuItem)
        {
            Quantity = _quantity;
            MenuItem = _menuItem;
        }

        public int Quantity { get => quantity; set => quantity = value; }
        internal MenuItem MenuItem { get => menuItem; set => menuItem = value; }
    }
}
