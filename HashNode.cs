using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class HashNode
    {
        public int anahtar;
        public Kelime deger;
        public HashNode next;
        public HashNode(int key, Kelime data)
        {
            this.anahtar = key;
            this.deger = data;
            next = null;
        }
        public HashNode()
        {
            next = null;
        }

    }
}
