using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    public class ArrayAlgorithms
    {
        // Problem : Merge two sorted arrays into one single sorted array.
        public int[] Merge(int[] a, int[] b)
        {
            int totCount = a.Length + b.Length;
            int[] c = new int[totCount];
            int count = 0;
            if(a.Length==0 && b.Length>0)
            {
                return b;
            }
            else if(a.Length > 0 && b.Length == 0)
            {
                return a;
            }
            else if(a.Length == 0 && b.Length == 0)
            {
                return new int[] { };
            }
            else
            {
                int a_index = 0;
                int b_index = 0;
                int a_current = a[a_index];
                int b_current = b[b_index];
                while (count < totCount)
                {
                    if(a_current < b_current)
                    {
                        c[count] = a[a_index];
                        a_current = (a_index == a.Length - 1) ? int.MaxValue : a[++a_index];
                    }
                    else
                    {
                        c[count] = b[b_index];
                        b_current = (b_index == b.Length - 1) ? int.MaxValue : b[++b_index];
                    }
                    count++;
                }
                return c;
            }
        }
    }
}
