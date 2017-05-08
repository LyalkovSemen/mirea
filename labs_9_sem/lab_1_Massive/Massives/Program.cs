using System;
using System.Text;

namespace Massives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive;
            try
            {
                massive = AskFormassive();
                int[] massive2 = new int[massive.Length];
                massive2 = (int[])massive.Clone();
                Console.WriteLine("Исходный массив: " + GetArrayString(massive));
                RotateArray(massive, AskForOffset());
                Console.WriteLine("Массив со сдвигом: " + GetArrayString(massive));
                Console.WriteLine("");
                Console.WriteLine("Нахождение непарного элемента в массиве...");
                try
                {
                    Console.WriteLine("Непарный элемент: " + FindNonPairedOdd(massive2));
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    massive = AskFormassive(true);
                    Console.WriteLine("Непарный элемент: " + FindNonPairedOdd(massive2));
                }
                GetAnyKey();
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                GetAnyKey();
                return;
            }
        }

        private static void RotateArray(int[] array, int offset)
        {
            if (offset == 0) return;
            if (offset < 0)
                offset = -offset;
            else
                offset = array.Length - offset;
            Array.Reverse(array, 0, offset);                            // Разворот части массива. Аргументы: массив, начальный элемент,
            Array.Reverse(array, offset, array.Length - offset);        // длина разворачиваемой последовательности.
            Array.Reverse(array);                                       // Работает за O(n), где n - длина разворачиваемой последовательности, согласно MSDN.
        }

        private static int FindNonPairedOdd(int[] array)
        {
            int result = 0;
            //а четное ли количество элементов в массиве
            if (array.Length % 2 == 0)
                throw new Exception("Массив должен содержать нечетное число элементов.");
            result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                //побитовое OR (или), быстрое решение специфической задачи
                result = result ^ array[i];
            }
            return result;
        }

        private static int[] AskFormassive(bool odd = false)
        {
            int[] massive;
            bool retry = false;
            do
            {
                try
                {
                    massive = QueryIntegers();
                    if (odd && massive.Length % 2 == 0)
                    {
                        throw new Exception("Массив должен содержать нечетное число элементов.");
                    }
                    return massive;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    retry = TryAgain();
                }
            } while (retry);
            String exceptionString = "Некорректные значения элементов массива. Завершение работы.";
            if (odd)
            {
                exceptionString += " Массив должен содержать нечетное число элементов.";
            }
            throw new Exception(exceptionString);
        }

        
        private static int[] QueryIntegers()
        {
            Console.WriteLine("Введите элементы массива через пробел: ");
            string[] massive = Console.ReadLine().Split(' ');
            int[] numbers = new int[massive.Length];
            for (int i = 0; i < massive.Length; i++)
            {
                try
                {
                    numbers[i] = int.Parse(massive[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка в числе: " + e.Message);
                    throw new Exception("Не удалось преобразовать  в число.", e);
                }
            }
            return numbers;
        }

        private static int AskForOffset()
        {
            int offset = 0;
            Console.WriteLine("Введите, на сколько элементов сдвинуть массив: ");
            while (true)
            {
                try
                {
                    offset = int.Parse(Console.ReadLine());
                    return offset;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка ввода: " + e.Message + " Попробуйте еще раз");
                    continue;
                }
            }
        }

        private static bool TryAgain(String message = "Хотели бы вы повторить последний этап?")
        {
            Console.WriteLine(message);
            Console.WriteLine("Пожалуйста, введите y, если да, либо любой другой символ, если нет.");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (input == 'y' || input == 'Y' || input == 'д' || input == 'Д')
            {
                return true;
            }
            return false;
        }

        private static String GetArrayString(int[] array)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                temp.Append(array[i]);
                temp.Append(' ');
            }
            return temp.ToString();
        }

        private static void GetAnyKey()
        {
            Console.WriteLine("Введите любой символ...");
            Console.ReadKey();
            Console.WriteLine();
        }

    }
}
