using System.Collections.Generic;
using System.Linq;

namespace Module_1
{
    public sealed class ArrayUnique
    {
        // Task #1
        // Нахождение уникальных символов в слове
        public List<char> UniqueLetters(string word)
        {
            // Коллекция символов
            List<char> chars = word.ToList();
            // Коллекция для вывода данных из функции
            List<char> returnChar = new List<char>();
            // Временная переменная
            char tempChar = ' ';

            for (int i = 0; i < chars.Count; i++)
            {
                tempChar = chars[i];
                // Условие для добавления 
                bool flagAdd = true;
                // Итерируемся по новому массиву и сравниваем данные
                for (int q = 0; q < returnChar.Count; q++)
                {
                    if (tempChar == returnChar[q])
                    {
                        flagAdd = false;
                    }
                }
                if (flagAdd)
                    returnChar.Add(tempChar);
            }
            return returnChar;
        }

        // Task #2
        // Нахождение уникального числа в массиве. Возвращает первое число которое повторяется или -1
        public int UniqueNumbersFromTheArray(int[][] array)
        {
            // Перменная для вывода
            int numbersReturn = -1;
            // Временная переменная для записи значения и дальнейшего сравнения
            int tempNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    // Записали данные
                    tempNumbers = array[i][j];

                    for (int e = 0; e < array.Length; e++)
                    {
                        for (int q = 0; q < array[e].Length; q++)
                        {
                            if (tempNumbers == array[e][q] && i != e && j != q)
                            {
                                numbersReturn = tempNumbers;
                                break;
                            }
                        }
                    }
                }
            }
            return numbersReturn;
        }
    }
}
