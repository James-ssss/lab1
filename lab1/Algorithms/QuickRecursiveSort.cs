using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Algorithms
{
    public class QuickRecursiveSort
    {
        public static int[] QuickSort(int[] arr, int left, int right)
        {
            int i = left; 
            int j = right;
            int x = arr[(left + right) / 2]; // средний элемент
            do
            {
                while (arr[i] < x)
                    // поиск элемента больше среднего
                    i++;
                while (arr[j] > x)
                    // поиск элемента меньше среднего
                    j--;
                if (i <= j) // обмен элементов местами
                {
                    int tmp = arr[i]; arr[i] = arr[j];
                    arr[j] = tmp;
                    i++; j--;
                }
            }
            while (i <= j);
            if (left < j)
                QuickSort(arr, left, j);
            //обработка левого подмассива
            if (i < right)
                QuickSort(arr, i, right);
            // обработка правого подмассива
            return arr;
        }

    }
}
