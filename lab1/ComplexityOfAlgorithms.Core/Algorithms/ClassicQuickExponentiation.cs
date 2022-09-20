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
    public class ClassicQuickExponentiation : IExecutable
    {
        public void Execute() 
        {
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Вы выбрали классический быстрый алгоритм возведения в степень.");
            List<string> outputData = new();
            outputData.Add(new string("Pow" + "\t" + "Count steps"));
            (int Pow, BigInteger Value) result = new();
            for (int i = 1; i <= 100; i += 5)
            {
                if (i == 11)
                {
                    i -= 1;
                    result = ClassicQuickExponentiation.Exponentiate(5, i);
                }
                else
                {
                    result = ClassicQuickExponentiation.Exponentiate(5, i);
                }
                outputData.Add(result.Pow + "\t" + result.Value);
            }
            File.WriteAllLines("..//..//..//results/8/8.4_result.txt", outputData);
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Файлы успешно созданы");
        }

        /// <summary>
        /// Классический быстрый алгоритм возведения числа в степень.
        /// </summary>
        /// <param name="value">Значение, которое возводится в степень.</param>
        /// <param name="pow">Степень, в которую нужно возвести значение.</param>
        /// <returns>Возвращается первым степень, в которую возводится число. Вторым количество шагов, которое проходится алгоритмом./returns>
        public static (int Pow, int Count) Exponentiate(int value, int pow)
        {
            int countSteps = 3;
            int c = value;
            BigInteger result = 1;
            int k = pow;

            while (k != 0)
            {
                countSteps += 1;
                if (k % 2 == 0)
                {
                    c *= c;
                    k = k / 2;
                    countSteps += 3;
                }
                else
                {
                    result = result * c;
                    k = k - 1;
                    countSteps += 3;
                }
            }
            countSteps += 1;
            return (pow, countSteps);
        }
    }
}
