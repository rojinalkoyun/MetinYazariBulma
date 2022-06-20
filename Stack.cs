using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Stack
    {
        //Bağlı listenin node ile gerçekleştirilmesinde yararlandığım kaynak.
        //https://www.geeksforgeeks.org/implement-a-stack-using-singly-linked-list/ 

        public Node top = null;
        public int Size = 0;
        public void Push(object item)
        {
            Node temp = new Node(item);
            if (top == null)
            {
                temp.next = null;
                
            }
            else
            {
                temp.next = top;
            }
            top = temp;
            Size++;
        }
        public object Pop()
        {
            Node temp;
            if (top == null)
            {
                return null;

            }
            temp = top;
            top = top.next;
            Size--;
            return temp.data;
        }
        public object Peek()
        {
            if (top == null)
            {
                return null;

            }
            return top.data;
        }
        
        public bool IsEmpty()
        {
            return Size == 0 ? true : false;
        }



    }
}
