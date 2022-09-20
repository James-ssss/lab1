using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI
{
    public class ConsoleHelper
    {
        public static void ClearScreen()
        {
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new String(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, 0);
        }

        public static bool GetYesNoAnswer()
        {
            var positiveAnswers = new[] { "y", "yes", "да" };
            var negativeAnswers = new[] { "n", "no", "нет" };

            string answer;
            do
            {
                answer = Console.ReadLine();
                if (!positiveAnswers.Contains(answer) && !negativeAnswers.Contains(answer))
                {
                    Console.WriteLine("Недопустимый ответ.");
                }
            } while (!positiveAnswers.Contains(answer) && !negativeAnswers.Contains(answer));

            return positiveAnswers.Contains(answer);
        }
    }

}
