using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст, чтобы подсчитать количество пробелов. Введите точку (.) для завершения.");

        int spaceCount = 0;
        char input;

        do
        {
            input = Console.ReadKey().KeyChar;
            if (input == ' ')
            {
                spaceCount++;
            }
        } while (input != '.');

        Console.WriteLine($"\nКоличество пробелов: {spaceCount}");
    }
}
