using BenchmarkDotNet.Toolchains.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

namespace СomplexityOfAlgorithms.Algorithms
{
    public class RecursiveExponentiation :IExecutable
    {
        public void Execute()
        {
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Вы выбрали рекурсивный алгоритм возведения в степень.");
            List<string> outputData = new();
            outputData.Add(new string("Pow" + "\t" + "Count steps"));
            (int Pow, BigInteger Value) result = new();
            for (int i = 1; i <= 100; i += 5)
            {
                if (i == 11)
                {
                    i -= 1;
                    result = RecursiveExponentiation.Exponentiate(5, i);
                }
                else
                {
                    result = RecursiveExponentiation.Exponentiate(5, i);
                }
                outputData.Add(result.Pow + "\t" + CountSteps);
                CountSteps = 0;
            }
            File.WriteAllLines("..//..//..//results/8/8.2_result.txt", outputData);
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Файлы успешно созданы");
        }

        public static int CountSteps = 0;
        /// <summary>
        /// Рекурсивный алгоритм возведения числа в степень.
        /// </summary>
        /// <param name="value">Значение, которое возводится в степень.</param>
        /// <param name="pow">Степень, в которую нужно возвести значение.</param>
        /// <returns>Возвращается первым степень, в которую возводится число. Вторым число, для корректной работы алгоримта./returns>
        public static (int pow, BigInteger value) Exponentiate(int value, int pow)
        {
            if (pow == 0)
            {
                CountSteps += 2;
                return (pow, 1);
            }
            if (pow > 0)
            {
                CountSteps += 5;
                return (pow, Exponentiate(value, pow - 1).value * value);
            }
            return Exponentiate(value, -pow);
        }
    }
}
