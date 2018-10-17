using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class OrderItem
    {
        public int Quantity;
        public MenuItem MenuItem;

        public OrderItem(int _quantity, MenuItem _menuItem)
        {
            Quantity = _quantity;
            MenuItem = _menuItem;
        }
        
    }
}
