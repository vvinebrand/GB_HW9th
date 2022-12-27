using System;
using System.Text;

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("\nЗадача 1. Вывод всех натуральных чисел в промежутке от N до 1 \nЗадача 2.\nЗадача 3.\nВведите 0 для выхода\n");
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


            break;

        case 3:


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
