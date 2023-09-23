double num = 0.0f;
double num_first = 0.0f;
double num_second = 0.0f;

int operation;

Console.Write("1. Сложить 2 числа \n" +
    "2. Вычесть первое из второго \n" +
    "3. Перемножить два числа \n" +
    "4. Разделить первое на второе \n" +
    "5. Возвести в степень N первое число \n" +
    "6. Найти квадратный корень из числа \n" +
    "7. Найти 1 процент от числа \n" +
    "8. Найти факториал из числа \n" +
    "9. Выйти из программы \n \n" +
    "Введите операцию: ");

while (true)
{
    operation = int.Parse(Console.ReadLine());

    try
    {
        if (operation == 6 || operation == 8)
        {
            Console.Write("Введите число: ");
            num = double.Parse(Console.ReadLine());
        }
        else if (operation < 9)
        {
            Console.Write("Введите первое число: ");
            num_first = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            num_second = double.Parse(Console.ReadLine());
        }
    }
    catch
    {
        Console.WriteLine("Вы ввели не число");
        break;
    }

    switch (operation)
    {
        case 1:
            Console.WriteLine($"Решение: {num_first + num_second}");
            break;
        case 2:
            Console.WriteLine($"Решение: {num_first - num_second}");
            break;
        case 3:
            Console.WriteLine($"Решение: {num_first * num_second}");
            break;
        case 4:
            Console.WriteLine($"Решение: {num_first / num_second}");
            break;
        case 5:
            Console.WriteLine($"Решение: {Math.Pow(num_first, num_second)}");
            break;
        case 6:
            Console.WriteLine($"Решение: {Math.Sqrt(num)}");
            break;
        case 8:
            double result = 1.0f;
            for (int i = 1; i < num + 1; i++)
                result *= i;
            Console.WriteLine($"Решение: {result}");
            break;
        case 7:
            Console.WriteLine($"Решение: {num_first * num_second / 100}");
            break;
        default:
            if (operation != 9)
                Console.WriteLine("Вы ввели не верное число");
            break;
    }

    if (operation == 9)
        break;
    else
    {
        Console.Write("Введите операцию ещё раз: ");
        continue;
    }
}