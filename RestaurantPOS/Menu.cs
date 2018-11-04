using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Menu
{
    private String menuName;
    public List<MenuItem> menuList;


    public Menu(String _menuName)
	{
        MenuName = _menuName;
        menuList = new List<MenuItem>();
	}

    public string MenuName { get => menuName; set => menuName = value; }

}
