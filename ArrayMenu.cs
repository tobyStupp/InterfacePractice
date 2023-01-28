using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePracices
{
    class ArrayMenu:AbstractMenu
    {
        private MenuItem[] items;
        private int count;
        public ArrayMenu (int itemCount)
        {
            items = new MenuItem[itemCount];
        }
        public ArrayMenu (MenuItem[] items)
        {
            this.items = items;
            this.count = items.Length;
        }
        public int GetSize() => count;
        public MenuItem GetItem(int id) => items[id];

        public override IMyEnumerator GetMenuEnumerator()
        {
            return new AdaptedArray(this);
        }
    }
}
