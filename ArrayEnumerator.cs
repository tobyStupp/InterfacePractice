using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePracices
{
    class AdaptedArray : IMyEnumerator
    {
        private ArrayMenu myMenu;
        private int currentItem;
        public AdaptedArray (ArrayMenu menu)
        {
            this.myMenu = menu;
            this.currentItem = 0;
        }

        public bool HasNext()
        {
            return currentItem < myMenu.GetSize();
        }

        public object Next()
        {
            return myMenu.GetItem(currentItem++);
        }
    }
}
