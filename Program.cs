using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace interfacePracices
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem[] items = { new MenuItem("Hamburger", 50.00), new MenuItem("Steak 200 Gr", 112.50), new MenuItem("Potato Chips", 22), new MenuItem("Coca Cola", 10.00) };
            AbstractMenu[] menus = new AbstractMenu[2];
            menus[0] = new ArrayMenu(items);
            NodeMenu men = new NodeMenu(new Node<MenuItem>(items[0]));
            for (int i = 1; i < items.Length; i++)
                men.Add(items[i]);
            menus[1] = men;
            menus[0].PrintMenu();
            Console.WriteLine(menus[1].FindItem("Potato Chips"));
            Console.ReadKey();

        }
    }
}
