using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void MainMerge(int[] numbers, int left, int mid, int right)
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

            // for n - 1 passes
            for (AP = 0; AP < num; AP++)
            {
                numbers[right] = adityo[right];
                right--;
            }
        }

        //fungsi / method untuk menerima masukan
        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }

        static void Main(string[] args)
        {
            // Pengguna memasukkan elemen pada array 
            Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];

            //mengisi element selanjutnya
            for (int AP = 0; AP < max; AP++)
            {
                Console.Write("\nEnter [" + (AP + 1).ToString() + "] element: ");
                numbers[AP] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
