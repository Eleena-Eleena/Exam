using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзамен
{
    class Program
    {
        static void Main(string[] args)
        {
        ref1: Console.Write("Введите конец диапозона от 2 до : ");
            int n = 0;
            if (!EnterNumber.TryGetPossitiveNumber(out n))
            {
                goto ref1;
            }
            var a = new A();
            var result = a.FindSimple(n);

            Console.Write($" - это простые числа\n");
                       
            Console.Write("{0} - количество простых чисел", a.kol);
            Console.Write("\nХотите продолжить? Введите 'y' ");
            if (Console.ReadLine() == "y")
            {
                goto ref1;
            }
        }
    }

    public static class EnterNumber
    {
        public static bool TryGetPossitiveNumber(out int n)
        {
            if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Число введено неправильно \n");
                return false;
            }
            return true;
        }
             public static bool TryGetAnyNumber(out double n)
        {
            if (!Double.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Число введено неправильно");
                return false;
            }
            return true;
        }
    }
    public class A
    {
        public int kol;
        public int FindSimple(double n)

        {
            kol = 0;
            for (int i = 2; i <= n; i++)
            {
                bool result = true;
               
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 & i % 1 == 0)
                    {
                        result = false;
                    }
                }
                if (result)
                {
                    Console.Write("{0} ", i);
                    kol++;
                }
            }
            return 0;
        }
     }
}