using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2_Proje
{
    public class KabarcikAlgoritmasi
    {
        public void BubbleSort<T>(T[] ary) where T : IComparable<T>
        {
            for (int i = 0; i < ary.Length; i++)
            {
                for (int j = 0; j < ary.Length - i - 1; j++)
                {
                    if (ary[j].CompareTo(ary[j + 1]) > 0)
                    {
                        (ary[j], ary[j + 1]) = (ary[j + 1], ary[j]);
                    }
                }
            }
          
        }
    }
}
