using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            matrix[0, 0] = 1;
            matrix[1, 1] = 9;
            matrix[2, 2] = 5;
            System.Console.Write($"{matrix[0, 0]} ");
            System.Console.Write($"{matrix[1, 1]} ");
            System.Console.Write($"{matrix[2, 2]}");
            Console.ReadKey();


            string s = "Hello!";
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);
            Console.ReadKey();

            string[,] phoneBook = new string[2, 2];

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.WriteLine("Введите имя: " + i + "\n" + "Введите тел. номер: " + j);
                    phoneBook[i, j] = Console.ReadLine();
                }

            }

            Console.WriteLine();

            for (int y = 0; y < phoneBook.GetLength(0); y++)
            {
                for (int x = 0; x < phoneBook.GetLength(1); x++)
                {
                    Console.Write(phoneBook[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
