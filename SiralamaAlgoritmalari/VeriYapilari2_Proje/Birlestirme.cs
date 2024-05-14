using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2_Proje
{
    public class Birlestirme
    {
        public void MergeSort<T>(T[] ary, int left, int right) where T : IComparable
        {
            // 4 2 7 8 9 0 3
            if (left < right)
            {
                int middle = left + ((right - left) / 2);
                MergeSort(ary, left, middle); // 4 2 7 8
                MergeSort(ary, middle + 1, right); // 9 0 3

                Merge(ary, left, middle, right);
            }
        }
        static void Merge<T>(T[] ary, int left, int middle, int right) where T : IComparable
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            T[] leftAry = new T[n1];
            T[] rightAry = new T[n2];
            Array.Copy(ary, left, leftAry, 0, n1);
            Array.Copy(ary, middle + 1, rightAry, 0, n2);

            int leftIndex = 0, rightIndex = 0;
            int k = left;
            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftAry[leftIndex].CompareTo(rightAry[rightIndex]) <= 0)
                {
                    ary[k] = leftAry[leftIndex];
                    leftIndex++;

                }
                else
                {
                    ary[k] = rightAry[rightIndex];
                    rightIndex++;
                }
                k++;
            }
            while (leftIndex < n1)
            {
                ary[k] = leftAry[leftIndex];
                leftIndex++;
                k++;
            }
            while (rightIndex < n2)
            {
                ary[k] = rightAry[rightIndex];

                rightIndex++;
                k++;
            }
        }
    }
}
