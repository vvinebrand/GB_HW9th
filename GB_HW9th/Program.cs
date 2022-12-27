using System;
using System.Text;

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("\nЗадача 1. \nЗадача 2.\nЗадача 3.\nВведите 0 для выхода\n");
    Console.Write("Введите номер задачи: ");
    programm = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (programm)
    {
        case 1:


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