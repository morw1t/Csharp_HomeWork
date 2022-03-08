using System;

namespace HomeWork
{
    internal class Program
    {
        enum mesyac { Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь };
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            string min = Console.ReadLine();
            int a = Convert.ToInt32(min);
            Console.WriteLine("Введите максимальную температуру за сутки");
            string max = Console.ReadLine();
            int b = Convert.ToInt32(max);
            int avg = (a + b) / 2;
            Console.WriteLine("Средняя температура за сутки " + avg);
            Console.ReadKey();


            Console.WriteLine("Введи номер месяца");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 12)
                Console.WriteLine("Некорректный номер!");
            else
                Console.WriteLine("Месяц под номером {0}: {1}", n, (mesyac)(n - 1));
            Console.ReadKey();


            int i;
            Console.WriteLine("введите число: ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("четное число");
            }
            else
            {
                Console.WriteLine("нечетное");
            }
            Console.ReadKey();




            Console.WriteLine("\t\t\tООО 'СуперЧек.ru'");
            int check = 4201;
            Console.WriteLine("\t\t\t   Чек № " + check);
            string user = "Иванов";
            Console.WriteLine("\t\t\t Кассир:" + user);

            int costKirpich = 800;                      //cost - цена, lot - количество.
            int lotKirpich = 10;
            int itogKirpich = costKirpich * lotKirpich;
            Console.WriteLine("\t\t1.Кирпич пустотелый одинарный М-150");
            Console.WriteLine("\t\t  " + costKirpich + " X " + lotKirpich);
            Console.WriteLine("\t\t  Стоимость...................." + itogKirpich);

            int costCement = 5400;
            int lotCement = 1;
            int itogCement = costCement * lotCement;
            Console.WriteLine("\t\t2.Цемент ПЦ-400 Д 20 (мешках)");
            Console.WriteLine("\t\t  " + costCement + " X " + lotCement);
            Console.WriteLine("\t\t  Стоимость...................." + itogCement);

            int costZeben = 480;
            int lotZeben = 5;
            int itogZeben = costZeben * lotZeben;
            Console.WriteLine("\t\t3.Щебень фракция 20х40 т.");
            Console.WriteLine("\t\t  " + costZeben + " X " + lotZeben);
            Console.WriteLine("\t\t  Стоимость...................." + itogZeben);

            int costGvozdi = 163;
            int lotGvozdi = 4;
            int itogGvozdi = costGvozdi * lotGvozdi;
            Console.WriteLine("\t\t4.Гвозди жидкие/ 310 мл");
            Console.WriteLine("\t\t  " + costGvozdi + " X " + lotGvozdi);
            Console.WriteLine("\t\t  Стоимость....................." + itogGvozdi);

            Console.WriteLine("\t\t____________________________________\n" +
                              "\t\t____________________________________");

            Console.WriteLine("\t\tВсего........................." + (itogKirpich + itogCement + itogZeben + itogGvozdi));

            Console.WriteLine("\t\tККМ 00000000 ИНН 00000000000" + " № " + check);
            string dateCheck = DateTime.Now.ToString();
            Console.WriteLine("\t\t" + dateCheck + "          " + user);

            int numberProdaja = 2890;
            Console.WriteLine("\t\tПродажа                       №" + numberProdaja);
            int itogSumma = itogGvozdi + itogKirpich + itogCement + itogZeben;
            Console.WriteLine("\t\tИтог                         =" + itogSumma);

            int nalikPokupatelya = 17000;
            Console.WriteLine("\t\tНаличными                    =" + nalikPokupatelya);

            int sdachaPokupatelu = nalikPokupatelya - itogSumma;
            Console.WriteLine("\t\tСдача                          =" + sdachaPokupatelu);
            Console.ReadKey();
        }
    }
}
