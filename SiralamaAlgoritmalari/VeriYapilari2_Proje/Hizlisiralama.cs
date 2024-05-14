using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2_Proje
{
    public class Hizlisiralama
    {
        public void QuickSortLomuto<T>(T[] arry, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                var partitionIndex = PartitionLomuto(arry, low, high);
                QuickSortLomuto(arry, low, partitionIndex - 1);
                QuickSortLomuto(arry, partitionIndex + 1, high);
            }
        }
        public int PartitionLomuto<T>(T[] ary, int low, int high) where T : IComparable
        {
            var pivot = ary[high];
            int i = low - 1;
            for (int j = low + 1; j < high; j++)
            {
                if (ary[j].CompareTo(pivot) < 0)
                {
                    i++;
                    Swap(ary, i, j);
                }
            }
            Swap(ary, i + 1, high);
            return i + 1;
        }



        public  void QuickSortHoare<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                var partitionIndex = PartitionHoare(array, low, high);
                QuickSortHoare(array, low, partitionIndex);
                QuickSortHoare(array, partitionIndex + 1, high);
            }
        }

        public int PartitionHoare<T>(T[] arry, int low, int heigh) where T : IComparable
        {
            var pivot = arry[low];
            int i = low - 1, j = heigh + 1;
            while (true)
            {
                do
                {
                    i++;
                } while (arry[i].CompareTo(pivot) < 0);
                do
                {
                    j--;
                } while (arry[j].CompareTo(pivot) > 0);

                if (i >= j)
                {
                    return j;

                }
                Swap(arry, i, j);
            }
        }
        public static void Swap<T>(T[] arry, int i, int j)
        {
            (arry[i], arry[j]) = (arry[j], arry[i]);
        }

    }
}

