using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWork
{
    class SubProgramm
    {
        public static char[] LineFromUser(string line)
        {
            char[] MyArray = line.ToCharArray();
            foreach (var item in MyArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Введите букву: ");

            char letterFromUser = char.Parse(Console.ReadLine());

            int k = 0;
            int N = MyArray.Length;
            
            foreach (var item in MyArray)
            {
                if (letterFromUser==item)
                {
                    k++;
                }
            }

            Console.WriteLine(k);

            int result = k * 100 / N;

            Console.WriteLine("В массиве всего {0}% таких символов.", result);
            Console.WriteLine();

            return MyArray;
        }

        static public int[,] newArray = new int[10, 10]; /* Объявляем двумерный массив */

 
        public static void MyMatrix()
        {
            Random random = new Random();

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    newArray[i, j] = random.Next(1,9);
                }
            }

            Console.WriteLine("Массив заполнен случайными цифрами и выглядит так:");

            for (int y = 0; y < 10; y++) //перебор массива по координате y;
            {
                for (int x = 0; x < 10; x++) //перебор массива по координате х;
                {
                    Console.Write(newArray[y, x] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Сумма чисел по строкам:");
            Console.WriteLine();

            int summa=0;

            for (int t = 0; t < newArray.GetLength(0); t++) // Сумма по строкам;
            {
                for (int k = 0; k < newArray.GetLength(1); k++)
                {
                    summa += newArray[t, k];                    
                }
     
                Console.WriteLine("Сумма строки " + (t+1) + " равна: "+ summa);
                summa = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Произведение чисел по столбцам: ");
            Console.WriteLine();

            int summa2 = 1; 

            for (int i = 0; i < newArray.GetLength(0); i++) //Произведение по столбцам;
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    summa2 *= newArray[j, i];       
                }
                
                Console.WriteLine("Произведение " + (i + 1) + " столбца равна " + summa2);     //выводим произведение столбца
                summa2 = 1;    //обнуляем полученную сумму
            }

            Console.WriteLine();

            int max = int.MinValue; //Выводим максимальное значение из диагонали;

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                if (newArray[i, i] > max)
                    max = newArray[i, i];
            }
            Console.WriteLine("Элемент с маскимальным значением по диагонали равен: "+max);

        }

    }
}
