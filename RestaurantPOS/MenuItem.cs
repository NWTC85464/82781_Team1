using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class MenuItem
    {
        private int menuItemID;
        public string itemName;
        public double itemPrice;

        public MenuItem(int _menuItemId, string _itemName, double _itemPrice)
        {
            this.menuItemID = _menuItemId;
            this.itemName = _itemName;
            this.itemPrice = _itemPrice;
        }
    }
}
