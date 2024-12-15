using System;

namespace FunctionsExample
{
    class Program
    {
        // 1
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // 2
        public static void GreetUser (string name)
        {
            Console.WriteLine($"Привет, {name}!");
        }

        // 3
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // 4
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 5
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // 6
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7
        public static int CountCharacter(string input, char character)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == character)
                {
                    count++;
                }
            }
            return count;
        }

        // 8
        public static long Factorial(int number)
        {
            if (number < 0) throw new ArgumentException("Факториал не определен для отрицательных чисел.");
            if (number == 0) return 1;
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // 9
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // 10
        public static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static void Main(string[] args)
        {
            // Примеры использования функций
            Console.WriteLine($"Сумма: {Sum(5, 10)}");
            GreetUser ("Алексей");
            Console.WriteLine($"Максимум: {Max(5, 10)}");
            Console.WriteLine($"Четность 4: {IsEven(4)}");
            Console.WriteLine($"Температура 20°C в °F: {CelsiusToFahrenheit(20)}");
            Console.WriteLine($"Обратная строка 'Привет': {ReverseString("Привет")}");
            Console.WriteLine($"Количество 'а' в 'Караван': {CountCharacter("Караван", 'а')}");
            Console.WriteLine($"Факториал 5: {Factorial(5)}");
            Console.WriteLine($"Число 7 простое? {IsPrime(7)}");
            Console.WriteLine($"Случайное число от 1 до 100: {GenerateRandomNumber(1, 100)}");
        }
    }
}
