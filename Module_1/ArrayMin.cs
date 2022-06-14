using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    public sealed class ArrayMin
    {
        // Task #1
        // Нахождение самых маленьких элементов в массиве, в заданном количестве
        public int[] SmallestElementsOfTheArray(int[] array, int countSmallElements)
        {
            // Массив для вывода
            int[] result = new int[countSmallElements];
            // В нулевую позицию записываем минимальное значение
            result[0] = int.MinValue;

            // Перменная, которая содержит последние данные о добавлении в массив
            int noAddItem = int.MinValue;

            for (int j = 0; j < countSmallElements; j++)
            {
                int tempNumberCurrent = array[j];

                for (int i = 1; i < array.Length; i++)
                {
                    if ((tempNumberCurrent > array[i]) && (array[i] > noAddItem))
                    {
                        tempNumberCurrent = array[i];
                    }
                }

                result[j] = tempNumberCurrent;
                noAddItem = tempNumberCurrent;
            }
            return result;
        }
    }
}
