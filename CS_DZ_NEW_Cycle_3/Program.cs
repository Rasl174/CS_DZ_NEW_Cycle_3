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
            int depth = 0;
            int maxDepth = 0;

            Console.Write("Введите скобки что бы проверить: ");
            brackets = Console.ReadLine();

            foreach (var bracket in brackets)
            {
                if (bracket == '(')
                {
                    depth++;
                    maxDepth = depth;
                }
                else
                {
                    depth--;
                    if (depth < 0)
                    {
                        Console.WriteLine("Это не допустимое выражение.");
                        break;
                    }
                }
            }

            if (depth > 0)
            {
                Console.WriteLine("Это не допустимое выражение.");
            }

            if(depth == 0)
            {
                Console.WriteLine("Это допустимое выражение.");
                Console.WriteLine("Максимальная глубина - " + maxDepth);
            }
        }
    }
}
