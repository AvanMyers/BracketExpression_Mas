using System;

namespace BracketExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bracket = 0;
            int deep = 0;
            int bracketEndResult = 0;
            string bracketExpression = "";

            Console.WriteLine("Введите скобочное выражение: ");
            bracketExpression = Console.ReadLine();

            for (int i = 0; i < bracketExpression.Length; i++)
            {
                if (bracketExpression[i] == '(')
                    bracket++;
                else if (bracketExpression[i] == ')')
                    bracket--;

                if (bracket == bracketEndResult && bracketExpression[i] != ')')
                    bracket--;

                if (bracket > deep)
                    deep = bracket;
            }

            if (bracketExpression[0] != '(' || bracketExpression[bracketExpression.Length - 1] != ')' || bracket != bracketEndResult)
                Console.WriteLine($"{bracketExpression} строка не корректна");
            else Console.WriteLine($"{bracketExpression} строка корректная и максимум глубины равняется {deep}.");

            Console.ReadKey();
        }
    }
}
