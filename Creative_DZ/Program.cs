using System;
using System.Threading;

namespace Creative_DZ
{
    internal class Program
    {
        public static int Sum(params int[] numbers) 
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static void Prod(int[] numbers, ref int prod)
        {
            prod = 1;
            foreach (int num in numbers)
            {
                prod *= num;
            }
        }
        public static void Average(int[] numbers, out double average)
        {
            int sum =Sum(numbers);
            average = sum / numbers.Length;
        }
        public enum LevelOfGrouchiness
        {
            Low,
            Medium,
            High
        }

        public struct Grandpa
        {
            public string Name { get; set; }
            public LevelOfGrouchiness Grouchiness { get; set; }
            public string[] Curses { get; set; }
            public int BlackEyesCount { get; set; }

            public Grandpa(string name, LevelOfGrouchiness grouchiness, string[] curses)
            {
                Name = name;
                Grouchiness = grouchiness;
                Curses = curses;
                BlackEyesCount = 0;

            }
            public static string[] BadWords = { "блядь", "ёкарный бабай", "пиздец", "охуеть" };

            public int CountBlackEyes(params string[] badWords)
            {
                int blackEyesCount = 0;
                for (int i = 0; i < Curses.Length; i++)
                {
                    for (int j = 0; j < BadWords.Length; j++)
                    {
                        if (Curses[i].Equals(BadWords[j]))
                        {
                            blackEyesCount++;
                            break;
                        }
                    }
                }
                return blackEyesCount;
            }
        }
            static void Main(string[] args)
        {

            Console.WriteLine("1 Задаание: Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,\r\nкоторые нужно поменять местами. Вывести на экран получившийся массив.\n");
            int[] numbers = new int[20];
            Random random = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\nВведите номер первого числа:");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine("Введите номер второго число:");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Введено не число");
            }
            int temp = numbers[num1 - 1];
            numbers[num1 - 1] = numbers[num2 - 1];
            numbers[num2 - 1] = temp;
            Console.WriteLine("Получившийся массив:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nНажмите Enter");
            Console.ReadKey();

            Console.WriteLine("2 Задание:Вывести сумму, произведение и среднее арифметическое элементов массива");
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            int prod = 1;
            Prod(numbers, ref prod);
            double average;
            Average(numbers, out average);

            Console.WriteLine($"\nСумма: {Sum(numbers)} \nПроизведение: {prod} \nСреднее арифметическое {average}");
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("3 Задание: нарисовать цифры от 0 до 9 или ошибка ");
            while (true)
            {
                string number = Console.ReadLine();
                int num;
                if (number.Equals("exit") || number.Equals("закрыть"))
                {
                    break;
                }
                try
                {
                    if (!int.TryParse(number, out num))
                    {
                        throw new ArgumentException("Введено не число");
                    }

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Введено не число");
                    continue;
                }
                if (num < 0 || num > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Число должно быть от 0 до 9");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    switch (num)
                    {
                        case 0:
                            Console.WriteLine(" ## " +
                                             "\n#   #" +
                                             "\n#   #" +
                                             "\n ##");
                            break;
                        case 1:
                            Console.WriteLine("   #" +
                                                  "\n ###" +
                                                  "\n   #" +
                                                  "\n   #");
                            break;
                        case 2:
                            Console.WriteLine(" ###" +
                                                  "\n#  #" +
                                                  "\n  # " +
                                                  "\n #  " +
                                                  "\n####");
                            break;
                        case 3:
                            Console.WriteLine("####" +
                                                  "\n   #" +
                                                  "\n ###" +
                                                  "\n   #" +
                                                  "\n####");
                            break;
                        case 4:
                            Console.WriteLine("#  #" +
                                                  "\n#  #" +
                                                  "\n####" +
                                                  "\n   #" +
                                                  "\n   #");
                            break;
                        case 5:
                            Console.WriteLine("####" +
                                                  "\n#   " +
                                                  "\n####" +
                                                  "\n   #" +
                                                  "\n### ");
                            break;
                        case 6:
                            Console.WriteLine("####" +
                                                  "\n#   " +
                                                  "\n####" +
                                                  "\n#  #" +
                                                  "\n####");
                            break;
                        case 7:
                            Console.WriteLine("####" +
                                                  "\n   #" +
                                                  "\n  # " +
                                                  "\n  # ");
                            break;
                        case 8:
                            Console.WriteLine("####" +
                                                  "\n#  #" +
                                                  "\n####" +
                                                  "\n#  #" +
                                                  "\n####");
                            break;
                        case 9:
                            Console.WriteLine("####" +
                                                  "\n#  #" +
                                                  "\n####" +
                                                  "\n   #" +
                                                  "\n####");
                            break;

                    }
                }

            }
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Задание 4:");

            // Создать 5 дедов
            Grandpa grandpa1 = new Grandpa("Иван", LevelOfGrouchiness.Low, new string[] { "проститутки","охуеть", "гады" });
            Grandpa grandpa2 = new Grandpa("Петр", LevelOfGrouchiness.Medium, new string[] { "блядь", "пиздец" });
            Grandpa grandpa3 = new Grandpa("Сергей", LevelOfGrouchiness.High, new string[] { "коронавирус", "война" });
            Grandpa grandpa4 = new Grandpa("Василий", LevelOfGrouchiness.Low, new string[] { "ёкарный бабай", "дверь" });
            Grandpa grandpa5 = new Grandpa("Дмитрий", LevelOfGrouchiness.Medium, new string[] { "деньги", "работа" });

            // Вывести количество синяков от ударов бабки
            Console.WriteLine("Количество синяков у Ивана: {0}", grandpa1.CountBlackEyes("проститутки", "пады"));
            Console.WriteLine("Количество синяков у Петра: {0}", grandpa2.CountBlackEyes("блять", "пиздец"));
            Console.WriteLine("Количество синяков у Сергея: {0}", grandpa3.CountBlackEyes("коронавирус", "война"));
            Console.WriteLine("Количество синяков у Василия: {0}", grandpa4.CountBlackEyes("ёкарный бабай", "дверь"));
            Console.WriteLine("Количество синяков у Дмитрия: {0}", grandpa5.CountBlackEyes("деньги", "работа"));
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
        }
    }
}
