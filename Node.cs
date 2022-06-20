using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Node
    {
        public Node next { get; set; }
        public object data { get; set; }
        public Node(object data)
        {
            this.data = data;
            next = null;
        }
        public Node()
        { 
            next = null;
        }
    }
}
