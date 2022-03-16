using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_NEW_Cycle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string brackets;
            int openCount = 0;
            int closeCount = 0;
            bool correctFirst = false;
            int maxDepth = 0;

            Console.Write("Введите скобки что бы проверить: ");
            brackets = Console.ReadLine();

            foreach (var bracket in brackets)
            {
                if (bracket == '(')
                {
                    correctFirst = true;
                    openCount++;
                }
                else
                {
                    closeCount++;
                    if(openCount >= closeCount)
                    {
                        maxDepth = openCount;
                    }
                    if (closeCount >= openCount)
                    {
                        maxDepth = closeCount;
                    }
                }
            }

            if (closeCount > openCount || openCount > closeCount)
            {
                Console.WriteLine("Это не допустимое выражение.");
                Console.WriteLine("Максимальная глубина - " + maxDepth);
            }
            if(openCount == closeCount && correctFirst)
            {
                Console.WriteLine("Это допустимое выражение.");
                Console.WriteLine("Максимальная глубина - " + maxDepth);
            }
        }
    }
}
