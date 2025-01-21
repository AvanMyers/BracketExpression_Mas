using System;

namespace BracketExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deep = 0;
            int maxDeep = 0;
            char bracketLeft = ')';
            char bracketRight = '(';
            int bracketEndResult = 0;
            string bracketExpression = "";

            Console.WriteLine("Введите скобочное выражение: ");
            bracketExpression = Console.ReadLine();

            for (int i = 0; i < bracketExpression.Length; i++)
            {
                if (bracketExpression[i] == bracketRight)
                    deep++;
                else if (bracketExpression[i] == bracketLeft)
                    deep--;

                if (deep < 0)
                {
                    break;
                }

                    if (deep > maxDeep)
                        maxDeep = deep;
            }

            if (deep == 0)
                Console.WriteLine($"{bracketExpression} строка корректная и максимум глубины равняется {maxDeep}.");
            else Console.WriteLine($"{bracketExpression} строка не корректна");

            Console.ReadKey();
        }
    }
}
