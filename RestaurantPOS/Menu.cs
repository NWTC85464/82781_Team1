using System;

public class Menu
{
    private String menuName;
    public List<MenuItems> menuList;


    public Menu(String _menuName)
	{
        MenuName = _menuName;
	}

    public string MenuName { get => menuName; set => menuName = value; }

}
