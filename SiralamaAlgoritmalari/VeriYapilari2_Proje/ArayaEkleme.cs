using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2_Proje
{
    public class ArayaEkleme
    {
        public void InsertionSort<T>(T[] ary) where T : IComparable<T>
        {
            for (int i = 1; i < ary.Length; i++)
            {
                T key = ary[i];
                int j = i - 1;
                while (j >= 0 && ary[j].CompareTo(key) > 0)
                {
                    (ary[j + 1]) = (ary[j]);
                    j--;
                }
                 (ary[j + 1]) = (key);

            }
        }
    }
}
