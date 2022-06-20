using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class HashMap
    {
        //Ayrık zincirleme hash yapısı yararlandığım kaynak.
        //https://simpledevcode.wordpress.com/2015/07/07/hash-tables-tutorial-c-c-java/
        const int size = 30;
        public HashNode[] table;
        public HashMap(int size)
        {
            this.table = new HashNode[size];

        }
        public HashMap()
        {
            table = new HashNode[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }
        public void insert(int key, Kelime data)
        {
            key = Convert.ToInt32(data.kacıncıKelime.ToString() + data.kacıncıCümle.ToString());
            HashNode nObj = new HashNode(key, data);
            int hash = key % size;
            if (table[hash] == null)
            {

                nObj.next = null;
                table[hash] = nObj;
            }
            else
            {

                HashNode temp = table[hash];
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = nObj;
                nObj.next = null;
            }
        }
        public Kelime retrieve(int key)
        {
            int hash = key % size;
            if (table[hash] == null)
            {
                return null;
            }
            else
            {
                if (key == table[hash].anahtar)
                {
                    return table[hash].deger;
                }
                else
                {
                    while (key != table[hash].anahtar)
                    {
                        if (table[hash].next != null)
                            table[hash] = table[hash].next;
                        else
                            return null;
                    }
                    return table[hash].deger;
                }
            }


        }
        public void remove(int key)
        {
            int hash = key % size;
            while (table[hash] != null && table[hash].anahtar % size != key % size)
            {
                hash = (hash + 1) % size;
            }
            //a current node pointer used for traversal, currently points to the head
            HashNode current = table[hash];
            bool isRemoved = false;
            while (current != null)
            {
                if (current.anahtar == key)
                {
                    table[hash] = current.next;
                    Console.WriteLine("entry removed successfully!");
                    isRemoved = true;
                    break;
                }

                if (current.next != null)
                {
                    if (current.next.anahtar == key)
                    {
                        HashNode newNext = current.next.next;
                        current.next = (newNext);
                        Console.WriteLine("entry removed successfully!");
                        isRemoved = true;
                        break;
                    }
                    else
                    {
                        current = current.next;
                    }
                }

            }

            if (!isRemoved)
            {
                Console.WriteLine("nothing found to delete!");
                return;
            }
        }
        public string print()
        {
            string temp = "";
            HashNode current = new HashNode();
            for (int i = 0; i < size; i++)
            {
                current = table[i];
                while (current != null)
                {
                    temp +=(current.deger.orjinalBicim + " \n");
                    current = current.next;
                }
                Console.WriteLine();
            }
            return temp;
        }
    }
}
