using System;
using System.IO;
namespace C_HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text, path;
            Console.WriteLine("Вводите текст. Нажмите Enter для завершения: ");
            text = Console.ReadLine();
            Console.WriteLine("Введите путь и имя файла для сохранения в формате C:\\File.txt:");
            path = Console.ReadLine();
            File.WriteAllText(path, text);
            Console.WriteLine("Сохранено успешно.");
            Console.ReadKey();
            return;

        }
    }
}
