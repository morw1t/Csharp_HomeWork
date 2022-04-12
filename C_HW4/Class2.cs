using System;

namespace C_HW4
{
    internal class Program
    {
        static void Main(string[] args)

            Console.WriteLine(GetFullName("Иванович", "Иван", "Иванов"));
            Console.WriteLine(GetFullName("Путин", "Владимир", "Владимирович"));
            Console.WriteLine(GetFullName("Аудиторе", "Эцио", "да Фиренце"));
        }

    static string GetFullName(string lastName, string firstName, string patronymic)
    {
        return $"{lastName} {firstName} {patronymic}";