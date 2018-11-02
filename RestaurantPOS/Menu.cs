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
	}

    public string MenuName { get => menuName; set => menuName = value; }

}
