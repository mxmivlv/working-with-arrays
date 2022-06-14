using System;
using System.Collections.Generic;

namespace Module_1
{
    public sealed class ArrayUniqueSorted
    {
		// Task #1
		// Нахождение и создание коллекции с уникальным ключом и количеством его повторения в качестве значения
		public Dictionary<long, long> NumberAndNumberOfApplications(long[] phoneNumbers)
		{
			// Коллекция для вывода
			Dictionary<long, long> result = new Dictionary<long, long>();
			// В переменную записываем данные из входного массива, нулевой позиции
			long tempPhone = phoneNumbers[0];
			// Счетчик для количества повторов во входном массиве
			int count = 1;

			for (int i = 1; i < phoneNumbers.Length; i++)
			{
				// Если предыдущая позиция не равна следующей
				if (tempPhone != phoneNumbers[i])
				{
					// Добавляем в коллекцию
					result.Add(tempPhone, count);
					count = 1;
					tempPhone = phoneNumbers[i];
				}
				else
				{
					count++;
				}
			}
			result.Add(tempPhone, count);

			return result;
		}

		// Task #2
		// Из строкового предстваления создать коллекцию с ключом и значением. Уникальный ключ и в качестве значения - среднее значение всех элементов этого ключа => BTS 514
		public Dictionary<string, double> CurrencyAndItAaverageValue(string fileContents)
		{
			// Коллекция для вывода
			Dictionary<string, double> result = new Dictionary<string, double>();
			// Условие для добавления
			bool flagAdd = false;
			// Массив строк
			string[] tempString = fileContents.Split("\n");
			// Массив слов
			string[] tempWord = tempString[0].Split(":");

			// В текущую переменную кдадем название крипт.
			string tempNameСurrent = tempWord[0].Trim();
			// В текущую переменную кладем сумму крипт.
			double tempValueСurrent = Convert.ToDouble(tempWord[1].Trim());

			// Перменная для следующей позиции в массиве
			string tempNameNext = String.Empty;
			// Перменная для следующей позиции
			double tempValueNext = 0;

			// Счетчик повторений
			int count = 0;

			for (int i = 1; i < tempString.Length; i++)
			{
				tempWord = tempString[i].Split(":");

				tempNameNext = tempWord[0].Trim();
				tempValueNext = Convert.ToDouble(tempWord[1].Trim());

				// Если есть повтор
				if (tempNameСurrent == tempNameNext)
				{
					count++;
					tempValueСurrent += tempValueNext;
				}
				// если нет
				else
				{
					// Условие для добавления
					flagAdd = true;
				}
				if (flagAdd)
				{
					count++;
					result.Add(tempNameСurrent, (tempValueСurrent / count));
					// В текущую позиция пишем данные следущей позиции
					tempNameСurrent = tempNameNext;
					tempValueСurrent = tempValueNext;

					flagAdd = false;
					count = 0;
				}
			}
			count++;
			result.Add(tempNameСurrent, (tempValueСurrent / count));

			return result;
		}
	}
}
