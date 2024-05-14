using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2_Proje
{
    public class Yigin
    {
        public void HeapSort<T>(T[] ary) where T : IComparable<T>
        {
            int length = ary.Length;

            // Build heap
            for (int i = (length / 2) - 1; i >= 0; i--)
            {
                Heapify(ary, length, i);
            }

            //One by one extract eleman from heap
            for (int i = length - 1; i >= 0; i--)
            {
                // swap
                (ary[i], ary[0]) = (ary[0], ary[i]);

                // heapify root element
                Heapify(ary, i, 0);
            }
        }
        static void Heapify<T>(T[] ary, int lenght, int i) where T : IComparable<T>
        {
            int largest = i;
            int left = (2 * i) + 1; // inin 0 dan degil 1 den baslaması icin +1
            int right = (2 * i) + 2; // inin 0 dan degil 1 den baslaması icin +2

            // If left child is largeer than root
            if (left < lenght && ary[left].CompareTo(ary[largest]) > 0)
            {
                largest = left;
            }

            // If right child vis larger than largest so far
            if (right < lenght && ary[right].CompareTo(ary[largest]) > 0)
            {
                largest = right;
            }

            // If largest is not root
            if (largest != i)
            {
                // swap
                (ary[largest], ary[i]) = (ary[i], ary[largest]);

                // Recursively hepiifiy the afected sub-tri
                Heapify(ary, lenght, largest);
            }

        }
    }
}
