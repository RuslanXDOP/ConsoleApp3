using System;
class Calculator
{
    static void Main()
    {
        bool continueCalculations = true;

        while (continueCalculations)
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            char operationChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operationChoice < '+' || operationChoice > '/')
            {
                Console.WriteLine("Некорректный выбор операции. Пожалуйста, выберите снова.");
                continue;
            }

            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Ошибка ввода числа, введите снова.");
                continue;
            }

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Ошибка ввода числа. Пожалуйста, введите число снова.");
                continue;
            }

            double c = 0;

            switch (operationChoice)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: нельзя делить на ноль.");
                        continue;
                    }
                    c = a / b;
                    break;
            }

            Console.WriteLine("Результат: " + c);
        }

        Console.WriteLine("Еще увидимся");
    }
}

