using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArpineAmiryan
{
    internal class SortingAlgorithms
    {
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);
                Mergearr(arr, left, middle, right);
            }
        }

        private static void Mergearr(int[] arr, int left, int middle, int right)
        {
            int[] temp = new int[arr.Length];
            for (int i = left; i <= right; i++)
            {
                temp[i] = arr[i];
            }
            int j = left;
            int k = middle + 1;
            int l = left;
            while (j <= middle && k <= right)
            {


                if (temp[j] <= temp[k])
                {
                    arr[l] = temp[j];
                    j++;
                }
                else
                {
                    arr[l] = temp[k];
                    k++;
                }
                l++;
            }
            while (j <= middle)
            {
                arr[l] = temp[j];
                l++;
                j++;
            }
            while (k <= right)
            {
                arr[l] = temp[k];
                l++;
                k++;
            }
        }
    }
}
