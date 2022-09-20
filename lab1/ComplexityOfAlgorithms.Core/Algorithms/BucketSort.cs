using BenchmarkDotNet.Disassemblers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

namespace lab1.Algorithms
{
    public class BucketSort : ILogic
    {
        public void Execute()
        {
            Console.WriteLine("Введите максимальную длину массива");
            int maxLength = int.Parse(Console.ReadLine());
            for (int i = 1; i<=5; i++)
            {
                string path = $"..//..//..//results/III/QuickRecursiveSort_{i}.txt";
                StreamWriter f = new StreamWriter(path);
                for (int j = 1; j <= maxLength; j += 5000)
                {
                    var v = VectorGeneration.GetNewVector(j, 1, 1000);
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    BucketSort.Sort(v);
                    stopwatch.Stop();

                    TimeSpan ts = stopwatch.Elapsed;
                    f.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
                }
                f.Close();
            }
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Файлы успешно созданы");
        }

        /// <summary>
        /// Блочная сортирвока. 
        /// </summary>
        /// <param name="a">Принимает массив чисел.</param>
        public static void Sort(int[] a)
        {
            // Примем, что количество корзин равно количеству элементов в массиве-источнике.
            // Тогда:
            // массив корзин
            List<int>[] aux = new List<int>[a.Length];

            // каждую корзину проинициализировать
            for (int i = 0; i < aux.Length; ++i)
                aux[i] = new List<int>();

            // найти диапазон значений в массиве-источнике
            int minValue = a[0];
            int maxValue = a[0];

            for (int i = 1; i < a.Length; ++i)
            {
                if (a[i] < minValue)
                    minValue = a[i];
                else if (a[i] > maxValue)
                    maxValue = a[i];
            }

            // эта величина будет использоваться a.Length раз, поэтому имеет смысл её сохранить.
            double numRange = maxValue - minValue;

            for (int i = 0; i < a.Length; ++i)
            {
                // вычисление индекса корзины
                int bcktIdx = (int)Math.Floor((a[i] - minValue) / numRange * (aux.Length - 1));

                // добавление элемента в соответствующую корзину
                aux[bcktIdx].Add(a[i]);
            }

            // сортировка корзин. Здесь я, для упрощения себе писанины, использую библиотечную сортировку
            for (int i = 0; i < aux.Length; ++i)
                aux[i].Sort();

            // собираем отсортированные элементы обратно в массив-источник
            int idx = 0;

            for (int i = 0; i < aux.Length; ++i)
            {
                for (int j = 0; j < aux[i].Count; ++j)
                    a[idx++] = aux[i][j];
            }
        }


    }
}
