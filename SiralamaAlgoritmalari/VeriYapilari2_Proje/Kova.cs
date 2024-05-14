using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2_Proje
{
    public class Kova
    {
        public void BucketSort<T>(T[] ary) where T : IComparable<T>
        {
            int n = ary.Length;

            List<T>[] buckets = new List<T>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<T>();
            }

            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (int)Math.Floor(Convert.ToDouble(n * Convert.ToDouble(ary[i].GetHashCode() / (double)int.MaxValue)));
                buckets[bucketIndex].Add(ary[i]);
            }

            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    ary[index++] = buckets[i][j];
                }
            }
        }
    }
}
