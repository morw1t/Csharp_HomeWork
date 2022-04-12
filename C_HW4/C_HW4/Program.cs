using System;

namespace C_HW4
{
    internal class Program
    {
    //    static void Main(string[] args)

    //        Console.WriteLine(GetFullName("Иванович", "Иван", "Иванов"));
    //        Console.WriteLine(GetFullName("Путин", "Владимир", "Владимирович"));
    //        Console.WriteLine(GetFullName("Аудиторе", "Эцио", "да Фиренце"));
    //    }

    //static string GetFullName(string lastName, string firstName, string patronymic)
    //{
    //    return $"{lastName} {firstName} {patronymic}";



    //--------------------------------------------------------------------------------------------
    //    string s;
    //    int sum = 0;
    //    Console.WriteLine("Введите последовательность чисел через пробел: ");
    //    s = Console.ReadLine();
    //    var chars = s.ToCharArray();  //преобразует строку в массив символов     
    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        if (chars[i] != ' ') sum += Convert.ToInt32(chars[i]) - 48; // отнимем 48 это числовой номер нуля в таблице символов ASCII и получим число для сложения
    //        else continue;
    //    }
    //    Console.WriteLine(sum);
    //    Console.ReadKey();

     //--------------------------------------------------------------------------------------------

        enum season { NaN, Winter, Spring, Summer, Autumn }
        static season OfMonth(int n)
        {
            try
            {
                if (n <= 0 || n > 12)
                    throw new Exception("Ошибка: введите число от 1 до 12");
                switch ((n % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return season.NaN;
            }
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "";
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите номер месяца: ");
                Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
            }
            while (true);

        }


       
    }
    
}
