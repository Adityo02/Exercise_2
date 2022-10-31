using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(int[] numbers, int left, int mid, int right)
        {
            //deklarasi array int dengan ukuran 60
            int[] adityo = new int[60];

            //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
            int AP, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            //menrima angka untuk menentukan banyaknya data yang disimpan pada array
            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    adityo[pos++] = numbers[left++];
                else
                    adityo[pos++] = numbers[mid++];
            }

            //pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
            while (left <= eol)
                adityo[pos++] = numbers[left++];
            while (mid <= right)
                adityo[pos++] = numbers[mid++];
        }
    }
}
