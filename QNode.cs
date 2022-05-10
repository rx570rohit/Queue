using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class QNode
    {
        public int key;
        public QNode next;

        // constructor to create
        // a new linked list node
        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
