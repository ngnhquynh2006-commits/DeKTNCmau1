using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TimGTLN
    {
        public int TimGiaTriLonNhat(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new Exception("Mảng không được rỗng");
            }

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
