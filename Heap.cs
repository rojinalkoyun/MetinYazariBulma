using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Heap
    {
        //Heap yapısı oluşturmak için yararlandığım kaynak.
        //https://www.geeksforgeeks.org/binary-heap/
        public HeapDugum[] heapArray = new HeapDugum[50];
        public int currentSize;
        
        public string DisplayHeap()
        {

            string temp = ("Heap İçindeki Elemanlar: \n");
            for (int m = 0; m < currentSize; m++)
            {
                if (heapArray[m] != null)
                    temp += (heapArray[m].kelime.orjinalBicim + "\n ");
                else
                    temp += ("--");
            }
            Console.WriteLine();
           
            
            return temp;
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Kelime kelime)
        {
            HeapDugum newHeapDugumu = new HeapDugum(kelime);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugum bottom = heapArray[index];
            while (index > 0 && heapArray[parent].kelime.kullanımSıklığı < bottom.kelime.kullanımSıklığı)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugum RemoveMax() // Remove maximum value HeapDugumu
        {
            HeapDugum root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugum top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].kelime.kullanımSıklığı <
                heapArray[rightChild].kelime.kullanımSıklığı)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.kelime.kullanımSıklığı >= heapArray[largerChild].kelime.kullanımSıklığı)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        //10.Hafta DersSunumundan yararlanılmıştır.
        public Kelime[] Sort(Kelime[] dizi)
        {
           
            Heap h = new Heap();
            Kelime[] sorted = new Kelime[dizi.Length];
            foreach (var item in dizi)
                h.Insert(item);
            int i = 0;
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax().kelime;
            return sorted;
        }
    }
}
