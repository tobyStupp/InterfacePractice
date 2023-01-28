using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace interfacePracices
{
    class AdapterNode :IMyEnumerator
    {
        private Node<MenuItem>  menu;
        public AdapterNode (NodeMenu menu)
        {
            this.menu = menu.GetFirstItem();
        }

        public bool HasNext()
        {
            return this.menu != null;
        }

        public object Next()
        {
            MenuItem mi = this.menu.GetValue();
            this.menu = this.menu.GetNext();
            return mi;
        }
    }
}
