using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InitArray
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];
            Fill(arr, n);

            Console.WriteLine("Сумма элементов массива: {0}",Sum(arr));
            Console.WriteLine("Среднее арифметическое элементов массива: {0}", Average(arr));
            Console.WriteLine("Сумма положительных элементов массива: {0}", Sum(arr, true));
            Console.WriteLine("Сумма отрицательных элементов массива: {0}", Sum(arr, false));
            Console.WriteLine("Сумма элементов массива с четными номерами: {0}", NumberSum(arr, true));
            Console.WriteLine("Сумма элементов массива с нечетными номерами: {0}", NumberSum(arr, false));
            Console.WriteLine("Индекс минимального элемента массива: {0}", Min(arr));
            Console.WriteLine("Индекс максимального элемента массива: {0}", Max(arr));
            Console.WriteLine("Произведение элементов массива, находящихся между min и max: {0}", MultyBetweenMinMax(arr));

        }
        
        private static double MultyBetweenMinMax(double[] arr)
        {
            int index1 = Min(arr);
            int index2 = Max(arr);
            int temp;
            double ans = 1;

            if (index2 < index1)
            {
                temp = index2;
                index2 = index1;
                index1 = temp;
            }

            if (index2 - index1 == 1)
                ans = 0;

            for (int i = index1 + 1; i < index2; i++)
            {
                ans *= arr[i];
            }

            return ans;
        }

        private static int Min(double[] arr)
        {
            double min = double.MaxValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }

            return index;
        }

        private static int Max(double[] arr)
        {
            double max = double.MinValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }

            return index;
        }

        private static double NumberSum(double[] arr, bool even)
        {
            double sum = 0;
            int i;
            if (even)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }

            for (; i < arr.Length; i += 2)
            {
                sum += arr[i];
            }

            return sum;
        }

        private static double Average(double[] arr)
        {
            double average;
            average = Sum(arr) / arr.Length;
            return average;
        }


        private static double Sum(double[] arr)
        {
            double sum = 0;
            foreach (double number in arr)
            {
                sum += number;
            }
            return sum;
        }

        private static double Sum(double[] arr, bool positive)
        {
            double sum = 0;
            if (positive)
            {
                foreach (double element in arr)
                {
                    if (element > 0)
                    {
                        sum += element;
                    }
                }
            }
            else
            {
                foreach (double element in arr)
                {
                    if (element < 0)
                    {
                        sum += element;
                    }
                }
            }
            return sum;
        }

        private static void Fill(double[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
