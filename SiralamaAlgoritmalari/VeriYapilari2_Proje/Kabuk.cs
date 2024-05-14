using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2_Proje
{
    public class Kabuk
    {
        public void ShellSort<T>(T[] ary) where T : IComparable<T>
        {
            int n = ary.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    T temp = ary[i];

                    int j;
                    for (j = i; j >= gap && ary[j - gap].CompareTo(temp) > 0; j -= gap)
                    {
                        ary[j] = ary[j - gap];
                    }

                    ary[j] = temp;
                }
            }
        }
    }
}
