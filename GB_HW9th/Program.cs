using System;
using System.Text;

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("\nЗадача 1. Вывод всех натуральных чисел в промежутке от N до 1 \nЗадача 2. Сумма натуральных элементов в промежутке\nЗадача 3.\nВведите 0 для выхода\n");
    Console.Write("Введите номер задачи: ");
    programm = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (programm)
    {
        case 1:

            Console.Write("Введите натуральное число больше 1: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            NumberCounter(number);
            Console.WriteLine();

            break;

        case 2:

            Console.Write("Введите начальное число M: ");
            int numberM = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите начальное число N: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine();

            GapNumberSum(numberM, numberN, 0);

            break;

        case 3:

            Console.Write("Введите начальное число M:");
            int numberA = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите начальное число N:");
            int numberB = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Функция Аккермана для чисел A({numberA},{numberB}) = {AckermannFunction(numberA, numberB)}");

            break;
        default:
            begin = false;
            break;
    }
}


void NumberCounter(int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}",number);
    NumberCounter(number - 1);
}

void GapNumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

int AckermannFunction(int numberA, int numberB)
{
    if (numberA == 0) return numberB + 1;
    if (numberA != 0 && numberB == 0) return AckermannFunction(numberA - 1, 1);
    if (numberA > 0 && numberB > 0) return AckermannFunction(numberA - 1, AckermannFunction(numberA, numberB - 1));
    return AckermannFunction(numberA, numberB);
}
