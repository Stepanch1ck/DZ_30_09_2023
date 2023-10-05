using System;

namespace Tumakov_Lab_5
{
    internal class Program
    {
        public static int Max(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
        public static void Swap(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Число 1: {num1} \nЧисло 2: {num2}") ;

        }
        public static bool Factorial(int num1, out int result )
        {
            checked
            {
                if ( num1 < 0 ) 
                {
                    result = 0 ;
                    return false;
                }
                result = 1;
                for (int i = 1; i<=num1; i++)
                {
                    result *= i;
                }
                return true;
            }
        }
        public static int FactorialREC(int num1) 
        {
            if (num1 < 0 )
            {
                return 0 ;
            }
            if (num1 == 0)
            {
                return 1 ;
            }
            return num1*FactorialREC(num1-1);
        }
        public static int GCD(int num1, int num2)
        {
            while (num2!=0)
            {
                int temp = num1 % num2;
                num1 = num2;
                num2 = temp;
            }
            return num1;
        }
        public static int GCD(int num1, int num2, int num3)
        {
            while (num3 != 0)
            {
                int temp = GCD(num1,num2);
                num1 = num2;
                num2 = temp % num3;
                num3 = temp / num3;
            }
            return num1;
        }
        public static int Febonaci(int num)
        {
            if (num == 0 || num == 1)
            {
                return num;
            }
            return Febonaci(num - 1) + Febonaci(num - 2);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("  Тумаков Лабораторная работа 5\nУпражнение 5.1: Написать метод, возвращающий наибольшее из двух чисел.");
            Console.WriteLine("Введите первое число:");
            if (!int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine("Введите второе число:");
            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine("Максимальное:" + Max(number1,number2));
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Упражнение 5.2: Написать метод, который меняет местами значения двух передаваемых параметров.");
            Console.WriteLine("Введите первое число:");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine("Введите второе число:");
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Введено не число");
            }
            Swap(number1, number2);
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Упражнение 5.3: Написать метод вычисления факториала числа, результат вычислений передавать в выходном параметре.");
            Console.WriteLine("Введите число:");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Введено не число");
            }
            
            if (Factorial(number1, out int res))
            {
                Console.WriteLine($"Факториал числа {number1} равен {res} ");
            }
            else
            {
                Console.WriteLine("Произошла ошибка переполнения");
            }
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Упражнение 5.4: Написать рекурсивный метод вычисления факториала числа.");
            Console.WriteLine("Введите число:");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine($"Факториал числа {number1} равен {FactorialREC(number1)} ");
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 5.1: Написать метод, который вычисляет НОД двух натуральных чисел(алгоритм Евклида).\nНаписать метод с тем же именем, который вычисляет НОД трехнатуральных чисел.");
            Console.WriteLine("Введите первое число:");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine("Введите второе число:");
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine("Введите третье число:");
            if (!int.TryParse(Console.ReadLine(), out int number3))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine($"НОД(для двух чисел) чисел: {GCD(number1,number2)}");
            Console.WriteLine($"НОД(для трёх чисел) чисел: {GCD(number1, number2,number3)}");
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 5.2: Написать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи.");
            Console.WriteLine("Введите первое число:");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine($"Значение n-ого элемента: {Febonaci(number1)}");
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

        }
    }
}
