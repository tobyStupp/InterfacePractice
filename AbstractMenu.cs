using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePracices
{
   abstract class AbstractMenu
    {
       public void PrintMenu()
        {
            IMyEnumerator emu = GetMenuEnumerator();
            while (emu.HasNext())
               
                Console.WriteLine(((MenuItem)emu.Next()).ToString());
            }
      

        public MenuItem FindItem(string name)
        {
            IMyEnumerator emu = GetMenuEnumerator();
            while (emu.HasNext())
            {
                MenuItem menuItem =(MenuItem) emu.Next();
                if (menuItem.GetName() == name)
                    return menuItem;
            }
            return null;

        }

        public abstract IMyEnumerator GetMenuEnumerator();
    }
}
