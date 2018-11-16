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
        private string itemName;
        private double itemPrice;
        public Boolean isItemActive;

        public MenuItem(int _menuItemId, string _itemName, double _itemPrice)
        {
            MenuItemID = _menuItemId;
            ItemName = _itemName;
            ItemPrice = _itemPrice;
            isItemActive = true;
        }

        public int MenuItemID { get => menuItemID; set => menuItemID = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public double ItemPrice { get => itemPrice; set => itemPrice = value; }
    }
}
