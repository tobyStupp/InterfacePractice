using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace interfacePracices
{
    class NodeMenu:AbstractMenu
    {
        private Node<MenuItem> menu;
        private Node<MenuItem> end;
        public NodeMenu ()
        { 
            menu = null;
            end = null;
        }
        public NodeMenu (Node<MenuItem> m)
        {
            this.menu = m;
            while (m.GetNext() != null)
                m = m.GetNext();
            end = m;
        }
        public void Add (MenuItem item)
        {
            if (menu==null)
            {
                menu = new Node<MenuItem>(item);
                end = menu;
            }
            else
            {
                end.SetNext(new Node<MenuItem>(item));
                end = end.GetNext();
            }
        }
        public Node<MenuItem> GetFirstItem() => menu;

        public override IMyEnumerator GetMenuEnumerator()
        {
            return new AdapterNode(this);
        }
    }
}
